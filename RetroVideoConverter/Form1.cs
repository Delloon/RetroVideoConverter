using RetroVideoConverter.Helpers;
using RetroVideoConverter.Models;
using RetroVideoConverter.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RetroVideoConverter
{
    public partial class Form1 : Form
    {
        private readonly List<string> _files = new List<string>();
        private readonly EncoderDiscoveryService _encoderDiscoveryService = new EncoderDiscoveryService();
        private readonly FFprobeService _ffprobeService = new FFprobeService();
        private readonly FFmpegService _ffmpegService = new FFmpegService();

        private string FfmpegPath
        {
            get
            {
                return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tools", "ffmpeg.exe");
            }
        }

        private string FFprobePath
        {
            get
            {
                return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tools", "ffprobe.exe");
            }
        }

        public Form1()
        {
            InitializeComponent();

            // Подписка на события кнопок
            btnAddFiles.Click += btnAddFiles_Click;
            btnRemoveSelected.Click += btnRemoveSelected_Click;
            btnBrowseOutput.Click += btnBrowseOutput_Click;
            btnRefreshEncoders.Click += btnRefreshEncoders_Click;
            btnConvert.Click += btnConvert_Click;

            // загрузка значений
            LoadDefaults();
        }

        private void LoadDefaults()
        {
            cmbFormat.Items.Clear();
            cmbResolution.Items.Clear();
            cmbVideoEncoder.Items.Clear();

            cmbFormat.Items.Add(new FormatOption { Name = "3GP", Extension = "3gp" });
            cmbFormat.Items.Add(new FormatOption { Name = "MP4", Extension = "mp4" });
            cmbFormat.Items.Add(new FormatOption { Name = "AVI", Extension = "avi" });

            if (cmbFormat.Items.Count > 0)
                cmbFormat.SelectedIndex = 0;

            cmbResolution.Items.Clear();

            cmbResolution.Items.Add(new ResolutionPreset { Name = "96p", MaxWidth = 128, MaxHeight = 96 });
            cmbResolution.Items.Add(new ResolutionPreset { Name = "144p", MaxWidth = 176, MaxHeight = 144 });
            cmbResolution.Items.Add(new ResolutionPreset { Name = "240p", MaxWidth = 320, MaxHeight = 240 });
            cmbResolution.Items.Add(new ResolutionPreset { Name = "360p", MaxWidth = 480, MaxHeight = 360 });
            cmbResolution.Items.Add(new ResolutionPreset { Name = "480p", MaxWidth = 640, MaxHeight = 480 });

            cmbResolution.SelectedIndex = 2;

            if (cmbResolution.Items.Count > 0)
                cmbResolution.SelectedIndex = 1;

            chkKeepAspect.Checked = true;

            if (txtLog != null)
                txtLog.Clear();

            RefreshEncoders();
        }

        private void RefreshEncoders()
        {
            cmbVideoEncoder.Items.Clear();

            if (!File.Exists(FfmpegPath))
            {
                Log("Не найден ffmpeg.exe: " + FfmpegPath);
                return;
            }

            List<EncoderOption> encoders = _encoderDiscoveryService.GetAvailableEncoders(FfmpegPath);

            int i;
            for (i = 0; i < encoders.Count; i++)
            {
                cmbVideoEncoder.Items.Add(encoders[i]);
            }

            if (cmbVideoEncoder.Items.Count > 0)
            {
                cmbVideoEncoder.SelectedIndex = 0;
                Log("Загружены только реально доступные кодеки для текущего ПК.");
            }
            else
            {
                Log("Не найдено ни одного подходящего кодека.");
            }
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Filter = "Видео|*.mp4;*.avi;*.mkv;*.mov;*.wmv;*.flv;*.webm|Все файлы|*.*";

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                int i;
                for (i = 0; i < ofd.FileNames.Length; i++)
                {
                    string file = ofd.FileNames[i];

                    if (_files.Contains(file))
                        continue;

                    _files.Add(file);

                    string fileName = Path.GetFileName(file);
                    string folder = Path.GetDirectoryName(file);

                    lstFiles.Items.Add(fileName + " (" + folder + ")");
                }

                Log("Добавлено файлов: " + ofd.FileNames.Length);
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            int index = lstFiles.SelectedIndex;

            if (index < 0)
                return;

            string path = _files[index];

            _files.RemoveAt(index);
            lstFiles.Items.RemoveAt(index);

            Log("Удален файл: " + path);
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtOutputFolder.Text = fbd.SelectedPath;
                    Log("Выходная папка: " + fbd.SelectedPath);
                }
            }
        }

        private void btnRefreshEncoders_Click(object sender, EventArgs e)
        {
            RefreshEncoders();
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {

            if (_files.Count == 0)
            {
                MessageBox.Show("Добавь хотя бы один файл.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOutputFolder.Text))
            {
                MessageBox.Show("Укажи выходную папку.");
                return;
            }

            if (!Directory.Exists(txtOutputFolder.Text))
            {
                MessageBox.Show("Выходная папка не существует.");
                return;
            }

            if (!File.Exists(FfmpegPath))
            {
                MessageBox.Show("Не найден ffmpeg.exe в папке Tools.");
                return;
            }

            if (!File.Exists(FFprobePath))
            {
                MessageBox.Show("Не найден ffprobe.exe в папке Tools.");
                return;
            }

            FormatOption format = cmbFormat.SelectedItem as FormatOption;
            if (format == null)
            {
                MessageBox.Show("Выбери формат.");
                return;
            }

            ResolutionPreset preset = cmbResolution.SelectedItem as ResolutionPreset;
            if (preset == null)
            {
                MessageBox.Show("Выбери разрешение.");
                return;
            }

            EncoderOption encoder = cmbVideoEncoder.SelectedItem as EncoderOption;
            if (encoder == null)
            {
                MessageBox.Show("Выбери видеокодек.");
                return;
            }

            ToggleUi(false);

            progressBar.Minimum = 0;
            progressBar.Maximum = _files.Count;
            progressBar.Value = 0;

            txtLog.Clear();

            try
            {
                int i;
                for (i = 0; i < _files.Count; i++)
                {
                    string input = _files[i];

                    string output = Path.Combine(
                        txtOutputFolder.Text,
                        Path.GetFileNameWithoutExtension(input) + "." + format.Extension);

                    Log("Старт: " + input);

                    Tuple<int, int> size = await _ffprobeService.GetVideoSizeAsync(FFprobePath, input);
                    int sourceWidth = size.Item1;
                    int sourceHeight = size.Item2;

                    Log("Исходный размер: " + sourceWidth + "x" + sourceHeight);

                    string args = FFmpegArgumentBuilder.Build(
                        input,
                        output,
                        preset,
                        encoder,
                        format.Extension,
                        chkKeepAspect.Checked,
                        sourceWidth,
                        sourceHeight);

                    Log("Команда ffmpeg:");
                    Log(args);

                    int exitCode = await _ffmpegService.ConvertAsync(FfmpegPath, args, Log);

                    if (exitCode == 0)
                    {
                        Log("Готово: " + output);
                    }
                    else
                    {
                        Log("Ошибка конвертации: " + input + " (код " + exitCode + ")");
                    }

                    progressBar.Value = i + 1;
                    Log("------------------------------------------------------------");
                }

                MessageBox.Show("Конвертация завершена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                Log("Исключение: " + ex);
            }
            finally
            {
                ToggleUi(true);
            }
        }

        private void ToggleUi(bool enabled)
        {
            btnAddFiles.Enabled = enabled;
            btnRemoveSelected.Enabled = enabled;
            btnBrowseOutput.Enabled = enabled;
            btnRefreshEncoders.Enabled = enabled;
            btnConvert.Enabled = enabled;

            cmbFormat.Enabled = enabled;
            cmbResolution.Enabled = enabled;
            cmbVideoEncoder.Enabled = enabled;
            chkKeepAspect.Enabled = enabled;
        }

        private void Log(string text)
        {
            if (txtLog.InvokeRequired)
            {
                txtLog.BeginInvoke(new Action<string>(Log), text);
                return;
            }

            txtLog.AppendText(text + Environment.NewLine);
        }
    }
}
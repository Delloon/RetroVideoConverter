using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace RetroVideoConverter.Services
{
    public class FFmpegService
    {
        public Task<int> ConvertAsync(
            string ffmpegPath,
            string arguments,
            Action<string> onLog)
        {
            if (!File.Exists(ffmpegPath))
                throw new FileNotFoundException("ffmpeg.exe not found", ffmpegPath);

            return Task.Run(() =>
            {
                var psi = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = arguments,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process())
                {
                    process.StartInfo = psi;

                    process.OutputDataReceived += (s, e) =>
                    {
                        if (!string.IsNullOrWhiteSpace(e.Data))
                            onLog(e.Data);
                    };

                    process.ErrorDataReceived += (s, e) =>
                    {
                        if (!string.IsNullOrWhiteSpace(e.Data))
                            onLog(e.Data);
                    };

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    process.WaitForExit();

                    return process.ExitCode;
                }
            });
        }
    }
}
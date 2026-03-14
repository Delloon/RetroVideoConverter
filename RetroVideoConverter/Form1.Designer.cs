namespace RetroVideoConverter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPreview = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveSelected = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddFiles = new Guna.UI2.WinForms.Guna2Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkKeepAspect = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cmbVideoEncoder = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbResolution = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbFormat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtOutputFolder = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnConvert = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefreshEncoders = new Guna.UI2.WinForms.Guna2Button();
            this.btnBrowseOutput = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.MessageInfo = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MessageError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MessageWarn = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MessageQuestion = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPreview);
            this.groupBox1.Controls.Add(this.btnRemoveSelected);
            this.groupBox1.Controls.Add(this.btnAddFiles);
            this.groupBox1.Controls.Add(this.lstFiles);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1127, 649);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файлы";
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Animated = true;
            this.btnPreview.BorderRadius = 6;
            this.btnPreview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPreview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPreview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPreview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPreview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(522, 264);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(165, 45);
            this.btnPreview.TabIndex = 13;
            this.btnPreview.Text = "Просмотр";
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSelected.Animated = true;
            this.btnRemoveSelected.BorderRadius = 6;
            this.btnRemoveSelected.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveSelected.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveSelected.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveSelected.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveSelected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRemoveSelected.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveSelected.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSelected.Location = new System.Drawing.Point(27, 315);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(180, 45);
            this.btnRemoveSelected.TabIndex = 12;
            this.btnRemoveSelected.Text = "Удалить файл";
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFiles.Animated = true;
            this.btnAddFiles.BorderRadius = 6;
            this.btnAddFiles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFiles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFiles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFiles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddFiles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.btnAddFiles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddFiles.ForeColor = System.Drawing.Color.White;
            this.btnAddFiles.Location = new System.Drawing.Point(27, 264);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(180, 45);
            this.btnAddFiles.TabIndex = 11;
            this.btnAddFiles.Text = "Добавить файлы";
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 16;
            this.lstFiles.Location = new System.Drawing.Point(27, 28);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(660, 228);
            this.lstFiles.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkKeepAspect);
            this.groupBox2.Controls.Add(this.cmbVideoEncoder);
            this.groupBox2.Controls.Add(this.cmbResolution);
            this.groupBox2.Controls.Add(this.cmbFormat);
            this.groupBox2.Controls.Add(this.txtOutputFolder);
            this.groupBox2.Controls.Add(this.btnConvert);
            this.groupBox2.Controls.Add(this.btnRefreshEncoders);
            this.groupBox2.Controls.Add(this.btnBrowseOutput);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(742, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 649);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки";
            // 
            // chkKeepAspect
            // 
            this.chkKeepAspect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkKeepAspect.AutoSize = true;
            this.chkKeepAspect.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.chkKeepAspect.CheckedState.BorderRadius = 0;
            this.chkKeepAspect.CheckedState.BorderThickness = 0;
            this.chkKeepAspect.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.chkKeepAspect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.chkKeepAspect.ForeColor = System.Drawing.Color.Black;
            this.chkKeepAspect.Location = new System.Drawing.Point(9, 315);
            this.chkKeepAspect.Name = "chkKeepAspect";
            this.chkKeepAspect.Size = new System.Drawing.Size(173, 20);
            this.chkKeepAspect.TabIndex = 21;
            this.chkKeepAspect.Text = "Сохранить пропроции";
            this.chkKeepAspect.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(166)))), ((int)(((byte)(198)))));
            this.chkKeepAspect.UncheckedState.BorderRadius = 0;
            this.chkKeepAspect.UncheckedState.BorderThickness = 0;
            this.chkKeepAspect.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(166)))), ((int)(((byte)(198)))));
            // 
            // cmbVideoEncoder
            // 
            this.cmbVideoEncoder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVideoEncoder.BackColor = System.Drawing.Color.Transparent;
            this.cmbVideoEncoder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVideoEncoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoEncoder.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbVideoEncoder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbVideoEncoder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbVideoEncoder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbVideoEncoder.ItemHeight = 30;
            this.cmbVideoEncoder.Location = new System.Drawing.Point(6, 264);
            this.cmbVideoEncoder.Name = "cmbVideoEncoder";
            this.cmbVideoEncoder.Size = new System.Drawing.Size(251, 36);
            this.cmbVideoEncoder.TabIndex = 20;
            // 
            // cmbResolution
            // 
            this.cmbResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbResolution.BackColor = System.Drawing.Color.Transparent;
            this.cmbResolution.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResolution.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbResolution.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbResolution.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbResolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbResolution.ItemHeight = 30;
            this.cmbResolution.Location = new System.Drawing.Point(6, 195);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(251, 36);
            this.cmbResolution.TabIndex = 19;
            // 
            // cmbFormat
            // 
            this.cmbFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFormat.BackColor = System.Drawing.Color.Transparent;
            this.cmbFormat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFormat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFormat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFormat.ItemHeight = 30;
            this.cmbFormat.Location = new System.Drawing.Point(6, 124);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(251, 36);
            this.cmbFormat.TabIndex = 18;
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputFolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutputFolder.DefaultText = "";
            this.txtOutputFolder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOutputFolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOutputFolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutputFolder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutputFolder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOutputFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOutputFolder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOutputFolder.Location = new System.Drawing.Point(9, 43);
            this.txtOutputFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.PlaceholderText = "";
            this.txtOutputFolder.SelectedText = "";
            this.txtOutputFolder.Size = new System.Drawing.Size(251, 41);
            this.txtOutputFolder.TabIndex = 17;
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Animated = true;
            this.btnConvert.BorderRadius = 6;
            this.btnConvert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConvert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConvert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConvert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConvert.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Location = new System.Drawing.Point(228, 354);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(165, 45);
            this.btnConvert.TabIndex = 14;
            this.btnConvert.Text = "Конвентировать";
            // 
            // btnRefreshEncoders
            // 
            this.btnRefreshEncoders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshEncoders.Animated = true;
            this.btnRefreshEncoders.BorderRadius = 6;
            this.btnRefreshEncoders.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshEncoders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshEncoders.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefreshEncoders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefreshEncoders.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.btnRefreshEncoders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshEncoders.ForeColor = System.Drawing.Color.White;
            this.btnRefreshEncoders.Location = new System.Drawing.Point(264, 266);
            this.btnRefreshEncoders.Name = "btnRefreshEncoders";
            this.btnRefreshEncoders.Size = new System.Drawing.Size(123, 32);
            this.btnRefreshEncoders.TabIndex = 16;
            this.btnRefreshEncoders.Text = "Обновить";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOutput.Animated = true;
            this.btnBrowseOutput.BorderRadius = 6;
            this.btnBrowseOutput.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseOutput.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseOutput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowseOutput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowseOutput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.btnBrowseOutput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseOutput.ForeColor = System.Drawing.Color.White;
            this.btnBrowseOutput.Location = new System.Drawing.Point(266, 47);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(100, 32);
            this.btnBrowseOutput.TabIndex = 14;
            this.btnBrowseOutput.Text = "Обзор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Видеокодек: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Разрешение:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Формат: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Выходная папка: ";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(3, 236);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(253)))));
            this.progressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
            this.progressBar.Size = new System.Drawing.Size(716, 30);
            this.progressBar.TabIndex = 22;
            this.progressBar.Text = "progressBar";
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar);
            this.groupBox3.Controls.Add(this.txtLog);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(20, 440);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(722, 269);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Логи";
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLog.Location = new System.Drawing.Point(3, 18);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(716, 212);
            this.txtLog.TabIndex = 8;
            // 
            // MessageInfo
            // 
            this.MessageInfo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageInfo.Caption = null;
            this.MessageInfo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.MessageInfo.Parent = this;
            this.MessageInfo.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MessageInfo.Text = null;
            // 
            // MessageError
            // 
            this.MessageError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageError.Caption = null;
            this.MessageError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.MessageError.Parent = this;
            this.MessageError.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MessageError.Text = null;
            // 
            // MessageWarn
            // 
            this.MessageWarn.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageWarn.Caption = null;
            this.MessageWarn.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.MessageWarn.Parent = this;
            this.MessageWarn.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MessageWarn.Text = null;
            // 
            // MessageQuestion
            // 
            this.MessageQuestion.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageQuestion.Caption = null;
            this.MessageQuestion.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.MessageQuestion.Parent = this;
            this.MessageQuestion.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MessageQuestion.Text = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 729);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Retro Video Converter";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnAddFiles;
        private System.Windows.Forms.ListBox lstFiles;
        private Guna.UI2.WinForms.Guna2Button btnPreview;
        private Guna.UI2.WinForms.Guna2Button btnRemoveSelected;
        private Guna.UI2.WinForms.Guna2TextBox txtOutputFolder;
        private Guna.UI2.WinForms.Guna2Button btnConvert;
        private Guna.UI2.WinForms.Guna2Button btnRefreshEncoders;
        private Guna.UI2.WinForms.Guna2Button btnBrowseOutput;
        private Guna.UI2.WinForms.Guna2ComboBox cmbResolution;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFormat;
        private Guna.UI2.WinForms.Guna2ComboBox cmbVideoEncoder;
        private Guna.UI2.WinForms.Guna2CheckBox chkKeepAspect;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageInfo;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageError;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageWarn;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageQuestion;
    }
}


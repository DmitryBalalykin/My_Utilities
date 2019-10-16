namespace MyUtilities
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Конвертер = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_cliar = new System.Windows.Forms.Button();
            this.tpNumer = new System.Windows.Forms.TabPage();
            this.cbNumer = new System.Windows.Forms.CheckBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClearGenerate = new System.Windows.Forms.Button();
            this.tbRandom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_2 = new System.Windows.Forms.NumericUpDown();
            this.nud_1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_numer = new System.Windows.Forms.Label();
            this.btn_generator = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPasword = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.Label();
            this.lblLenghtPasword = new System.Windows.Forms.Label();
            this.nudPassLenght = new System.Windows.Forms.NumericUpDown();
            this.clbPassword = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.блокнотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearPassword = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.cbMetric = new System.Windows.Forms.ComboBox();
            this.Конвертер.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpNumer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLenght)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Конвертер
            // 
            this.Конвертер.Controls.Add(this.tabPage1);
            this.Конвертер.Controls.Add(this.tpNumer);
            this.Конвертер.Controls.Add(this.tabPage3);
            this.Конвертер.Controls.Add(this.tabPage4);
            this.Конвертер.Controls.Add(this.tabPage2);
            this.Конвертер.Location = new System.Drawing.Point(12, 53);
            this.Конвертер.Name = "Конвертер";
            this.Конвертер.SelectedIndex = 0;
            this.Конвертер.Size = new System.Drawing.Size(526, 327);
            this.Конвертер.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button_cliar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(518, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Счётчик";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(182, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(160, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(160, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button_cliar
            // 
            this.button_cliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cliar.Location = new System.Drawing.Point(15, 108);
            this.button_cliar.Name = "button_cliar";
            this.button_cliar.Size = new System.Drawing.Size(106, 47);
            this.button_cliar.TabIndex = 0;
            this.button_cliar.Text = "Сброс";
            this.button_cliar.UseVisualStyleBackColor = true;
            this.button_cliar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tpNumer
            // 
            this.tpNumer.Controls.Add(this.cbNumer);
            this.tpNumer.Controls.Add(this.btnCopy);
            this.tpNumer.Controls.Add(this.btnClearGenerate);
            this.tpNumer.Controls.Add(this.tbRandom);
            this.tpNumer.Controls.Add(this.label3);
            this.tpNumer.Controls.Add(this.label2);
            this.tpNumer.Controls.Add(this.nud_2);
            this.tpNumer.Controls.Add(this.nud_1);
            this.tpNumer.Controls.Add(this.lbl_numer);
            this.tpNumer.Controls.Add(this.btn_generator);
            this.tpNumer.Location = new System.Drawing.Point(4, 22);
            this.tpNumer.Name = "tpNumer";
            this.tpNumer.Padding = new System.Windows.Forms.Padding(3);
            this.tpNumer.Size = new System.Drawing.Size(518, 301);
            this.tpNumer.TabIndex = 1;
            this.tpNumer.Text = "Генератор";
            this.tpNumer.UseVisualStyleBackColor = true;
            // 
            // cbNumer
            // 
            this.cbNumer.AutoSize = true;
            this.cbNumer.Checked = true;
            this.cbNumer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNumer.Location = new System.Drawing.Point(317, 21);
            this.cbNumer.Name = "cbNumer";
            this.cbNumer.Size = new System.Drawing.Size(165, 17);
            this.cbNumer.TabIndex = 11;
            this.cbNumer.Text = "Добавлять без повторений";
            this.cbNumer.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(413, 221);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(83, 59);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "Скопировать в буфер обмена";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // btnClearGenerate
            // 
            this.btnClearGenerate.Location = new System.Drawing.Point(317, 221);
            this.btnClearGenerate.Name = "btnClearGenerate";
            this.btnClearGenerate.Size = new System.Drawing.Size(90, 59);
            this.btnClearGenerate.TabIndex = 9;
            this.btnClearGenerate.Text = "Очистить";
            this.btnClearGenerate.UseVisualStyleBackColor = true;
            this.btnClearGenerate.Click += new System.EventHandler(this.BtnClearGenerate_Click);
            // 
            // tbRandom
            // 
            this.tbRandom.Location = new System.Drawing.Point(317, 56);
            this.tbRandom.Multiline = true;
            this.tbRandom.Name = "tbRandom";
            this.tbRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRandom.Size = new System.Drawing.Size(179, 150);
            this.tbRandom.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Максимальное число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Минимальное число";
            // 
            // nud_2
            // 
            this.nud_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_2.Location = new System.Drawing.Point(176, 56);
            this.nud_2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_2.Name = "nud_2";
            this.nud_2.Size = new System.Drawing.Size(41, 31);
            this.nud_2.TabIndex = 5;
            this.nud_2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nud_1
            // 
            this.nud_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_1.Location = new System.Drawing.Point(176, 11);
            this.nud_1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_1.Name = "nud_1";
            this.nud_1.Size = new System.Drawing.Size(41, 31);
            this.nud_1.TabIndex = 4;
            this.nud_1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_numer
            // 
            this.lbl_numer.AutoSize = true;
            this.lbl_numer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_numer.Location = new System.Drawing.Point(235, 33);
            this.lbl_numer.Name = "lbl_numer";
            this.lbl_numer.Size = new System.Drawing.Size(29, 31);
            this.lbl_numer.TabIndex = 1;
            this.lbl_numer.Text = "0";
            // 
            // btn_generator
            // 
            this.btn_generator.Location = new System.Drawing.Point(50, 104);
            this.btn_generator.Name = "btn_generator";
            this.btn_generator.Size = new System.Drawing.Size(99, 65);
            this.btn_generator.TabIndex = 0;
            this.btn_generator.Text = "Сгенерировать случайное число";
            this.btn_generator.UseVisualStyleBackColor = true;
            this.btn_generator.Click += new System.EventHandler(this.Btn_generator_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbMetric);
            this.tabPage3.Controls.Add(this.btnSwap);
            this.tabPage3.Controls.Add(this.tbTo);
            this.tabPage3.Controls.Add(this.tbFrom);
            this.tabPage3.Controls.Add(this.btnConvert);
            this.tabPage3.Controls.Add(this.cbTo);
            this.tabPage3.Controls.Add(this.cbFrom);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(518, 301);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Конвертер";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rtb);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(518, 301);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Блокнот";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rtb
            // 
            this.rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb.Location = new System.Drawing.Point(3, 3);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(512, 295);
            this.rtb.TabIndex = 0;
            this.rtb.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnClearPassword);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnPasword);
            this.tabPage2.Controls.Add(this.Password);
            this.tabPage2.Controls.Add(this.lblLenghtPasword);
            this.tabPage2.Controls.Add(this.nudPassLenght);
            this.tabPage2.Controls.Add(this.clbPassword);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(518, 301);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Сгенерировать пароль";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ваш пароль:";
            // 
            // btnPasword
            // 
            this.btnPasword.Location = new System.Drawing.Point(18, 200);
            this.btnPasword.Name = "btnPasword";
            this.btnPasword.Size = new System.Drawing.Size(136, 37);
            this.btnPasword.TabIndex = 4;
            this.btnPasword.Text = "Сгенерировать пароль";
            this.btnPasword.UseVisualStyleBackColor = true;
            this.btnPasword.Click += new System.EventHandler(this.BtnPasword_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(180, 157);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(51, 25);
            this.Password.TabIndex = 3;
            this.Password.Text = "non";
            // 
            // lblLenghtPasword
            // 
            this.lblLenghtPasword.AutoSize = true;
            this.lblLenghtPasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLenghtPasword.Location = new System.Drawing.Point(275, 42);
            this.lblLenghtPasword.Name = "lblLenghtPasword";
            this.lblLenghtPasword.Size = new System.Drawing.Size(113, 16);
            this.lblLenghtPasword.TabIndex = 2;
            this.lblLenghtPasword.Text = "Длинна пароля: ";
            // 
            // nudPassLenght
            // 
            this.nudPassLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudPassLenght.Location = new System.Drawing.Point(394, 37);
            this.nudPassLenght.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPassLenght.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudPassLenght.Name = "nudPassLenght";
            this.nudPassLenght.Size = new System.Drawing.Size(49, 26);
            this.nudPassLenght.TabIndex = 1;
            this.nudPassLenght.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // clbPassword
            // 
            this.clbPassword.CheckOnClick = true;
            this.clbPassword.FormattingEnabled = true;
            this.clbPassword.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. символы: \'%\', \'*\', \'~\', \'#\', \'?\', \'№\', \'$\', \'&\'"});
            this.clbPassword.Location = new System.Drawing.Point(14, 19);
            this.clbPassword.Name = "clbPassword";
            this.clbPassword.Size = new System.Drawing.Size(241, 64);
            this.clbPassword.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(104, 26);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1,
            this.помощьToolStripMenuItem,
            this.блокнотToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(108, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.TsmiExit);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(149, 22);
            this.tsmiAbout.Text = "О программе";
            this.tsmiAbout.Click += new System.EventHandler(this.TsmiAbout_Click);
            // 
            // блокнотToolStripMenuItem
            // 
            this.блокнотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmData,
            this.tsmTime,
            this.toolStripMenuItem1,
            this.tsmiSave,
            this.tsmiLoad});
            this.блокнотToolStripMenuItem.Name = "блокнотToolStripMenuItem";
            this.блокнотToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.блокнотToolStripMenuItem.Text = "Блокнот";
            // 
            // tsmData
            // 
            this.tsmData.Name = "tsmData";
            this.tsmData.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmData.Size = new System.Drawing.Size(232, 22);
            this.tsmData.Text = "Вставить дату";
            this.tsmData.Click += new System.EventHandler(this.TsmData_Click);
            // 
            // tsmTime
            // 
            this.tsmTime.Name = "tsmTime";
            this.tsmTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmTime.Size = new System.Drawing.Size(232, 22);
            this.tsmTime.Text = "Вставить время";
            this.tsmTime.Click += new System.EventHandler(this.TsmTime_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(232, 22);
            this.tsmiSave.Text = "Сохранить ";
            this.tsmiSave.Click += new System.EventHandler(this.TsmiSave_Click);
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.Size = new System.Drawing.Size(232, 22);
            this.tsmiLoad.Text = "Открыть";
            this.tsmiLoad.Click += new System.EventHandler(this.TsmiLoad_Click);
            // 
            // btnClearPassword
            // 
            this.btnClearPassword.Location = new System.Drawing.Point(160, 200);
            this.btnClearPassword.Name = "btnClearPassword";
            this.btnClearPassword.Size = new System.Drawing.Size(136, 37);
            this.btnClearPassword.TabIndex = 6;
            this.btnClearPassword.Text = "Очистить";
            this.btnClearPassword.UseVisualStyleBackColor = true;
            this.btnClearPassword.Click += new System.EventHandler(this.BtnClearPassword_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Скопировать в буфер обмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "мм",
            "см",
            "дм",
            "м",
            "км",
            "миля"});
            this.cbFrom.Location = new System.Drawing.Point(80, 114);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(93, 21);
            this.cbFrom.TabIndex = 0;
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "мм",
            "см",
            "дм",
            "м",
            "км",
            "миля"});
            this.cbTo.Location = new System.Drawing.Point(326, 114);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(85, 21);
            this.cbTo.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(180, 114);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(140, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Конвертировать";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(52, 160);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(121, 20);
            this.tbFrom.TabIndex = 3;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(326, 157);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(121, 20);
            this.tbTo.TabIndex = 4;
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(180, 157);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(140, 23);
            this.btnSwap.TabIndex = 5;
            this.btnSwap.Text = "Обменять местами";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.BtnSwap_Click);
            // 
            // cbMetric
            // 
            this.cbMetric.FormattingEnabled = true;
            this.cbMetric.Items.AddRange(new object[] {
            "длина",
            "вес"});
            this.cbMetric.Location = new System.Drawing.Point(198, 69);
            this.cbMetric.Name = "cbMetric";
            this.cbMetric.Size = new System.Drawing.Size(101, 21);
            this.cbMetric.TabIndex = 6;
            this.cbMetric.Text = "длина";
            this.cbMetric.SelectedIndexChanged += new System.EventHandler(this.CbMetric_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 401);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Конвертер);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Мои утилиты";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Конвертер.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tpNumer.ResumeLayout(false);
            this.tpNumer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLenght)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl Конвертер;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_cliar;
        private System.Windows.Forms.TabPage tpNumer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.Label lbl_numer;
        private System.Windows.Forms.Button btn_generator;
        private System.Windows.Forms.NumericUpDown nud_2;
        private System.Windows.Forms.NumericUpDown nud_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRandom;
        private System.Windows.Forms.Button btnClearGenerate;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.CheckBox cbNumer;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.ToolStripMenuItem блокнотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmData;
        private System.Windows.Forms.ToolStripMenuItem tsmTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoad;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckedListBox clbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPasword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label lblLenghtPasword;
        private System.Windows.Forms.NumericUpDown nudPassLenght;
        private System.Windows.Forms.Button btnClearPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.ComboBox cbMetric;
    }
}


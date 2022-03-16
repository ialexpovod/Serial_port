
namespace Serial_port
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxRTS = new System.Windows.Forms.CheckBox();
            this.cBoxDTR = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxParity = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxBaundRate = new System.Windows.Forms.ComboBox();
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnSendData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serial_port1 = new System.IO.Ports.SerialPort(this.components);
            this.lStatusConnect = new System.Windows.Forms.Label();
            this.labNumLength = new System.Windows.Forms.Label();
            this.labLengthData = new System.Windows.Forms.Label();
            this.tBoxReciver = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_AppendorOverwrite = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox_WriteLineOverwriteText = new System.Windows.Forms.ToolStripComboBox();
            this.saveToMySQL = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.получениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.очиститьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.позицияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBoxDisplay = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lvalLengthOUTdata = new System.Windows.Forms.Label();
            this.lLengthOUTdata = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gBoxDisplay.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxRTS);
            this.groupBox1.Controls.Add(this.cBoxDTR);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxParity);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.cBoxBaundRate);
            this.groupBox1.Controls.Add(this.cBoxComPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Контрольная панель";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cBoxRTS
            // 
            this.cBoxRTS.AutoSize = true;
            this.cBoxRTS.Location = new System.Drawing.Point(15, 178);
            this.cBoxRTS.Name = "cBoxRTS";
            this.cBoxRTS.Size = new System.Drawing.Size(48, 17);
            this.cBoxRTS.TabIndex = 11;
            this.cBoxRTS.Text = "RTS";
            this.cBoxRTS.UseVisualStyleBackColor = true;
            this.cBoxRTS.CheckedChanged += new System.EventHandler(this.cBoxRTS_CheckedChanged);
            // 
            // cBoxDTR
            // 
            this.cBoxDTR.AutoSize = true;
            this.cBoxDTR.Location = new System.Drawing.Point(15, 155);
            this.cBoxDTR.Name = "cBoxDTR";
            this.cBoxDTR.Size = new System.Drawing.Size(49, 17);
            this.cBoxDTR.TabIndex = 10;
            this.cBoxDTR.Text = "DTR";
            this.cBoxDTR.UseVisualStyleBackColor = true;
            this.cBoxDTR.CheckedChanged += new System.EventHandler(this.cBoxDTR_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Стоповые биты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Четность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Биты данных";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Скорость (бит/с)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cBoxStopBits.Location = new System.Drawing.Point(133, 129);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(120, 21);
            this.cBoxStopBits.TabIndex = 4;
            this.cBoxStopBits.Text = "1";
            // 
            // cBoxParity
            // 
            this.cBoxParity.FormattingEnabled = true;
            this.cBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParity.Location = new System.Drawing.Point(133, 102);
            this.cBoxParity.Name = "cBoxParity";
            this.cBoxParity.Size = new System.Drawing.Size(120, 21);
            this.cBoxParity.TabIndex = 3;
            this.cBoxParity.Text = "None";
            this.cBoxParity.SelectedIndexChanged += new System.EventHandler(this.cBoxParity_SelectedIndexChanged);
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(133, 75);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(120, 21);
            this.cBoxDataBits.TabIndex = 2;
            this.cBoxDataBits.Text = "8";
            // 
            // cBoxBaundRate
            // 
            this.cBoxBaundRate.FormattingEnabled = true;
            this.cBoxBaundRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cBoxBaundRate.Location = new System.Drawing.Point(133, 48);
            this.cBoxBaundRate.Name = "cBoxBaundRate";
            this.cBoxBaundRate.Size = new System.Drawing.Size(120, 21);
            this.cBoxBaundRate.TabIndex = 1;
            this.cBoxBaundRate.Text = "9600";
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.Location = new System.Drawing.Point(133, 21);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(120, 21);
            this.cBoxComPort.TabIndex = 0;
            this.cBoxComPort.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 16);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(138, 15);
            this.progressBar.TabIndex = 3;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendData.Location = new System.Drawing.Point(259, 0);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(78, 21);
            this.btnSendData.TabIndex = 4;
            this.btnSendData.Text = "Отправить";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // serial_port1
            // 
            this.serial_port1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial_port1_DataReceived);
            // 
            // lStatusConnect
            // 
            this.lStatusConnect.AutoSize = true;
            this.lStatusConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStatusConnect.Location = new System.Drawing.Point(200, 16);
            this.lStatusConnect.Name = "lStatusConnect";
            this.lStatusConnect.Size = new System.Drawing.Size(38, 13);
            this.lStatusConnect.TabIndex = 0;
            this.lStatusConnect.Text = "Выкл";
            // 
            // labNumLength
            // 
            this.labNumLength.AutoSize = true;
            this.labNumLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labNumLength.Location = new System.Drawing.Point(137, 16);
            this.labNumLength.Name = "labNumLength";
            this.labNumLength.Size = new System.Drawing.Size(21, 13);
            this.labNumLength.TabIndex = 1;
            this.labNumLength.Text = "00";
            this.labNumLength.Click += new System.EventHandler(this.labNumLength_Click);
            // 
            // labLengthData
            // 
            this.labLengthData.AutoSize = true;
            this.labLengthData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labLengthData.Location = new System.Drawing.Point(6, 16);
            this.labLengthData.Name = "labLengthData";
            this.labLengthData.Size = new System.Drawing.Size(134, 13);
            this.labLengthData.TabIndex = 0;
            this.labLengthData.Text = "Размер входных данных:";
            this.labLengthData.Click += new System.EventHandler(this.labLengthData_Click);
            // 
            // tBoxReciver
            // 
            this.tBoxReciver.BackColor = System.Drawing.SystemColors.Window;
            this.tBoxReciver.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tBoxReciver.Location = new System.Drawing.Point(3, 42);
            this.tBoxReciver.Multiline = true;
            this.tBoxReciver.Name = "tBoxReciver";
            this.tBoxReciver.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxReciver.Size = new System.Drawing.Size(337, 157);
            this.tBoxReciver.TabIndex = 8;
            this.tBoxReciver.TextChanged += new System.EventHandler(this.tBoxReciver_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.cOMToolStripMenuItem,
            this.получениеToolStripMenuItem,
            this.получениеToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.saveToMySQL,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Checked = true;
            this.сохранитьToolStripMenuItem.CheckOnClick = true;
            this.сохранитьToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_AppendorOverwrite,
            this.toolStripComboBox_WriteLineOverwriteText});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить как txt";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripComboBox_AppendorOverwrite
            // 
            this.toolStripComboBox_AppendorOverwrite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_AppendorOverwrite.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_AppendorOverwrite.Items.AddRange(new object[] {
            "Append",
            "Overwrite"});
            this.toolStripComboBox_AppendorOverwrite.Name = "toolStripComboBox_AppendorOverwrite";
            this.toolStripComboBox_AppendorOverwrite.Size = new System.Drawing.Size(121, 21);
            this.toolStripComboBox_AppendorOverwrite.DropDownClosed += new System.EventHandler(this.toolStripComboBox_AppendorOverwrite_DropDownClosed);
            // 
            // toolStripComboBox_WriteLineOverwriteText
            // 
            this.toolStripComboBox_WriteLineOverwriteText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_WriteLineOverwriteText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_WriteLineOverwriteText.Items.AddRange(new object[] {
            "Write Line",
            "Write"});
            this.toolStripComboBox_WriteLineOverwriteText.Name = "toolStripComboBox_WriteLineOverwriteText";
            this.toolStripComboBox_WriteLineOverwriteText.Size = new System.Drawing.Size(121, 21);
            // 
            // saveToMySQL
            // 
            this.saveToMySQL.Checked = true;
            this.saveToMySQL.CheckOnClick = true;
            this.saveToMySQL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveToMySQL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem});
            this.saveToMySQL.Name = "saveToMySQL";
            this.saveToMySQL.Size = new System.Drawing.Size(180, 22);
            this.saveToMySQL.Text = "Save to MySQL";
            this.saveToMySQL.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // cOMToolStripMenuItem
            // 
            this.cOMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.cOMToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cOMToolStripMenuItem.Name = "cOMToolStripMenuItem";
            this.cOMToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.cOMToolStripMenuItem.Text = "COM";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // получениеToolStripMenuItem
            // 
            this.получениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отправитьToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.строкаToolStripMenuItem});
            this.получениеToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.получениеToolStripMenuItem.Name = "получениеToolStripMenuItem";
            this.получениеToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.получениеToolStripMenuItem.Text = "Запись";
            this.получениеToolStripMenuItem.Click += new System.EventHandler(this.получениеToolStripMenuItem_Click);
            // 
            // отправитьToolStripMenuItem
            // 
            this.отправитьToolStripMenuItem.Name = "отправитьToolStripMenuItem";
            this.отправитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отправитьToolStripMenuItem.Text = "Отправить";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // строкаToolStripMenuItem
            // 
            this.строкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.строкаToolStripMenuItem.Name = "строкаToolStripMenuItem";
            this.строкаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.строкаToolStripMenuItem.Text = "Строка";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "Нет",
            "Две",
            "Новая строка",
            "Возврат каретки"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 21);
            this.toolStripComboBox2.DropDownClosed += new System.EventHandler(this.toolStripComboBox2_DropDownClosed);
            // 
            // получениеToolStripMenuItem1
            // 
            this.получениеToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеToolStripMenuItem,
            this.очиститьToolStripMenuItem1,
            this.позицияToolStripMenuItem});
            this.получениеToolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.получениеToolStripMenuItem1.Name = "получениеToolStripMenuItem1";
            this.получениеToolStripMenuItem1.Size = new System.Drawing.Size(83, 20);
            this.получениеToolStripMenuItem1.Text = "Получение";
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.данныеToolStripMenuItem.Text = "Данные";
            this.данныеToolStripMenuItem.Click += new System.EventHandler(this.данныеToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Update",
            "Add to old Dist"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 21);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // очиститьToolStripMenuItem1
            // 
            this.очиститьToolStripMenuItem1.Name = "очиститьToolStripMenuItem1";
            this.очиститьToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.очиститьToolStripMenuItem1.Text = "Очистить";
            this.очиститьToolStripMenuItem1.Click += new System.EventHandler(this.очиститьToolStripMenuItem1_Click);
            // 
            // позицияToolStripMenuItem
            // 
            this.позицияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox3});
            this.позицияToolStripMenuItem.Name = "позицияToolStripMenuItem";
            this.позицияToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.позицияToolStripMenuItem.Text = "Вывод";
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox3.Items.AddRange(new object[] {
            "В начале",
            "В конце"});
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 21);
            this.toolStripComboBox3.Click += new System.EventHandler(this.toolStripComboBox3_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // gBoxDisplay
            // 
            this.gBoxDisplay.Controls.Add(this.panel1);
            this.gBoxDisplay.Controls.Add(this.tBoxReciver);
            this.gBoxDisplay.Location = new System.Drawing.Point(300, 3);
            this.gBoxDisplay.Name = "gBoxDisplay";
            this.gBoxDisplay.Size = new System.Drawing.Size(343, 202);
            this.gBoxDisplay.TabIndex = 11;
            this.gBoxDisplay.TabStop = false;
            this.gBoxDisplay.Text = "Дисплей";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnSendData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 21);
            this.panel1.TabIndex = 13;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lvalLengthOUTdata);
            this.groupBox6.Controls.Add(this.labLengthData);
            this.groupBox6.Controls.Add(this.lLengthOUTdata);
            this.groupBox6.Controls.Add(this.labNumLength);
            this.groupBox6.Location = new System.Drawing.Point(300, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(343, 37);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            // 
            // lvalLengthOUTdata
            // 
            this.lvalLengthOUTdata.AutoSize = true;
            this.lvalLengthOUTdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvalLengthOUTdata.Location = new System.Drawing.Point(302, 16);
            this.lvalLengthOUTdata.Name = "lvalLengthOUTdata";
            this.lvalLengthOUTdata.Size = new System.Drawing.Size(21, 13);
            this.lvalLengthOUTdata.TabIndex = 1;
            this.lvalLengthOUTdata.Text = "00";
            this.lvalLengthOUTdata.Click += new System.EventHandler(this.lvalLengthOUTdata_Click);
            // 
            // lLengthOUTdata
            // 
            this.lLengthOUTdata.AutoSize = true;
            this.lLengthOUTdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLengthOUTdata.Location = new System.Drawing.Point(164, 16);
            this.lLengthOUTdata.Name = "lLengthOUTdata";
            this.lLengthOUTdata.Size = new System.Drawing.Size(142, 13);
            this.lLengthOUTdata.TabIndex = 0;
            this.lLengthOUTdata.Text = "Размер выходных данных:";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ButtonPanel);
            this.MainPanel.Controls.Add(this.groupBox1);
            this.MainPanel.Controls.Add(this.gBoxDisplay);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(650, 255);
            this.MainPanel.TabIndex = 12;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.groupBox2);
            this.ButtonPanel.Controls.Add(this.groupBox6);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 211);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(650, 44);
            this.ButtonPanel.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lStatusConnect);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 37);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Соединение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cтатус:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 279);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(966, 606);
            this.MinimumSize = new System.Drawing.Size(654, 247);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# COM SERIAL PORT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBoxDisplay.ResumeLayout(false);
            this.gBoxDisplay.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxComPort;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxParity;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxBaundRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serial_port1;
        private System.Windows.Forms.CheckBox cBoxRTS;
        private System.Windows.Forms.CheckBox cBoxDTR;
        private System.Windows.Forms.Label lStatusConnect;
        private System.Windows.Forms.Label labLengthData;
        private System.Windows.Forms.Label labNumLength;
        private System.Windows.Forms.TextBox tBoxReciver;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem строкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получениеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem отправитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.GroupBox gBoxDisplay;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lvalLengthOUTdata;
        private System.Windows.Forms.Label lLengthOUTdata;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem позицияToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_AppendorOverwrite;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_WriteLineOverwriteText;
        private System.Windows.Forms.ToolStripMenuItem saveToMySQL;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
    }
}


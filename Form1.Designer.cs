
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnSendData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serial_port1 = new System.IO.Ports.SerialPort(this.components);
            this.gBoxStatus = new System.Windows.Forms.GroupBox();
            this.lStatusConnect = new System.Windows.Forms.Label();
            this.gBoxTransmitter = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labNumLength = new System.Windows.Forms.Label();
            this.labLengthData = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxWrite = new System.Windows.Forms.CheckBox();
            this.cBoxWriteLine = new System.Windows.Forms.CheckBox();
            this.cBoxUsingEnter = new System.Windows.Forms.CheckBox();
            this.cBoxUsingButton = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.gBoxConnect = new System.Windows.Forms.GroupBox();
            this.gBoxButEnt = new System.Windows.Forms.GroupBox();
            this.gBoxWrite = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tBoxReciver = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cBoxUpdate = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gBoxStatus.SuspendLayout();
            this.gBoxTransmitter.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gBoxConnect.SuspendLayout();
            this.gBoxButEnt.SuspendLayout();
            this.gBoxWrite.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM PORT";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(6, 65);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 123);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(253, 23);
            this.progressBar.TabIndex = 3;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(6, 19);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(84, 26);
            this.btnSendData.TabIndex = 4;
            this.btnSendData.Text = "Отправить";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 129);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // serial_port1
            // 
            this.serial_port1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial_port1_DataReceived);
            // 
            // gBoxStatus
            // 
            this.gBoxStatus.Controls.Add(this.lStatusConnect);
            this.gBoxStatus.Location = new System.Drawing.Point(139, 19);
            this.gBoxStatus.Name = "gBoxStatus";
            this.gBoxStatus.Size = new System.Drawing.Size(120, 86);
            this.gBoxStatus.TabIndex = 6;
            this.gBoxStatus.TabStop = false;
            this.gBoxStatus.Text = "Статус соединения";
            // 
            // lStatusConnect
            // 
            this.lStatusConnect.AutoSize = true;
            this.lStatusConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStatusConnect.Location = new System.Drawing.Point(35, 33);
            this.lStatusConnect.Name = "lStatusConnect";
            this.lStatusConnect.Size = new System.Drawing.Size(58, 24);
            this.lStatusConnect.TabIndex = 0;
            this.lStatusConnect.Text = "Выкл";
            // 
            // gBoxTransmitter
            // 
            this.gBoxTransmitter.Controls.Add(this.groupBox3);
            this.gBoxTransmitter.Controls.Add(this.groupBox2);
            this.gBoxTransmitter.Controls.Add(this.textBox1);
            this.gBoxTransmitter.Location = new System.Drawing.Point(286, 28);
            this.gBoxTransmitter.Name = "gBoxTransmitter";
            this.gBoxTransmitter.Size = new System.Drawing.Size(280, 313);
            this.gBoxTransmitter.TabIndex = 7;
            this.gBoxTransmitter.TabStop = false;
            this.gBoxTransmitter.Text = "Запись";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labNumLength);
            this.groupBox3.Controls.Add(this.labLengthData);
            this.groupBox3.Location = new System.Drawing.Point(12, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 44);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // labNumLength
            // 
            this.labNumLength.AutoSize = true;
            this.labNumLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labNumLength.Location = new System.Drawing.Point(178, 16);
            this.labNumLength.Name = "labNumLength";
            this.labNumLength.Size = new System.Drawing.Size(29, 20);
            this.labNumLength.TabIndex = 1;
            this.labNumLength.Text = "00";
            // 
            // labLengthData
            // 
            this.labLengthData.AutoSize = true;
            this.labLengthData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labLengthData.Location = new System.Drawing.Point(41, 16);
            this.labLengthData.Name = "labLengthData";
            this.labLengthData.Size = new System.Drawing.Size(196, 20);
            this.labLengthData.TabIndex = 0;
            this.labLengthData.Text = "Размер входных данных:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gBoxWrite);
            this.groupBox2.Controls.Add(this.gBoxButEnt);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnSendData);
            this.groupBox2.Location = new System.Drawing.Point(6, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 82);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // cBoxWrite
            // 
            this.cBoxWrite.AutoSize = true;
            this.cBoxWrite.Location = new System.Drawing.Point(6, 36);
            this.cBoxWrite.Name = "cBoxWrite";
            this.cBoxWrite.Size = new System.Drawing.Size(51, 17);
            this.cBoxWrite.TabIndex = 9;
            this.cBoxWrite.Text = "Write";
            this.cBoxWrite.UseVisualStyleBackColor = true;
            this.cBoxWrite.CheckedChanged += new System.EventHandler(this.cBoxWrite_CheckedChanged);
            // 
            // cBoxWriteLine
            // 
            this.cBoxWriteLine.AutoSize = true;
            this.cBoxWriteLine.Location = new System.Drawing.Point(6, 10);
            this.cBoxWriteLine.Name = "cBoxWriteLine";
            this.cBoxWriteLine.Size = new System.Drawing.Size(74, 17);
            this.cBoxWriteLine.TabIndex = 8;
            this.cBoxWriteLine.Text = "Write Line";
            this.cBoxWriteLine.UseVisualStyleBackColor = true;
            this.cBoxWriteLine.CheckedChanged += new System.EventHandler(this.cBoxWriteLine_CheckedChanged);
            // 
            // cBoxUsingEnter
            // 
            this.cBoxUsingEnter.AutoSize = true;
            this.cBoxUsingEnter.Location = new System.Drawing.Point(6, 36);
            this.cBoxUsingEnter.Name = "cBoxUsingEnter";
            this.cBoxUsingEnter.Size = new System.Drawing.Size(51, 17);
            this.cBoxUsingEnter.TabIndex = 7;
            this.cBoxUsingEnter.Text = "Enter";
            this.cBoxUsingEnter.UseVisualStyleBackColor = true;
            this.cBoxUsingEnter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cBoxUsingEnter_KeyDown_1);
            // 
            // cBoxUsingButton
            // 
            this.cBoxUsingButton.AutoSize = true;
            this.cBoxUsingButton.Location = new System.Drawing.Point(6, 10);
            this.cBoxUsingButton.Name = "cBoxUsingButton";
            this.cBoxUsingButton.Size = new System.Drawing.Size(57, 17);
            this.cBoxUsingButton.TabIndex = 6;
            this.cBoxUsingButton.Text = "Button";
            this.cBoxUsingButton.UseVisualStyleBackColor = true;
            this.cBoxUsingButton.CheckedChanged += new System.EventHandler(this.cBoxUsingButton_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 51);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gBoxConnect
            // 
            this.gBoxConnect.Controls.Add(this.button1);
            this.gBoxConnect.Controls.Add(this.btnClose);
            this.gBoxConnect.Controls.Add(this.gBoxStatus);
            this.gBoxConnect.Controls.Add(this.progressBar);
            this.gBoxConnect.Location = new System.Drawing.Point(12, 236);
            this.gBoxConnect.Name = "gBoxConnect";
            this.gBoxConnect.Size = new System.Drawing.Size(268, 157);
            this.gBoxConnect.TabIndex = 8;
            this.gBoxConnect.TabStop = false;
            // 
            // gBoxButEnt
            // 
            this.gBoxButEnt.Controls.Add(this.cBoxUsingButton);
            this.gBoxButEnt.Controls.Add(this.cBoxUsingEnter);
            this.gBoxButEnt.Location = new System.Drawing.Point(98, 15);
            this.gBoxButEnt.Name = "gBoxButEnt";
            this.gBoxButEnt.Size = new System.Drawing.Size(72, 59);
            this.gBoxButEnt.TabIndex = 10;
            this.gBoxButEnt.TabStop = false;
            // 
            // gBoxWrite
            // 
            this.gBoxWrite.Controls.Add(this.cBoxWriteLine);
            this.gBoxWrite.Controls.Add(this.cBoxWrite);
            this.gBoxWrite.Location = new System.Drawing.Point(176, 15);
            this.gBoxWrite.Name = "gBoxWrite";
            this.gBoxWrite.Size = new System.Drawing.Size(81, 59);
            this.gBoxWrite.TabIndex = 11;
            this.gBoxWrite.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.tBoxReciver);
            this.groupBox4.Location = new System.Drawing.Point(577, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 313);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Чтение";
            // 
            // tBoxReciver
            // 
            this.tBoxReciver.BackColor = System.Drawing.SystemColors.Window;
            this.tBoxReciver.Location = new System.Drawing.Point(6, 21);
            this.tBoxReciver.Multiline = true;
            this.tBoxReciver.Name = "tBoxReciver";
            this.tBoxReciver.Size = new System.Drawing.Size(263, 129);
            this.tBoxReciver.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Location = new System.Drawing.Point(6, 156);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(263, 82);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cBoxUpdate);
            this.groupBox7.Controls.Add(this.checkBox4);
            this.groupBox7.Location = new System.Drawing.Point(125, 15);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(107, 59);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            // 
            // cBoxUpdate
            // 
            this.cBoxUpdate.AutoSize = true;
            this.cBoxUpdate.Location = new System.Drawing.Point(6, 10);
            this.cBoxUpdate.Name = "cBoxUpdate";
            this.cBoxUpdate.Size = new System.Drawing.Size(61, 17);
            this.cBoxUpdate.TabIndex = 6;
            this.cBoxUpdate.Text = "Update";
            this.cBoxUpdate.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 36);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(95, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Add to old Dist";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(12, 244);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(250, 44);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(178, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(41, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Размер данных:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 407);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gBoxConnect);
            this.Controls.Add(this.gBoxTransmitter);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "C# COM SERIAL PORT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBoxStatus.ResumeLayout(false);
            this.gBoxStatus.PerformLayout();
            this.gBoxTransmitter.ResumeLayout(false);
            this.gBoxTransmitter.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gBoxConnect.ResumeLayout(false);
            this.gBoxButEnt.ResumeLayout(false);
            this.gBoxButEnt.PerformLayout();
            this.gBoxWrite.ResumeLayout(false);
            this.gBoxWrite.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serial_port1;
        private System.Windows.Forms.CheckBox cBoxRTS;
        private System.Windows.Forms.CheckBox cBoxDTR;
        private System.Windows.Forms.GroupBox gBoxStatus;
        private System.Windows.Forms.Label lStatusConnect;
        private System.Windows.Forms.GroupBox gBoxTransmitter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gBoxConnect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cBoxWrite;
        private System.Windows.Forms.CheckBox cBoxWriteLine;
        private System.Windows.Forms.CheckBox cBoxUsingEnter;
        private System.Windows.Forms.CheckBox cBoxUsingButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labLengthData;
        private System.Windows.Forms.Label labNumLength;
        private System.Windows.Forms.GroupBox gBoxWrite;
        private System.Windows.Forms.GroupBox gBoxButEnt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tBoxReciver;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox cBoxUpdate;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}


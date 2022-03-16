using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
// Connect MySQL reference
using MySql.Data.MySqlClient;




namespace Serial_port
{
    public partial class Form1 : Form
    {
        string dataOUT;
        string SendWrite;
        string dataIN;

        // Сохранение в txt
        // Создать класс StreamWriter и заданной для него какой-то объект.
        StreamWriter objStreamWriter;
        // задекларировать переменную строкового типа данных для пути сохранения данных в файл.
        // Для статического сохранения данных в текстовый файл
        // string path_file = @"C:\Users\Efimenko_AD\source\repos\Serial_port\_Sorce_File_data\save_data.txt";
        // Динамическое сохранение в текстовый файл
        string path_file;

        bool statement_append_text = true;

        MySqlConnection MyNewMySQLconnection;
        MySqlCommand MyNewMySQLcommand;


        #region Anon_Method 

        private void SaveDataToTxtFile()
        {
            if (сохранитьToolStripMenuItem.Checked)
            {
                try
                {
                    objStreamWriter = new StreamWriter(path_file, statement_append_text);
                    if (toolStripComboBox_WriteLineOverwriteText.Text == "Write Line")
                    {
                        objStreamWriter.WriteLine(dataIN);
                    }
                    else if (toolStripComboBox_WriteLineOverwriteText.Text == "Write")
                    {
                        objStreamWriter.Write(dataIN + ";"); // or " ", "\n"
                    }

                    objStreamWriter.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            
        }

        // MySQL
        private void SaveDataToMySQL()
        {
            if (saveToMySQL.Checked)
            {
                try
                {
                    // Connect with database MySQL
                    MyNewMySQLconnection = new MySqlConnection( "server=localhost; " +
                                                                "username=root; " +
                                                                "password=; " +
                                                                "port=3306;" +
                                                                "database=database_serial_port");
                    MyNewMySQLconnection.Open();

                    // Command for insert. `MyTABLE`, 'MyVALUES'.
                    MyNewMySQLcommand = new MySqlCommand(string.Format("INSERT INTO `table_serial_port` VALUES('{0}')", dataIN), MyNewMySQLconnection);
                    MyNewMySQLcommand.ExecuteNonQuery();

                    MyNewMySQLconnection.Close();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            }
        }


        #endregion

        #region GUI method
        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("ru-RU");
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.AddRange(ports);

            cBoxDTR.Checked = false;
            serial_port1.DtrEnable = false;
            cBoxRTS.Checked = false;
            serial_port1.RtsEnable = false;
            // Формат записи
            SendWrite = "Две";
            toolStripComboBox3.Text = "В начале";

            toolStripComboBox1.Text = "Add to old Dist";
            toolStripComboBox2.Text = "Две";

            // Append
            // Overwrite
            toolStripComboBox_AppendorOverwrite.Text = "Append";

            // Write Line
            // Write
            toolStripComboBox_WriteLineOverwriteText.Text = "Write Line";

            // Текущая директория проекта
            path_file = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            // Добавить в переменную папку и название файла
            path_file = path_file + @"\_Sorce_File_data\dynamic_path_for_save_data.txt";
            // Вывести результат в консоли
            Console.WriteLine("===== Result =====");
            Console.WriteLine(path_file);
            // C:\Users\Efimenko_AD\source\repos\Serial_port\_Sorce_File_data\

            // Save to .txt Checked
            сохранитьToolStripMenuItem.Checked = false;
            // MySQL Save Checked
            saveToMySQL.Checked = false;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                serial_port1.PortName = cBoxComPort.Text;
                serial_port1.BaudRate = Convert.ToInt32(cBoxBaundRate.Text);
                serial_port1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serial_port1.Parity = (Parity)Enum.Parse((typeof(Parity)), cBoxParity.Text);
                serial_port1.StopBits = (StopBits)Enum.Parse((typeof(StopBits)), cBoxStopBits.Text);


                serial_port1.Open();
                progressBar.Value = 100;
                lStatusConnect.Text = "Вкл";

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lStatusConnect.Text = "Выкл";
            }
        }


        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serial_port1.IsOpen)
            {
                serial_port1.Close();
                progressBar.Value = 0;
                lStatusConnect.Text = "Выкл";

            }
        }

        private void cBoxParity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serial_port1.IsOpen)
            {
                dataOUT = textBox1.Text;
                if (SendWrite == "Нет")
                {
                    serial_port1.Write(dataOUT);
                }

                else if (SendWrite == "Две")
                {
                    serial_port1.Write(dataOUT + "\r\n");
                }
                else if (SendWrite == "Новая строка")
                {
                    serial_port1.Write(dataOUT + "\n");
                }
                else if (SendWrite == "Возврат каретки")
                {
                    serial_port1.Write(dataOUT + "\r");
                }
            }

        }
        private void toolStripComboBox2_DropDownClosed(object sender, EventArgs e)
        {
            // Нет
            // Две
            // Новая строка
            // Возврат каретки
            if (toolStripComboBox2.Text == "Нет")
            {
                SendWrite = "Нет";
            }
            else if (toolStripComboBox2.Text == "Две")
            {
                SendWrite = "Две";
            }
            else if (toolStripComboBox2.Text == "Новая строка")
            {
                SendWrite = "Новая строка";
            }
            else if (toolStripComboBox2.Text == "Возврат каретки")
            {
                SendWrite = "Возврат каретки";
            }
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void cBoxDTR_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxDTR.Checked)
            {
                serial_port1.DtrEnable = true;
                MessageBox.Show("DTR Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                serial_port1.DtrEnable = false;
            }
        }

        private void cBoxRTS_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxRTS.Checked)
            {
                serial_port1.RtsEnable = true;
                MessageBox.Show("DTR Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                serial_port1.RtsEnable = false;
            }
        }
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = "";
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int dataOUTLength = textBox1.TextLength;
            labNumLength.Text = string.Format("{0:0}", dataOUTLength);
            /*if (cBoxUsingEnter.Checked)
            {
                textBox1.Text = textBox1.Text.Replace(Environment.NewLine, "");
            }*/
        }
        /*
        private void cBoxUsingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxUsingButton.Checked)
            {
                btnSendData.Enabled = true;

            }
            else { btnSendData.Enabled = false; }
        }
        */

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.doSomeThing();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }

        private void doSomeThing()
        {
            if (serial_port1.IsOpen)
            {
                dataOUT = textBox1.Text;
                if (SendWrite == "Нет")
                {
                    serial_port1.Write(dataOUT);
                }

                else if (SendWrite == "Две")
                {
                    serial_port1.Write(dataOUT + "\r\n");
                }
                else if (SendWrite == "Новая строка")
                {
                    serial_port1.Write(dataOUT + "\n");
                }
                else if (SendWrite == "Возврат каретки")
                {
                    serial_port1.Write(dataOUT + "\r");
                }
            }
        }

        private void serial_port1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serial_port1.ReadExisting();
            this.Invoke(new EventHandler(Showdata));
        }

        private void Showdata(object sender, EventArgs e)
        {
            int dataInLength = tBoxReciver.TextLength;
            lvalLengthOUTdata.Text = string.Format("{0:0}", dataInLength);
            if (toolStripComboBox1.Text == "Update")
            {
                tBoxReciver.Text = dataIN;
            }
            else if (toolStripComboBox1.Text == "Add to old Dist")
            {
                if(toolStripComboBox3.Text == "В начале")
                {
                    // Зеркальный (обратный) вывод
                    tBoxReciver.Text = tBoxReciver.Text.Insert(0, dataIN);
                }
                else if (toolStripComboBox3.Text == "В конце")
                {
                    tBoxReciver.Text += dataIN;
                }
 
            }
            SaveDataToTxtFile();
            SaveDataToMySQL();

        }


        private void labNumLength_Click(object sender, EventArgs e)
        {

        }

        private void очиститьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tBoxReciver.Text != "")
            {
                tBoxReciver.Text = "";
            }
        }
        private void btnClearOutData_Click(object sender, EventArgs e)
        {

        }

        private void lvalLengthOUTdata_Click(object sender, EventArgs e)
        {

        }

        private void tBoxReciver_TextChanged(object sender, EventArgs e)
        {

        }

        private void нетToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void получениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void labLengthData_Click(object sender, EventArgs e)
        {

        }

        private void данныеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create by Alex Povod", "Creator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripComboBox3_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            gBoxDisplay.Width = MainPanel.Width - 303;
            gBoxDisplay.Height = MainPanel.Height - 46;

            tBoxReciver.Height = MainPanel.Height - 89;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox_AppendorOverwrite_DropDownClosed(object sender, EventArgs e)
        {
            if(toolStripComboBox_AppendorOverwrite.Text == "Append")
            {
                statement_append_text = true;
            }
            else
            {
                statement_append_text = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 objForm2 = new Form2();
            objForm2.Show();



        }
        #endregion

    }

}


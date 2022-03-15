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


namespace Serial_port
{
    public partial class Form1 : Form
    {   
        string dataOUT;
        string SendWrite;
        string dataIN;
        public Form1()
        {
           System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("ru-RU");
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.AddRange(ports);

            button1.Enabled = true;
            btnClose.Enabled = false;




            cBoxDTR.Checked = false;
            serial_port1.DtrEnable = false;
            
            
            cBoxRTS.Checked = false;
            serial_port1.RtsEnable = false;
            // Формат записи
            cBoxWrite.Checked = true;
            cBoxWriteLine.Checked = false;
            SendWrite = "Write";

            cBoxUpdate.Checked = false;
            cBoxAddtoOldDist.Checked = true;
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

      
        private void button1_Click(object sender, EventArgs e)
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
                button1.Enabled = false;
                btnClose.Enabled = true;
                lStatusConnect.Text = "Вкл";

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Enabled = true;
                btnClose.Enabled = false;
                lStatusConnect.Text = "Выкл";
            }
            }
           


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(serial_port1.IsOpen)
            {
                serial_port1.Close();
                progressBar.Value = 0;
                button1.Enabled = true;
                btnClose.Enabled = false;
                lStatusConnect.Text = "Выкл";

            }
        }

        private void cBoxParity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if(serial_port1.IsOpen)
            {
                dataOUT = textBox1.Text;
                if(SendWrite == "Write Line")
                {
                    serial_port1.WriteLine(dataOUT);
                }

                else if (SendWrite == "Write")
                {
                    serial_port1.Write(dataOUT);
                }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(btnClear.Text != "")
            {
                textBox1.Text = "";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int dataOUTLength = textBox1.TextLength;
            labNumLength.Text = string.Format("{0:0}", dataOUTLength);
            if (cBoxUsingEnter.Checked)
            {
                textBox1.Text = textBox1.Text.Replace(Environment.NewLine, "");
            }
        }

        private void cBoxUsingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxUsingButton.Checked)
            {
                btnSendData.Enabled = true;

            }
            else { btnSendData.Enabled = false; }
        }

   
        private void cBoxWriteLine_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxWriteLine.Checked)
            {
                SendWrite = "Write Line";
                cBoxWrite.Checked = false;
                cBoxWriteLine.Checked = true;

            }
        }

        private void cBoxWrite_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxWrite.Checked)
            {
                SendWrite = "Write";
                cBoxWrite.Checked = true;
                cBoxWriteLine.Checked = false;
            }
        }

        private void cBoxUsingEnter_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (cBoxUsingEnter.Checked)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (serial_port1.IsOpen)
                        if (SendWrite == "Write Line")
                        {
                            serial_port1.WriteLine(dataOUT);
                        }

                        else if (SendWrite == "Write")
                        {
                            serial_port1.Write(dataOUT);
                        }

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
            if (cBoxUpdate.Checked)
            {
                tBoxReciver.Text = dataIN;
            }
            else if (cBoxAddtoOldDist.Checked)
                {
                tBoxReciver.Text += dataIN;
            }
        }


        private void labNumLength_Click(object sender, EventArgs e)
        {

        }

        private void cBoxUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxUpdate.Checked)
            {
                cBoxUpdate.Checked = true;
                cBoxAddtoOldDist.Checked = false;
            }
            else {
                cBoxAddtoOldDist.Checked = true;
            }
        }

        private void cBoxAddtoOldDist_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxAddtoOldDist.Checked)
            {
                cBoxUpdate.Checked = false;
                cBoxAddtoOldDist.Checked = true;
            }
            else
            {
                cBoxUpdate.Checked = true;
            }
        }

        private void btnClearOutData_Click(object sender, EventArgs e)
        {
            if(tBoxReciver.Text != "")
            {
                tBoxReciver.Text = "";
            }
        }

        private void lvalLengthOUTdata_Click(object sender, EventArgs e)
        {

        }

        private void tBoxReciver_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

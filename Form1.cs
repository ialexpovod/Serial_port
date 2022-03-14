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
        public Form1()
        {
            InitializeComponent();
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
                serial_port1.StopBits = (StopBits)Enum.Parse((typeof(StopBits)), cBoxStopBits.Text);
                serial_port1.Parity = (Parity)Enum.Parse((typeof(Parity)), cBoxParity.Text);
           

                serial_port1.Open();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
           

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.AddRange(ports);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

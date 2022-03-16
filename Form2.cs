using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Serial_port
{

    public partial class Form2 : Form
    {
        MySqlConnection MyNewMySQLconnection;
        MySqlCommand MyNewMySQLcommand;
        MySqlDataAdapter mySQLDataAdapter;
        DataSet mydataset;

        
        private void RefreshAndShowData()
        {
            try
            {
                // Connect with database MySQL
                MyNewMySQLconnection = new MySqlConnection("server=localhost; " +
                                                            "username=root; " +
                                                            "password=; " +
                                                            "port=3306;" +
                                                            "database=database_serial_port");
                MyNewMySQLconnection.Open();

                // Command for insert. `MyTABLE`
                MyNewMySQLcommand = new MySqlCommand("SELECT * FROM `table_serial_port`", MyNewMySQLconnection);
                mySQLDataAdapter = new MySqlDataAdapter(MyNewMySQLcommand);
                mydataset = new DataSet();

                mySQLDataAdapter.Fill(mydataset, "Serial Data");
                dGridVMySQL.DataSource = mydataset;
                dGridVMySQL.DataMember = "Serial Data";
                dGridVMySQL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dGridVMySQL.Refresh();


                MyNewMySQLconnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RefreshAndShowData();
        }
    }
}

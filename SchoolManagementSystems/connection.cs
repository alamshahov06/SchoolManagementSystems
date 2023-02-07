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
using System.IO;

namespace SchoolManagementSystems
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (dataSourceTxt.Text!="" && dbTxt.Text!="" && usernameTxt.Text!="" && pswdTxt.Text!="")
            {
                StringBuilder sb = new StringBuilder();
                //server=localhost;user id=root;database=sms;persistsecurityinfo=True;allowuservariables=True
                sb.Append("server=" + dataSourceTxt.Text + ";database=" + dbTxt.Text + ";user id=" + usernameTxt.Text + ";password=" + pswdTxt.Text);
                MainClass.conn = sb.ToString();
                try
                {
                    MySqlConnection mycon = new MySqlConnection();
                    mycon.ConnectionString = MainClass.conn;
                    mycon.Open();
                    MainClass.ShowMSG("Connected Succesfuly", "Success", "Success");
                    mycon.Close();
                    File.WriteAllText(MainClass.path + "\\connect", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings saved succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login_win log = new login_win();
                        MainClass.showWindow(log, this);
                    }
                }
                catch (MySqlException)
                {
                    MainClass.ShowMSG("Invalid Connection, Please try again", "Error", "Error");
                }
                catch (ArgumentException)
                {
                    MainClass.ShowMSG("Invalid Connection, Please try again", "Error", "Error");
                }
            }
        }
    }
}
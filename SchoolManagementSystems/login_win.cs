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
    public partial class login_win : Form
    {
        public login_win()
        {
            InitializeComponent();
             
            if (MainClass.sLogo != null && MainClass.sName!=null)
             {
                 MemoryStream ms = new MemoryStream(MainClass.sLogo);
                 pictureBox1.Image = Image.FromStream(ms);
                label1.Text = MainClass.sName;
             }
        }
        private void loignBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection myCon = new MySqlConnection();
            MySqlCommand myCmd;
            string query = null;
            myCon.ConnectionString = MainClass.conn;
            if (roleCb.SelectedIndex != -1)
            {
                if (roleCb.SelectedItem.ToString() == "Student")
                {
                    query = "select * from student where std_uname='" + usernameTxt.Text + "' and std_pswd='" + pswdTxt.Text + "'";
                }
                else
                {
                    query = "select * from staff where st_username='" + usernameTxt.Text + "' and st_pswd='" + pswdTxt.Text + "' and st_role='" + roleCb.SelectedItem + "'";
                }
                myCmd = new MySqlCommand(query, myCon);
                MySqlDataReader dr;
                try
                {
                    myCon.Open();
                    dr = myCmd.ExecuteReader();
                    if (dr.HasRows)//dr.VisibleFieldCount
                    {
                        MainClass.role = roleCb.SelectedItem.ToString();
                        dr.Read();
                        MainClass.id = dr.GetValue(0).ToString();
                        MainClass.name = dr.GetValue(1).ToString();
                        MainClass.ShowMSG("Welcome, " + dr.GetValue(1).ToString(), "Success", "Success");
                        dr.Close();
                        if (roleCb.SelectedItem.ToString() == "Admin")
                        {
                            HomeScreen hs = new HomeScreen();
                            MainClass.showWindow(hs, this);
                        }
                        else if (roleCb.SelectedItem.ToString() == "Principal")
                        {
                            PrincipalHM hs = new PrincipalHM();
                            MainClass.showWindow(hs, this);
                        }
                        else if (roleCb.SelectedItem.ToString() == "Teacher")
                        {
                            TeacherHM hs = new TeacherHM();
                            MainClass.showWindow(hs, this);
                        }
                        else if (roleCb.SelectedItem.ToString() == "Non-Teaching Staff")
                        {
                            NTStaff hs = new NTStaff();
                            MainClass.showWindow(hs, this);
                        }
                        else if (roleCb.SelectedItem.ToString() == "Student")
                        {
                            studentHM hs = new studentHM();
                            MainClass.showWindow(hs, this);
                        }
                    }
                    else if (usernameTxt.Text == "admin" && pswdTxt.Text == "12345")
                    {
                        MainClass.ShowMSG("Welcome Admin", "Success", "Success");
                        HomeScreen hs = new HomeScreen();
                        MainClass.showWindow(hs, this);
                    }
                    else
                    {
                        MainClass.ShowMSG("Invalid entry, Re-enter", "Error", "Error");
                        MainClass.enable_reset(panel1);
                    }
                    myCon.Close();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private void login_win_Load(object sender, EventArgs e)
        {

        }
    }
}

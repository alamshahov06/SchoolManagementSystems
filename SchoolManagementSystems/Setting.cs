using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace SchoolManagementSystems
{
    public partial class Setting : Sample2
    {
        public Setting()
        {
            InitializeComponent();
        }
        MySqlConnection myCon = new MySqlConnection();
        MySqlCommand myCmd;

        private void Setting_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Filter = "Choose Image(*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg";
            if (opn.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(opn.FileName);
                sLogoTxt.Text = opn.FileName.ToString();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveBttn_Click(object sender, EventArgs e)
        {
            if (sLogoTxt.Text != "" & sNameTxt.Text != "" & sAddressTxt.Text != "")
            {
                myCon.ConnectionString = MainClass.conn;
                try
                {
                    myCon.Open();
                    FileStream fs;
                    Byte[] bindata;
                    MySqlParameter picpara;
                    myCmd = new MySqlCommand("update sms.school_info set school_logo= ?school_logo, school_name='" + sNameTxt.Text + "', school_address='" + sAddressTxt.Text + "' where school_id=1", myCon);
                    picpara = myCmd.Parameters.Add("?school_logo", MySqlDbType.MediumBlob);
                    myCmd.Prepare();
                    //txtPicPath is the path of the image, e.g. C:\MyPic.png
                    fs = new FileStream(sLogoTxt.Text, FileMode.Open, FileAccess.Read);
                    bindata = new byte[Convert.ToInt32(fs.Length)];
                    fs.Read(bindata, 0, Convert.ToInt32(fs.Length));
                    fs.Close();
                    picpara.Value = bindata;
                    if (myCmd.ExecuteNonQuery() == 1)
                    {
                        MainClass.ShowMSG("Data Inserted", "Success", "Success");
                    }
                    myCon.Close();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                LoadData();
            }
            else
            {
                MainClass.ShowMSG("Input all the Feilds...!", "Error", "Error");
            }
        }

        private void LoadData()
        {
            try
            {
                myCon.ConnectionString = MainClass.conn;
                MySqlCommand cmd;
                MySqlDataAdapter da;
                String qry = "SELECT * FROM sms.school_info where school_id='1'";
                cmd = new MySqlCommand(qry, myCon);
                da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                if (table.Rows[0][1].ToString() != "" && table.Rows[0][2].ToString() != "")
                {
                    sNameTxt.Text = table.Rows[0][1].ToString();
                    sAddressTxt.Text = table.Rows[0][2].ToString();
                    MainClass.sName = sNameTxt.Text.ToString();
                    byte[] img = (byte[])table.Rows[0][3];
                    MainClass.sLogo = img;
                    MemoryStream ms1 = new MemoryStream(img);
                    pictureBox.Image = Image.FromStream(ms1);
                }
                da.Dispose();
            }
            catch(ArgumentException exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
    }
}
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

namespace SchoolManagementSystems
{
    public partial class FeeReceipt : Sample2
    {
        public FeeReceipt()
        {
            InitializeComponent();
            initLbl();
        }
        MySqlConnection myCon = new MySqlConnection();
        MySqlCommand myCmd1,myCmd2;

        private void initLbl()
        {
            nameLbl.Text = MainClass.name;
            rollLbl.Text = MainClass.id;
            pdateLbl.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            myCon.ConnectionString = MainClass.conn;
            string query1 = "select std_std as 'Standard',std_div as 'Division'  from sms.student where std_id=" + MainClass.id + " ;";
            string query2 = "select * from sms.fees where fees_stdID=" + MainClass.id + " ;";
            myCmd1 = new MySqlCommand(query1, myCon);
            myCmd2 = new MySqlCommand(query2, myCon);
            MySqlDataReader dr;
            try
            {
                myCon.Open();
                dr = myCmd1.ExecuteReader();
                dr.Read();
                stdLbl.Text = dr.GetString("Standard");
                divLbl.Text = dr.GetString("Division");
                dr.Close();
                dr = myCmd2.ExecuteReader();
                dr.Read();
                pfeesLbl.Text = dr.GetString("fees_paid");
                rfeesLbl.Text = dr.GetString("fees_remain");
                tfeesLbl.Text = (Convert.ToInt32(pfeesLbl.Text.ToString()) + Convert.ToInt32(rfeesLbl.Text.ToString())).ToString() ;
                dr.Close();
                myCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nameLbl_Click(object sender, EventArgs e)
        {

        }

        private void stdLbl_Click(object sender, EventArgs e)
        {

        }

        private void divLbl_Click(object sender, EventArgs e)
        {

        }

        private void rollLbl_Click(object sender, EventArgs e)
        {

        }

        private void pfeesLbl_Click(object sender, EventArgs e)
        {

        }

        private void rfeesLbl_Click(object sender, EventArgs e)
        {

        }

        private void tfeesLbl_Click(object sender, EventArgs e)
        {

        }

        private void pdateLbl_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void paymentLbl_Click(object sender, EventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.detailGb.Width, this.detailGb.Height);
            detailGb.DrawToBitmap(bm, new Rectangle(0, 0, this.detailGb.Width, this.detailGb.Height));
            int h = bm.Height;
            e.Graphics.DrawImage(bm, 10, 20, 810, h - 50);
        }
    }
}

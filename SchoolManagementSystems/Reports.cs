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
    public partial class Reports : Sample2
    {
        public Reports()
        {
            InitializeComponent();
        }
        MySqlConnection myCon = new MySqlConnection();
        MySqlCommand myCmd1, myCmd2, myCmd3, myCmd4, myCmd5,myCmd;
        int subjct=1;
        private void initLbl()
        {
            int rollNo;
            double p = 0.0,p1=0.0;
            nameLbl.Text = MainClass.name;
            rollLbl.Text = MainClass.id;
            myCon.ConnectionString = MainClass.conn;
            string query1 = "select std_std as 'Standard',std_div as 'Division'  from sms.student where std_id=" + MainClass.id + " ;";
            string query3 = "select res_grade,res_percent,res_status from sms.result where res_stdID='" + MainClass.id + "' and res_sem="+(termCB.SelectedIndex+1)+" limit 1;";
            string query4 = null, query5 = null;
            if (termCB.SelectedIndex == 0)
            {
                query4 = "select res_eng,res_maths,res_sci,res_his,res_geo,res_total from sms.result where res_stdId=" + MainClass.id + " and res_term=1;";
                query5 = "select res_eng,res_maths,res_sci,res_his,res_geo,res_total from sms.result where res_stdId=" + MainClass.id + " and res_term=2;";
            }
            else if (termCB.SelectedIndex == 1)
            {
                query4 = "select res_eng,res_maths,res_sci,res_his,res_geo,res_total from sms.result where res_stdId=" + MainClass.id + " and res_term=3;";
                query5 = "select res_eng,res_maths,res_sci,res_his,res_geo,res_total from sms.result where res_stdId=" + MainClass.id + " and res_term=4;";
            }
            myCmd1 = new MySqlCommand(query1, myCon);
            myCmd3 = new MySqlCommand(query3, myCon);
            myCmd4 = new MySqlCommand(query4, myCon);
            myCmd5 = new MySqlCommand(query5, myCon);
            MySqlDataReader dr;
            try
            {
                myCon.Open();
                dr = myCmd1.ExecuteReader();
                dr.Read();
                stdLbl.Text = dr.GetString("Standard");
                divLbl.Text = dr.GetString("Division");
                dr.Close();
                string query = "select std_id,ROW_NUMBER() OVER(ORDER BY STD_ID) AS 'rollNo' from student where std_std='" + stdLbl.Text + "';";
                myCmd = new MySqlCommand(query, myCon);
                dr = myCmd.ExecuteReader();
                while (dr.Read())
                    if(dr.GetString("std_id")==MainClass.id)
                        rollLbl.Text = MainClass.id;
                dr.Close();
                string query2 = "select count(sub_id) as 'Subjects'  from sms.subjects where sub_class='" + stdLbl.Text + "' ;";
                myCmd2 = new MySqlCommand(query2, myCon);
                dr = myCmd2.ExecuteReader();
                dr.Read();
                subjct = Convert.ToInt32(dr.GetString("Subjects").ToString());
                dr.Close();
                dr = myCmd3.ExecuteReader();
                dr.Read();
                gradeLbl.Text = dr.GetString("res_grade");
                percentLbl.Text = dr.GetString("res_percent")+" %";
                statusLbl.Text = dr.GetString("res_status");
                dr.Close();
                dr = myCmd4.ExecuteReader();
                dr.Read();
                eng1Lbl.Text=dr.GetString("res_eng");
                maths1Lbl.Text = dr.GetString("res_maths");
                science1Lbl.Text = dr.GetString("res_sci");
                history1Lbl.Text = dr.GetString("res_his");
                geo1Lbl.Text = dr.GetString("res_geo");
                total1Lbl.Text = dr.GetString("res_total");
                p = (double)((Convert.ToDouble(dr.GetString("res_total"))) * 100 / (subjct * 20));
                percent1Lbl.Text = p.ToString() +" %";
                status1Lbl.Text = "Pass";
                if(((Convert.ToInt32(dr.GetString("res_total"))) * 100 / (subjct * 20)) >=80.0)
                {
                    grade1Lbl.Text = "A";
                }
                else if (((Convert.ToInt32(dr.GetString("res_total"))) * 100 / (subjct * 20)) >= 60.0)
                {
                    grade1Lbl.Text = "B";
                }
                else if (((Convert.ToInt32(dr.GetString("res_total"))) * 100 / (subjct * 20)) >= 40.0)
                {
                    grade1Lbl.Text = "C";
                }
                else if (((Convert.ToInt32(dr.GetString("res_total"))) * 100 / (subjct * 20)) >= 35.0)
                {
                    grade1Lbl.Text = "D";
                }
                else
                {
                    grade1Lbl.Text = "F";
                    status1Lbl.Text = "Fail";
                }
                dr.Close();
                dr = myCmd5.ExecuteReader();
                dr.Read();
                eng2Lbl.Text = dr.GetString("res_eng");
                maths2Lbl.Text = dr.GetString("res_maths");
                science2Lbl.Text = dr.GetString("res_sci");
                history2Lbl.Text = dr.GetString("res_his");
                geo2Lbl.Text = dr.GetString("res_geo");
                total2Lbl.Text = dr.GetString("res_total");
                p1 = (double)((Convert.ToDouble(dr.GetString("res_total"))) * 100 / (subjct * 80));
                percent2Lbl.Text = p1.ToString()+ " %";
                status2Lbl.Text = "Pass";
                if (((Convert.ToInt32(dr.GetString("res_total"))) * 100 / (subjct * 80)) >= 80.0)
                {
                    grade2Lbl.Text = "A";
                }
                else if (((Convert.ToInt32(dr.GetString("res_total"))) * 100 / (subjct * 80)) >= 60.0)
                {
                    grade2Lbl.Text = "B";
                }
                else if (((Convert.ToInt32(dr.GetString("res_total"))) * 100 / (subjct * 80)) >= 40.0)
                {
                    grade2Lbl.Text = "C";
                }
                else if (((Convert.ToInt32(dr.GetString("res_total"))) * 100 / (subjct * 80)) >= 35.0)
                {
                    grade2Lbl.Text = "D";
                }
                else
                {
                    grade2Lbl.Text = "F";
                    status2Lbl.Text = "Fail";
                }
                dr.Close();
                myCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
                TableLayoutRowStyleCollection styles = this.markTbl.RowStyles;
                if (subjct == 2)
                {
                RowStyle style1 = styles[3];
                style1.SizeType = SizeType.Absolute;
                style1.Height = 0;
                RowStyle style2 = styles[4];
                style2.SizeType = SizeType.Absolute;
                style2.Height = 0;
                RowStyle style3 = styles[5];
                style3.SizeType = SizeType.Absolute;
                style3.Height = 0;
                }
                else if (subjct == 4)
                {
                RowStyle style1 = styles[3];
                style1.SizeType = SizeType.Absolute;
                style1.Height = 0;
                }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nameLbl_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void overallPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (termCB.SelectedIndex != -1)
            {
                initLbl();
                detailGb.Visible = true;
            }
            else
                MainClass.ShowMSG("Please, select Semester ","Error","Error");
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
            e.Graphics.DrawImage(bm, 10, 20, 810, h - 100);
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}

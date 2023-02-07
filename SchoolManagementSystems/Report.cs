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
    public partial class Report : Sample2
    {
        public Report()
        {
            InitializeComponent();
            fillCombo();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        MySqlConnection myCon = new MySqlConnection();
        MySqlCommand myCmd;
        int subjectNo = 5;
        int size = 0;
        void fillCombo()
        {
            myCon.ConnectionString = MainClass.conn;
            string query = "select * from sms.class";
            myCmd = new MySqlCommand(query, myCon);
            MySqlDataReader dr;
            try
            {
                myCon.Open();
                dr = myCmd.ExecuteReader();
                while (dr.Read())
                {
                    string sName = dr.GetString("cls_name");
                    stdCB.Items.Add(sName);
                }
                myCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void loadSubject()
        {
            myCon.ConnectionString = MainClass.conn;
            string q = "select count(*) as 'Count' from subjects sub where sub.sub_class='" + stdCB.SelectedItem + "'";
            myCmd = new MySqlCommand(q, myCon);
            MySqlDataReader ds;
            try
            {
                myCon.Open();
                ds = myCmd.ExecuteReader();
                ds.Read();
                subjectNo = Convert.ToInt32(ds.GetString("Count"));
                ds.Close();
                myCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void loadData()
        {
            loadSubject();
            myCon.ConnectionString = MainClass.conn;
            string query;
            if (subjectNo == 2)
            {
                size = 12;
                query = "call st_getReport(" + (termCB.SelectedIndex + 1) + ",'" + stdCB.SelectedItem + "','" + sectionCB.SelectedItem + "'," + subjectNo + ");";
                MySqlDataAdapter ad = new MySqlDataAdapter(query, myCon);
                DataTable dtblbook = new DataTable();
                nameGv.DataPropertyName = "Student";
                engGV.DataPropertyName = "English";
                mathsGV.DataPropertyName = "Maths";
                totalGV.DataPropertyName = "Total";
                gradeGV.DataPropertyName = "Grade";
                percentGV.DataPropertyName = "Percent";
                statusGV.DataPropertyName = "Status";
                engGV.Visible = true;
                mathsGV.Visible = true;
                scienceGV.Visible = false;
                historyGV.Visible = false;
                geographyGV.Visible = false;
                ad.Fill(dtblbook);
                dataGridView1.DataSource = dtblbook;
            }
            else if (subjectNo == 4)
            {
                size = 10;
                query = "call st_getReport(" + (termCB.SelectedIndex + 1) + ",'" + stdCB.SelectedItem + "','" + sectionCB.SelectedItem + "'," + subjectNo + ");";
                MySqlDataAdapter ad = new MySqlDataAdapter(query, myCon);
                DataTable dtblbook = new DataTable();
                nameGv.DataPropertyName = "Student";
                engGV.DataPropertyName = "English";
                mathsGV.DataPropertyName = "Maths";
                scienceGV.DataPropertyName = "Science";
                historyGV.DataPropertyName = "History";
                geographyGV.DataPropertyName = "Geography";
                totalGV.DataPropertyName = "Total";
                gradeGV.DataPropertyName = "Grade";
                percentGV.DataPropertyName = "Percent";
                statusGV.DataPropertyName = "Status";
                engGV.Visible = true;
                mathsGV.Visible = true;
                scienceGV.Visible = false;
                historyGV.Visible = true;
                geographyGV.Visible = true;
                ad.Fill(dtblbook);
                dataGridView1.DataSource = dtblbook;
            }
            else
            {
                size = 9;
                query = "call st_getReport(" + (termCB.SelectedIndex+1) + ",'" + stdCB.SelectedItem + "','" + sectionCB.SelectedItem + "'," + subjectNo + ");";
                MySqlDataAdapter ad = new MySqlDataAdapter(query, myCon);
                DataTable dtblbook = new DataTable();
                nameGv.DataPropertyName = "Student";
                engGV.DataPropertyName = "English";
                mathsGV.DataPropertyName = "Maths";
                scienceGV.DataPropertyName = "Science";
                historyGV.DataPropertyName = "History";
                geographyGV.DataPropertyName = "Geography";
                totalGV.DataPropertyName = "Total";
                gradeGV.DataPropertyName = "Grade";
                percentGV.DataPropertyName = "Percent";
                statusGV.DataPropertyName = "Status";
                engGV.Visible = true;
                mathsGV.Visible = true;
                scienceGV.Visible = true;
                historyGV.Visible = true;
                geographyGV.Visible = true;
                ad.Fill(dtblbook);
                dataGridView1.DataSource = dtblbook;
            }
            MainClass.sno(dataGridView1, "SnoGV");
        }

        private void saveBttn_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width,this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm,new Rectangle(0,0,this.dataGridView1.Width,this.dataGridView1.Height));
            int h = bm.Height;
            e.Graphics.DrawImage(bm,10,15,810,h-100);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}

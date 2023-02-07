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
    public partial class Attendance : Sample2

    {
        public Attendance()
        {
            InitializeComponent();
            FillCombo();
            atdDP.Value = DateTime.Today;
        }
        MySqlConnection myCon = new MySqlConnection();
        MySqlCommand myCmd;
        void FillCombo()
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
                dr.Close();
                myCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void LoadData()
        {
            myCon.ConnectionString = MainClass.conn;
            string query;
            query = "call st_getAtd('"+atdDP.Value.Year+"-"+atdDP.Value.Month+"-"+atdDP.Value.Day+"','"+ stdCB.SelectedItem +"','"+sectionCB.SelectedItem+"');";
            MySqlDataAdapter ad = new MySqlDataAdapter(query, myCon);
            DataTable dtblbook = new DataTable();
            atdIDGV.DataPropertyName = "AttID";
            nameGv.DataPropertyName = "Student";
            stdIDGV.DataPropertyName = "StudentID";
            stdGv.DataPropertyName = "Class";
            clsIDGV.DataPropertyName = "ClassID";
            divGv.DataPropertyName = "Section";
            divIDGV.DataPropertyName = "SectionID";
            attendanceGV.DataPropertyName = "Status";
            dateGv.DataPropertyName = "Date";
            ad.Fill(dtblbook);
            dataGridView1.DataSource = dtblbook;
            MainClass.sno(dataGridView1, "SnoGV");
        }
        private void loadBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void saveBttn_Click(object sender, EventArgs e)
        {
            myCon.ConnectionString = MainClass.conn;
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string query;
                        myCon.Open();
                        query = "call st_insertAttd('" + atdDP.Text + "'," + Convert.ToInt32(row.Cells["stdIDGV"].Value.ToString()) + ",'" + row.Cells["attendanceGV"].Value.ToString() + "','" + row.Cells["stdGv"].Value.ToString() + "','" + row.Cells["divGv"].Value.ToString() + "');";
                        myCmd = new MySqlCommand(query, myCon);
                        myCmd.ExecuteReader();
                        myCon.Close();
                    }
                    MainClass.ShowMSG("Attendance updated succesfully", "Success", "Success");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                LoadData();
            }
        }
        private void attendance_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }
    }
}

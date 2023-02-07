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
    public partial class marks : Sample2
    {
        public marks()
        {
            InitializeComponent();
            fillCombo();
        }
        MySqlConnection myCon = new MySqlConnection();
        MySqlCommand myCmd;
        int subjectNo = 5;
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
            string q = "select count(*) as 'Count' from subjects sub where sub.sub_class='"+stdCB.SelectedItem+"'";
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
                query = "call st_getResult(" + termCB.SelectedIndex + ",'" + stdCB.SelectedItem + "','" + sectionCB.SelectedItem + "'," + subjectNo + ");";
                MySqlDataAdapter ad = new MySqlDataAdapter(query, myCon);
                DataTable dtblbook = new DataTable();
                resIDGV.DataPropertyName = "ResultID";
                stdIDGV.DataPropertyName = "StudentID";
                nameGv.DataPropertyName = "Student";
                stdGv.DataPropertyName = "Standard";
                divGv.DataPropertyName = "Section";
                engGV.DataPropertyName = "English";
                mathsGV.DataPropertyName = "Maths";
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
                query = "call st_getResult(" + termCB.SelectedIndex + ",'" + stdCB.SelectedItem + "','" + sectionCB.SelectedItem + "'," + subjectNo + ");";
                MySqlDataAdapter ad = new MySqlDataAdapter(query, myCon);
                DataTable dtblbook = new DataTable();
                resIDGV.DataPropertyName = "ResultID";
                stdIDGV.DataPropertyName = "StudentID";
                nameGv.DataPropertyName = "Student";
                stdGv.DataPropertyName = "Standard";
                divGv.DataPropertyName = "Section";
                engGV.DataPropertyName = "English";
                mathsGV.DataPropertyName = "Maths";
                scienceGV.DataPropertyName="Science";
                historyGV.DataPropertyName = "History";
                geographyGV.DataPropertyName = "Geography";
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
                query = "call st_getResult(" + termCB.SelectedIndex + ",'" + stdCB.SelectedItem + "','" + sectionCB.SelectedItem + "'," + subjectNo + ");";
                MySqlDataAdapter ad = new MySqlDataAdapter(query, myCon);
                DataTable dtblbook = new DataTable();
                resIDGV.DataPropertyName = "ResultID";
                stdIDGV.DataPropertyName = "StudentID";
                nameGv.DataPropertyName = "Student";
                stdGv.DataPropertyName = "Standard";
                divGv.DataPropertyName = "Section";
                engGV.DataPropertyName = "English";
                mathsGV.DataPropertyName = "Maths";
                scienceGV.DataPropertyName = "Science";
                historyGV.DataPropertyName = "History";
                geographyGV.DataPropertyName = "Geography";
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
        private void stdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSubject();
        }
        private void loadBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void saveBttn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                myCon.ConnectionString = MainClass.conn;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        myCon.Open();
                        string query;
                        {
                            if (subjectNo == 2)
                            {
                                query = "call st_updateResult(" + Convert.ToInt32(row.Cells["resIDGV"].Value.ToString()) + ","+ Convert.ToInt32(row.Cells["stdIDGV"].Value.ToString()) + "," + subjectNo + ",'"+termCB.SelectedItem.ToString()+"'," + Convert.ToInt32(row.Cells["engGV"].Value.ToString()) + "," + Convert.ToInt32(row.Cells["mathsGV"].Value.ToString()) + ",0,0,0);";
                            }
                            else if (subjectNo == 4)
                            {
                                query = "call st_updateResult(" + Convert.ToInt32(row.Cells["resIDGV"].Value.ToString()) + "," + Convert.ToInt32(row.Cells["stdIDGV"].Value.ToString()) + "," + subjectNo + ",'" + termCB.SelectedItem + "'," + Convert.ToInt32(row.Cells["engGV"].Value.ToString()) + "," + Convert.ToInt32(row.Cells["mathsGV"].Value.ToString()) + ",null," + Convert.ToInt32(row.Cells["historyGV"].Value.ToString()) + "," + Convert.ToInt32(row.Cells["geographyGV"].Value.ToString()) + ");";
                            }
                            else
                            {
                                query = "call st_updateResult(" + Convert.ToInt32(row.Cells["resIDGV"].Value.ToString()) + "," + Convert.ToInt32(row.Cells["stdIDGV"].Value.ToString()) + "," + subjectNo + ",'" + termCB.SelectedItem + "'," + Convert.ToInt32(row.Cells["engGV"].Value.ToString()) + "," + Convert.ToInt32(row.Cells["mathsGV"].Value.ToString()) + "," + Convert.ToInt32(row.Cells["scienceGV"].Value.ToString()) + "," + Convert.ToInt32(row.Cells["historyGV"].Value.ToString()) + "," + Convert.ToInt32(row.Cells["geographyGV"].Value.ToString()) + ");";
                            }
                            myCmd = new MySqlCommand(query, myCon);
                            myCmd.ExecuteReader();
                        }
                        myCon.Close();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                MainClass.ShowMSG("Result updated successfully", "Success", "Success");
                loadData();
            }
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                MainClass.ShowMSG("Invalid Marks entered", "Error", "Error");
            }
        }
        private void marks_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }
    }
}

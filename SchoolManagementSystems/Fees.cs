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
    public partial class Fees : Sample2
    {
        public Fees()
        {
            InitializeComponent();
            fillCombo();
        }
        MySqlConnection myCon = new MySqlConnection();
        MySqlCommand myCmd;
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
        private void loadData()
        {
            myCon.ConnectionString = MainClass.conn;
            string query;
            query = "call st_getFees('" + stdCB.SelectedItem + "','" + sectionCB.SelectedItem + "');";
            MySqlDataAdapter ad = new MySqlDataAdapter(query, myCon);
            DataTable dtblbook = new DataTable();
            feesIDGV.DataPropertyName = "FeesID";
            stdIDGV.DataPropertyName = "StudentID";
            nameGv.DataPropertyName = "Student";
            stdGv.DataPropertyName = "Standard";
            divGv.DataPropertyName = "Division";
            paidGV.DataPropertyName = "Paid";
            remainGV.DataPropertyName = "Remain";
            amountGV.DataPropertyName = "Amount";
            statusGV.DataPropertyName = "Status";
            myCon.ConnectionString = MainClass.conn;
            ad.Fill(dtblbook);
            dataGridView1.DataSource = dtblbook;
            MainClass.sno(dataGridView1,"SnoGV");
        }
        private void loadBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void button2_Click(object sender, EventArgs e)
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
                            query = "call st_updateFees(" + Convert.ToInt32(row.Cells["feesIDGV"].Value.ToString()) + ",'" + row.Cells["stdGv"].Value.ToString() + "'," + Convert.ToInt32(row.Cells["paidGV"].Value.ToString()) + ");";
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
                loadData();
                MainClass.ShowMSG("Fees updated successfully", "Success", "Success");
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            stdCB.SelectedItem = row.Cells["stdGv"].Value.ToString();
            sectionCB.SelectedItem = row.Cells["divGv"].Value.ToString();
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                MainClass.ShowMSG("Invalid Fee entered", "Error", "Error");
            }
        }
        private void Fees_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }
    }
}
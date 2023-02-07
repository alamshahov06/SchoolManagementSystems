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
    public partial class Sections : Sample2
    {
        public Sections()
        {
            InitializeComponent();
            fillCombo();
        }
        MySqlConnection myCon = new MySqlConnection();
        MySqlCommand myCmd;
        int secID = -1;
        int edit = -1;
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
                    classCB.Items.Add(sName);
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
            try
            {
                myCon.ConnectionString = MainClass.conn;
                MySqlDataAdapter da = new MySqlDataAdapter("st_getSections", myCon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblbook = new DataTable();
                sectionIDGV.DataPropertyName = "ID";
                sectionGV.DataPropertyName = "Name";
                classGV.DataPropertyName = "Class";
                da.Fill(dtblbook);
                dataGridView1.DataSource = dtblbook;
                MainClass.sno(dataGridView1, "SnoGV");
                MainClass.disable_reset(panel6);
            }
            catch(Exception ex)
            {
                MainClass.ShowMSG(ex.Message,"Error","Error");
            }
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.enable_reset(panel6);
        }
        public override void editBtn_Click(object sender, EventArgs e)
        {
            if (secID == 0)
            {
                MainClass.ShowMSG("Please, Select a record to edit", "Error", "Error");
                loadData();
            }
            edit = 1;
            MainClass.enable(panel6);
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (sectionTxt.Text == "") { sectionsErrorLbl.Visible = true; } else { sectionsErrorLbl.Visible = false; }
            if (classCB.SelectedIndex == -1) { classErrLbl.Visible = true; } else { classErrLbl.Visible = false; }
            if (sectionsErrorLbl.Visible || classErrLbl.Visible)
            {
                MainClass.ShowMSG("Fields with * are madantory", "Error", "Error");
            }
            else
            {
                myCon.ConnectionString = MainClass.conn;
                if (edit == 0)
                {
                    try
                    {
                        myCon.Open();
                        string query;
                        query = "call st_insertSections('" + sectionTxt.Text + "','"+ classCB.SelectedItem +"');";
                        myCmd = new MySqlCommand(query, myCon);
                        myCmd.ExecuteReader();
                        myCon.Close();
                        MainClass.ShowMSG(classCB.SelectedItem+"-"+sectionTxt.Text + " added succesfully", "Success", "Success");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (edit == 1)
                {
                    try
                    {
                        myCon.Open();
                        string query;
                        query = "call st_updateSections(" + secID + ",'" + sectionTxt.Text + "','"+ classCB.SelectedItem +"');";
                        myCmd = new MySqlCommand(query, myCon);
                        myCmd.ExecuteReader();
                        myCon.Close();
                        MainClass.ShowMSG(classCB.SelectedItem+"-"+sectionTxt.Text + " updated succesfully", "Success", "Success");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                loadData();
            }
        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (secID <= 1)
            {
                MainClass.ShowMSG("Please, Select a record to delete", "Error", "Error");
                loadData();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete "+classCB.SelectedItem+"-"+ sectionTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    myCon.ConnectionString = MainClass.conn;
                    try
                    {
                        myCon.Open();
                        string query;
                        query = "call st_deleteSections(" + secID + ");";
                        myCmd = new MySqlCommand(query, myCon);
                        myCmd.ExecuteReader();
                        myCon.Close();
                        MainClass.ShowMSG(classCB.SelectedItem+"-"+sectionTxt.Text + " deleted succesfully", "Success", "Success");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    loadData();
                }
            }
        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }
        public override void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search")
            {
                textBox1.Text = null;
                textBox1.ForeColor = Color.Black;
            }
        }
        public override void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = "Search";
            textBox1.ForeColor = Color.Silver;
        }
        public override void textBox1_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                MainClass.disable(panel6);
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                secID = Convert.ToInt32(row.Cells["sectionIDGV"].Value.ToString());
                sectionTxt.Text = row.Cells["sectionGV"].Value.ToString();
                classCB.SelectedItem = row.Cells["classGV"].Value.ToString();
            }
        }
        private void classCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classCB.SelectedIndex == -1) { classErrLbl.Visible = true; } else { classErrLbl.Visible = false; }
        }
        private void sectionTxt_TextChanged(object sender, EventArgs e)
        {
            if (sectionTxt.Text == "") { sectionsErrorLbl.Visible = true; } else { sectionsErrorLbl.Visible = false; }
        }
        private void sectionTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
                e.Handled = true;
        }
        private void Sections_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
        }
    }
}
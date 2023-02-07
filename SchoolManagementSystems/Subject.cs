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
    public partial class Subject : Sample2
    {
        public Subject()
        {
            InitializeComponent();
            fillCombo();
        }
        MySqlConnection myCon = new MySqlConnection();
        MySqlCommand myCmd;
        int edit = -1;
        int subID = -1;
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
                dr.Close();
                myCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void loadData()
        {
            if (classCB.SelectedIndex != -1)
            {
                myCon.ConnectionString = "server = localhost; user id = root; password = devil; database = sms";
                MySqlDataAdapter da = new MySqlDataAdapter("call st_getSubject('" + classCB.SelectedItem.ToString() + "');", myCon);
                da.SelectCommand.CommandType = CommandType.Text;
                DataTable dtblbook = new DataTable();
                subjectIDGV.DataPropertyName = "ID";
                subjectGv.DataPropertyName = "Name";
                classGV.DataPropertyName = "Class";
                da.Fill(dtblbook);
                dataGridView1.DataSource = dtblbook;
                MainClass.sno(dataGridView1, "SnoGV");
                subjectTxt.Text = "";
                subjectTxt.Enabled = false;
                subjecErrLbl.Visible = false;
            }
            else
                MainClass.ShowMSG("Please, select Standard","Error","Error");
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            subjectTxt.Text = "";
            subjectTxt.Enabled =true;
            subjecErrLbl.Visible = false;
        }
        public override void editBtn_Click(object sender, EventArgs e)
        {
            if (subID == 0)
            {
                MainClass.ShowMSG("Please, Select subject to edit", "Error", "Error");
                loadData();
            }
            edit = 1;
            subjectTxt.Enabled = true;
            subjecErrLbl.Visible = false;
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (subjecErrLbl.Visible)
            {
                MainClass.ShowMSG("Fields with * are madantory", "Error", "Error");
            }
            else
            {
                myCon.ConnectionString = "server = localhost; user id = root; password = devil; database = sms";
                if (edit == 0)
                {
                    try
                    {
                        myCon.Open();
                        string query;
                        query = "call st_insertSubject('" + subjectTxt.Text + "','" + classCB.SelectedItem + "');";
                        myCmd = new MySqlCommand(query, myCon);
                        myCmd.ExecuteReader();
                        myCon.Close();
                        MainClass.ShowMSG(subjectTxt.Text + " added succesfully", "Success", "Success");
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
                        query = "call st_updateSubject(" + subID + ",'" + subjectTxt.Text + "','" + classCB.SelectedItem + "');";
                        myCmd = new MySqlCommand(query, myCon);
                        myCmd.ExecuteReader();
                        myCon.Close();
                        MainClass.ShowMSG(subjectTxt.Text + " updated succesfully", "Success", "Success");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                loadData();
            }
        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (subID <= -1)
            {
                MainClass.ShowMSG("Please, Select subject to delete", "Error", "Error");
                loadData();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + subjectTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    myCon.ConnectionString = "server = localhost; user id = root; password = devil; database = sms";
                    try
                    {
                        myCon.Open();
                        string query;
                        query = "call st_deleteSubject(" + subID + ");";
                        myCmd = new MySqlCommand(query, myCon);
                        myCmd.ExecuteReader();
                        myCon.Close();
                        MainClass.ShowMSG(subjectTxt.Text + " deleted succesfully", "Success", "Success");
                        MainClass.disable_reset(panel6);
                        subjecErrLbl.Visible = false;
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
            if (classCB.SelectedIndex == -1)
            {
                MainClass.ShowMSG("Please Select Standard...!", "Error", "Error");
            }
            else
            {
                loadData();
            }
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            subjectTxt.Enabled = false;
            subjecErrLbl.Visible = false;
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                subID = Convert.ToInt32(row.Cells["subjectIDGV"].Value.ToString());
                subjectTxt.Text = row.Cells["subjectGv"].Value.ToString();
                classCB.SelectedItem = row.Cells["classGV"].Value.ToString();
            }
        }
        private void subjectTxt_TextChanged(object sender, EventArgs e)
        {
            if (subjectTxt.Text == "") { subjecErrLbl.Visible = true; } else { subjecErrLbl.Visible = false; }
        }
        private void subjectTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
        private void classCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classCB.SelectedIndex == -1) { classErrLbl.Visible = true; } else { classErrLbl.Visible = false; }
        }
        private void Subject_Load(object sender, EventArgs e)
        {
            subjectTxt.Enabled = false;
        }
    }
}
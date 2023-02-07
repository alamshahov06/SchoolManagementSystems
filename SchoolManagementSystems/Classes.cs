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
    public partial class Class : Sample2
    {
        public Class()
        {
            InitializeComponent();
        }
        MySqlConnection myCon = new MySqlConnection();
        MySqlCommand myCmd;
        int edit = -1;
        int classID=-1;
        string cls_name=null;
        private void loadData()
        {
            myCon.ConnectionString = MainClass.conn;
            MySqlDataAdapter da = new MySqlDataAdapter("st_getClass", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtblbook = new DataTable();
            classIDGV.DataPropertyName = "ID";
            classNameGv.DataPropertyName = "Name";
            feesGV.DataPropertyName = "Fees";
            da.Fill(dtblbook);
            dataGridView1.DataSource = dtblbook;
            MainClass.sno(dataGridView1, "SnoGV");
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.enable_reset(panel6);
        }
        public override void editBtn_Click(object sender, EventArgs e)
        {
            if (classID == -1)
            {
                MainClass.ShowMSG("Please, Select a record to edit", "Error", "Error");
                loadData();
            }
            edit = 1;
            MainClass.enable(panel6);
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (classTxt.Text == "" || feesTxt.Text == "")
            {
                MainClass.ShowMSG("Enter Standard/Fees", "Error", "Error");
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
                        query = "call st_insertClass('" + classTxt.Text + "'," + feesTxt.Text + ");";
                        myCmd = new MySqlCommand(query, myCon);
                        myCmd.ExecuteReader();
                        myCon.Close();
                        MainClass.ShowMSG(classTxt.Text + " added succesfully", "Success", "Success");
                        MainClass.disable_reset(panel6);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    loadData();
                }
                else if (edit == 1)
                {
                    try
                    {
                        myCon.Open();
                        string query;
                        query = "call st_updateClass(" + classID + ",'" + classTxt.Text + "'," + feesTxt.Text + ");";
                        myCmd = new MySqlCommand(query, myCon);
                        myCmd.ExecuteReader();
                        myCon.Close();
                        MainClass.ShowMSG(classTxt.Text + " updated succesfully", "Success", "Success");
                        MainClass.disable_reset(panel6);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    loadData();
                }
            }
        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (classID <= 1 || classTxt.Text == "")
            {
                MainClass.ShowMSG("Please, Select a record to delete", "Error", "Error");
                loadData();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure want to delete " + cls_name + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    myCon.ConnectionString = MainClass.conn;
                    try
                    {
                        myCon.Open();
                        string query;
                        query = "call st_deleteClass(" + classID + ");";
                        myCmd = new MySqlCommand(query, myCon);
                        myCmd.ExecuteReader();
                        myCon.Close();
                        MainClass.ShowMSG(classTxt.Text + " deleted succesfully", "Success", "Success");
                        MainClass.disable_reset(panel6);
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
        public override void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "Search")
            {
                loadData();
            }
            else
            {
                myCon.ConnectionString = MainClass.conn;
                try
                {
                    myCon.Open();
                    string query;
                    query = "call st_searchClass('" + textBox1.Text + "');";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, myCon);
                    DataTable searchDT = new DataTable();
                    classIDGV.DataPropertyName = "ID";
                    classNameGv.DataPropertyName = "Name";
                    feesGV.DataPropertyName = "Fees";
                    sda.Fill(searchDT);
                    dataGridView1.DataSource = searchDT;
                    MainClass.sno(dataGridView1, "SnoGV");
                    myCon.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                classID = Convert.ToInt32(row.Cells["classIDGV"].Value.ToString());
                cls_name = row.Cells["classNameGv"].Value.ToString();
                classTxt.Text = row.Cells["classNameGv"].Value.ToString();
                feesTxt.Text= row.Cells["feesGV"].Value.ToString();
                MainClass.disable(panel6);
            }
        }
        private void classTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
        private void feesTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void Class_Load(object sender, EventArgs e)
        {
           MainClass.disable_reset(panel6);
        }
        private void Class_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }
    }
}
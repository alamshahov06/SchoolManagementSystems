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
    public partial class Roles : Sample2
    {
        public Roles()
        {
            InitializeComponent();
        }
        MySqlConnection myCon = new MySqlConnection();
        MySqlCommand myCmd;
        int roleID=-1;
        int edit=-1;
        private void loadData()
        {
            myCon.ConnectionString = MainClass.conn;
            MySqlDataAdapter da = new MySqlDataAdapter("st_getRoles", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtblbook = new DataTable();
            rolesIDGV.DataPropertyName = "ID";
            RoleGV.DataPropertyName = "Role";
            da.Fill(dtblbook);
            dataGridView1.DataSource = dtblbook;
            MainClass.sno(dataGridView1, "SnoGV");
            MainClass.disable_reset(panel6);
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.enable_reset(panel6);
        }
        public override void editBtn_Click(object sender, EventArgs e)
        {
            if (roleID==-1)
            {
                MainClass.ShowMSG("Please, Select a record to edit", "Error", "Error");
                loadData();
            }
            edit = 1;
            MainClass.enable(panel6);
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (roleTxt.Text == "")
            {
                MainClass.ShowMSG("Please Enter Role Name", "Error", "Error");
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
                        query = "call st_insertRoles('" + roleTxt.Text + "');";
                        myCmd = new MySqlCommand(query, myCon);
                        myCmd.ExecuteReader();
                        myCon.Close();
                        MainClass.ShowMSG(roleTxt.Text + " added succesfully", "Success", "Success");
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
                        query = "call st_updateRoles(" + roleID + ",'" + roleTxt.Text + "');";
                        myCmd = new MySqlCommand(query, myCon);
                        myCmd.ExecuteReader();
                        myCon.Close();
                        MainClass.ShowMSG(roleTxt.Text + " updated succesfully", "Success", "Success");
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
            if (roleID == -1)
            {
                MainClass.ShowMSG("Please, Select a record to delete", "Error", "Error");
                loadData();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + roleTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    myCon.ConnectionString = MainClass.conn;
                    try
                    {
                        myCon.Open();
                        string query;
                        query = "call st_deleteRole(" + roleID + ");";
                        myCmd = new MySqlCommand(query, myCon);
                        myCmd.ExecuteReader();
                        myCon.Close();
                        MainClass.ShowMSG(roleTxt.Text + " deleted succesfully", "Success", "Success");
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
                    query = "call st_searchRole('" + textBox1.Text + "');";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, myCon);
                    DataTable searchDT = new DataTable();
                    rolesIDGV.DataPropertyName = "ID";
                    RoleGV.DataPropertyName = "Role";
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
                roleID = Convert.ToInt32(row.Cells["rolesIDGV"].Value.ToString());
                roleTxt.Text = row.Cells["RoleGV"].Value.ToString();
                MainClass.disable(panel6);
            }
        }
        private void roleTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
        private void Roles_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
        }
        private void Roles_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }
    }
}

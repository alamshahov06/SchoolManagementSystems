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
using System.Drawing.Imaging;
using System.IO;
using DGVPrinterHelper;

namespace SchoolManagementSystems
{
    public partial class Staff : Sample2
    {
        public Staff()
        {
            InitializeComponent();
            fillCombo();
        }
        MySqlConnection myCon = new MySqlConnection();
        MySqlCommand myCmd;
        int edit = -1;
        int staffID = -1;
        void fillCombo()
        {
            myCon.ConnectionString = MainClass.conn;
            string query = "select * from sms.roles";
            myCmd = new MySqlCommand(query, myCon);
            MySqlDataReader dr;
            try
            {
                myCon.Open();
                dr = myCmd.ExecuteReader();
                while (dr.Read())
                {
                    string sName = dr.GetString("r_name");
                    roleCb.Items.Add(sName);
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
            myCon.ConnectionString = MainClass.conn;
            MySqlDataAdapter ad = new MySqlDataAdapter("st_getStaff", myCon);
            ad.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtblbook = new DataTable();
            userIDGV.DataPropertyName = "ID";
            nameGv.DataPropertyName = "Name";
            usernameGv.DataPropertyName = "Username";
            pswdGv.DataPropertyName = "Password";
            phoneGv.DataPropertyName = "Phone";
            rollGv.DataPropertyName = "Role";
            ad.Fill(dtblbook);
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
            edit = 1;
            MainClass.enable(panel6);
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
            {
                nameErrLbl.Visible = true;
            }
            else
            {
                if (!nameTxt.Text.ToString().Contains(" "))
                {
                    MainClass.ShowMSG("Enter full name", "Error", "Error");
                    nameErrLbl.Visible = true;
                }
                else
                {
                    nameErrLbl.Visible = false;
                }
            }
            if (userNameTxt.Text == "") { userErrLbl.Visible = true; } else { userErrLbl.Visible = false; }
            if (pswdTxt.Text == "") { pswdErrLbl.Visible = true; } else { pswdErrLbl.Visible = false; }
            if (cpswdTxt.Text == "") { cpswdErrLbl.Visible = true; } else { cpswdErrLbl.Visible = false; }
            if (pswdTxt.Text != cpswdTxt.Text) { mismatchedErrLbl.Visible = true; } else { mismatchedErrLbl.Visible = false; }
            if (phoneTxt.Text == "") { phoneErrLbl.Visible = true; } else { phoneErrLbl.Visible = false; }
            if (roleCb.SelectedIndex == -1) { roleErrLbl.Visible = true; } else { roleErrLbl.Visible = false; }
            if (nameErrLbl.Visible || pswdErrLbl.Visible || cpswdErrLbl.Visible || mismatchedErrLbl.Visible || phoneErrLbl.Visible || roleErrLbl.Visible)
            {
                MainClass.ShowMSG("Fields with * are madantory", "Error", "Error");
            }
            else
            {
                if (edit == 0)
                {
                    myCon.ConnectionString = MainClass.conn;
                    try
                    {
                        myCon.Open();
                        string query;
                        query = "call st_insertStaff('" + nameTxt.Text + "','" + userNameTxt.Text + "','" + pswdTxt.Text + "','" + phoneTxt.Text + "','" + roleCb.SelectedItem + "');";
                        myCmd = new MySqlCommand(query, myCon);
                        myCmd.ExecuteReader();
                        myCon.Close();
                        MainClass.ShowMSG(nameTxt.Text + " added succesfully", "Success", "Success");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (edit == 1)
                {
                    if (staffID >= -1)
                    {
                        try
                        {
                            myCon.ConnectionString = MainClass.conn;
                            myCon.Open();
                            string query;
                            query = "call st_updateStaff(" + staffID + ",'" + nameTxt.Text + "','" + userNameTxt.Text + "','" + pswdTxt.Text + "','" + phoneTxt.Text + "','" + roleCb.SelectedItem + "');";
                            myCmd = new MySqlCommand(query, myCon);
                            myCmd.ExecuteReader();
                            myCon.Close();
                            MainClass.ShowMSG(nameTxt.Text + " updated succesfully", "Success", "Success");
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        MainClass.ShowMSG("Please, select record to edit", "Error", "Error");
                        loadData();
                    }
                }
                loadData();
            }
        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (staffID != -1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + nameTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        myCon.ConnectionString = MainClass.conn;
                        myCon.Open();
                        string query;
                        query = "call st_deleteStaff(" + staffID + ");";
                        myCmd = new MySqlCommand(query, myCon);
                        myCmd.ExecuteReader();
                        myCon.Close();
                        MainClass.ShowMSG(nameTxt.Text + " deleted succesfully", "Success", "Success");
                        MainClass.disable_reset(panel6);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    loadData();
                }
            }
            else
            {
                MainClass.ShowMSG("Please, select record to delete", "Error", "Error");
                loadData();
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
            myCon.ConnectionString = MainClass.conn;
            try
            {
                myCon.Open();
                string query;
                query = "call st_searchStaff('" + textBox1.Text + "');";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, myCon);
                DataTable searchDT = new DataTable();
                userIDGV.DataPropertyName = "ID";
                nameGv.DataPropertyName = "Name";
                usernameGv.DataPropertyName = "Username";
                pswdGv.DataPropertyName = "Password";
                phoneGv.DataPropertyName = "Phone";
                rollGv.DataPropertyName = "Role";
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                staffID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["nameGv"].Value.ToString();
                userNameTxt.Text = row.Cells["usernameGv"].Value.ToString();
                pswdTxt.Text = row.Cells["pswdGv"].Value.ToString();
                cpswdTxt.Text = row.Cells["pswdGv"].Value.ToString();
                phoneTxt.Text = row.Cells["phoneGv"].Value.ToString();
                roleCb.SelectedItem = row.Cells["rollGv"].Value.ToString();
            }
        }
        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text == "") { nameErrLbl.Visible = true; } else { nameErrLbl.Visible = false; }
        }
        private void nameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
                e.Handled = true;
        }
        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (userNameTxt.Text == "") { userErrLbl.Visible = true; } else { userErrLbl.Visible = false; }
        }
        private void pswdTxt_TextChanged(object sender, EventArgs e)
        {
            if (pswdTxt.Text == "") { pswdErrLbl.Visible = true; } else { pswdErrLbl.Visible = false; }
        }
        private void cpswdTxt_TextChanged(object sender, EventArgs e)
        {
            if (cpswdTxt.Text == "") { cpswdErrLbl.Visible = true; } else { cpswdErrLbl.Visible = false; }
        }
        private void cpswdTxt_Validating(object sender, CancelEventArgs e)
        {
            if (pswdTxt.Text != cpswdTxt.Text) { mismatchedErrLbl.Visible = true; } else { mismatchedErrLbl.Visible = false; }
        }
        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "") { phoneErrLbl.Visible = true; } else { phoneErrLbl.Visible = false; }
        }
        private void phoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }
        private void roleCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleCb.SelectedIndex == -1) { roleErrLbl.Visible = true; } else { roleErrLbl.Visible = false; }
        }
        private void Staff_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
        }
    }
}

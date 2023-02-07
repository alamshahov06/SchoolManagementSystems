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
    public partial class Admission : Sample2
    {
        public Admission()
        {
            InitializeComponent();
            fillCombo();
        }
        MySqlConnection myCon = new MySqlConnection();
        MySqlCommand myCmd;
        int edit = -1;
        int stdID = -1;
        string gndr;
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
                    stdCb.Items.Add(sName);
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
            MainClass.refresh(panel6);
            myCon.ConnectionString = MainClass.conn;
            MySqlDataAdapter ad = new MySqlDataAdapter("st_getStudent", myCon);
            ad.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtblbook = new DataTable();
            userIDGV.DataPropertyName = "ID";
            nameGv.DataPropertyName = "Name";
            addGv.DataPropertyName = "Address";
            phoneGv.DataPropertyName = "Phone";
            genderGv.DataPropertyName = "Gender";
            stdGv.DataPropertyName = "Standard";
            divGv.DataPropertyName = "Division";
            usernameGv.DataPropertyName = "Username";
            pswdGv.DataPropertyName = "Password";
            ad.Fill(dtblbook);
            dataGridView1.DataSource = dtblbook;
            MainClass.sno(dataGridView1, "SnoGV");
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.enable_reset(panel6);
            MainClass.refresh(panel6);
        }
        public override void editBtn_Click(object sender, EventArgs e)
        {
            if (stdID != -1)
            {
                edit = 1;
                MainClass.enable(panel6);
            }
            else
            {
                MainClass.ShowMSG("Please, select record to delete", "Error", "Error");
                loadData();
            }
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
            {
                nameErrorLbl.Visible = true;
            }
            else
            {
                if (!nameTxt.Text.ToString().Contains(" "))
                {
                    MainClass.ShowMSG("Enter full name", "Error", "Error");
                    nameErrorLbl.Visible = true;
                }
                else
                {
                    nameErrorLbl.Visible = false;
                }
            }
            if (addTxt.Text == "") { addErrorLbl.Visible = true; } else { addErrorLbl.Visible = false; }
            if (cnctTxt.Text == "") { cnctErrorLbl.Visible = true; } else { cnctErrorLbl.Visible = false; }
            if (stdCb.SelectedIndex == -1) { stdErrorLbl.Visible = true; } else { stdErrorLbl.Visible = false; }
            if (divCb.SelectedIndex == -1) { divErrorLbl.Visible = true; } else { divErrorLbl.Visible = false; }
            if (unameCb.Text == "") { unameErrorLbl.Visible = true; } else { unameErrorLbl.Visible = false; }
            if (pswdCb.Text == "") { pswdErrorLbl.Visible = true; } else { pswdErrorLbl.Visible = false; }
            if (maleBtn.Checked || fmaleBtn.Checked) { genderErrorLbl.Visible = false; } else { genderErrorLbl.Visible = true; }
            if (addErrorLbl.Visible || cnctErrorLbl.Visible || stdErrorLbl.Visible || divErrorLbl.Visible || unameErrorLbl.Visible || pswdErrorLbl.Visible || genderErrorLbl.Visible)
            {
                MainClass.ShowMSG("Fields with * are madantory", "Error", "Error");
            }
            else
            {
                if (maleBtn.Checked == true)
                {
                    gndr = "Male";
                }
                else if (fmaleBtn.Checked == true)
                {
                    gndr = "Female";
                }
                if (edit == 0)
                {
                    myCon.ConnectionString = MainClass.conn;
                    try
                    {
                        myCon.Open();
                        string query;
                        query = "call st_insertStudent('" + nameTxt.Text + "','" + addTxt.Text + "','" + cnctTxt.Text + "','" + gndr + "','" + stdCb.SelectedItem + "','" + divCb.SelectedItem + "','" + unameCb.Text + "','" + pswdCb.Text + "');";
                        myCmd = new MySqlCommand(query, myCon);
                        myCmd.ExecuteReader();
                        myCon.Close();
                        MainClass.ShowMSG(nameTxt.Text + " added succesfully", "Success", "Success");
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
                    if (stdID >= -1)
                    {
                        try
                        {
                            myCon.ConnectionString = MainClass.conn;
                            myCon.Open();
                            string query;
                            query = "call st_updateStudent(" + stdID + ",'" + nameTxt.Text + "','" + addTxt.Text + "','" + cnctTxt.Text + "','" + gndr + "','" + stdCb.SelectedItem + "','" + divCb.SelectedItem + "','" + unameCb.Text + "','" + pswdCb.Text + "'); ";
                            myCmd = new MySqlCommand(query, myCon);
                            myCmd.ExecuteReader();
                            myCon.Close();
                            MainClass.ShowMSG(nameTxt.Text + " updated succesfully", "Success", "Success");
                            MainClass.disable_reset(panel6);
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        loadData();
                    }
                }
                MainClass.disable_reset(panel6);
            }
        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (stdID != -1)
            {
                DialogResult dr = MessageBox.Show("Are you want to delete " + nameTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        myCon.ConnectionString = MainClass.conn;
                        myCon.Open();
                        string query;
                        query = "call st_deleteStudent(" + stdID + ");";
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
            MainClass.disable_reset(panel6);
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
                    query = "call st_searchStudenr('" + textBox1.Text + "');";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, myCon);
                    DataTable searchDT = new DataTable();
                    userIDGV.DataPropertyName = "ID";
                    nameGv.DataPropertyName = "Name";
                    addGv.DataPropertyName = "Address";
                    phoneGv.DataPropertyName = "Phone";
                    genderGv.DataPropertyName = "Gender";
                    stdGv.DataPropertyName = "Standard";
                    divGv.DataPropertyName = "Division";
                    usernameGv.DataPropertyName = "Username";
                    pswdGv.DataPropertyName = "Password";
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
                stdID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["nameGv"].Value.ToString();
                addTxt.Text = row.Cells["addGv"].Value.ToString();
                unameCb.Text = row.Cells["usernameGv"].Value.ToString();
                pswdCb.Text = row.Cells["pswdGv"].Value.ToString();
                cnctTxt.Text = row.Cells["phoneGv"].Value.ToString();
                stdCb.SelectedItem = row.Cells["stdGv"].Value.ToString();
                divCb.SelectedItem = row.Cells["divGv"].Value.ToString();
                gndr = row.Cells["genderGv"].Value.ToString();
                if (gndr == "Male")
                {
                    maleBtn.Checked = true;
                    fmaleBtn.Checked = false;
                }
                else
                {
                    fmaleBtn.Checked = true;
                    maleBtn.Checked = false;
                }
            }
        }
        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text == "") { nameErrorLbl.Visible = true; } else { nameErrorLbl.Visible = false; }
        }
        private void nameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
        private void addTxt_TextChanged(object sender, EventArgs e)
        {
            if (addTxt.Text == "") { addErrorLbl.Visible = true; } else { addErrorLbl.Visible = false; }
        }
        private void addTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
        private void cnctTxt_TextChanged(object sender, EventArgs e)
        {
            if (cnctTxt.Text == "") { cnctErrorLbl.Visible = true; } else { cnctErrorLbl.Visible = false; }
        }
        private void cnctTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void stdCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stdCb.SelectedIndex==-1) { stdErrorLbl.Visible = true; } else { stdErrorLbl.Visible = false; }
        }
        private void divCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (divCb.SelectedIndex == -1) { divErrorLbl.Visible = true; } else { divErrorLbl.Visible = false; }
        }
        private void unameCb_TextChanged(object sender, EventArgs e)
        {
            if (unameCb.Text == "") { unameErrorLbl.Visible = true; } else { unameErrorLbl.Visible = false; }
        }
        private void pswdCb_TextChanged(object sender, EventArgs e)
        {
            if (pswdCb.Text == "") { pswdErrorLbl.Visible = true; } else { pswdErrorLbl.Visible = false; }
        }
        private void maleBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (maleBtn.Checked || fmaleBtn.Checked)
            {
                genderErrorLbl.Visible =false;
            }
            else 
            {
                genderErrorLbl.Visible =false;
            }
        }
        private void fmaleBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (maleBtn.Checked || fmaleBtn.Checked)
            {
                genderErrorLbl.Visible = false;
            }
            else
            {
                genderErrorLbl.Visible = false;
            }
        }
        private void admsm_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }
    }
}
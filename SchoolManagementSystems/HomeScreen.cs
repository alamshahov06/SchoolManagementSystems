using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
namespace SchoolManagementSystems
{
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
            if (MainClass.sLogo != null && MainClass.sName != "")
            {
               
                MemoryStream ms = new MemoryStream(MainClass.sLogo);
                pictureBox1.Image = Image.FromStream(ms);
                label1.Text = MainClass.sName;
            }
            nameLbl.Text = MainClass.name;
            roleLbl.Text = MainClass.role;
            ToolTip tp=new ToolTip();
            tp.SetToolTip(smsBtn, "Massage");
            tp.SetToolTip(notifyBtn, "Notifications");
            tp.SetToolTip(infoBtn, "About");
            tp.SetToolTip(profileBtn, "My Profile");
            tp.SetToolTip(toTxt,"Recepient Name / Standard Name / All");
        }
        MySqlConnection myCon = new MySqlConnection();
        MySqlCommand myCmd,myCmd1, myCmd2, myCmd3,msgCmd;
        private void button2_Click(object sender, EventArgs e)
        {
            Class cls = new Class();
            MainClass.showWindow(cls, this);
        }
        private void userBtn_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            MainClass.showWindow(st, this);
        }
        private void rolesBtn_Click(object sender, EventArgs e)
        {
            Roles roll = new Roles();
            MainClass.showWindow(roll, this);
        }
        private void sectionBtn_Click(object sender, EventArgs e)
        {
            Sections sec = new Sections();
            MainClass.showWindow(sec, this);
        }
        private void studentBtn_Click(object sender, EventArgs e)
        {
            Admission a = new Admission();
            MainClass.showWindow(a,this);
        }
        private void sbjktBtn_Click(object sender, EventArgs e)
        {
            Subject sb = new Subject();
            MainClass.showWindow(sb, this);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Subject sb = new Subject();
            MainClass.showWindow(sb, this);
        }
        private void stdntBtn_Click(object sender, EventArgs e)
        {
            Admission a = new Admission();
            MainClass.showWindow(a, this);
        }
        private void teacherBtn_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            MainClass.showWindow(st, this);
        }
        private void divisionBtn_Click(object sender, EventArgs e)
        {
            Sections sec = new Sections();
            MainClass.showWindow(sec, this);
        }
        private void standardBtn_Click(object sender, EventArgs e)
        {
            Class cls = new Class();
            MainClass.showWindow(cls, this);
        }
        private void admisnBtn_Click(object sender, EventArgs e)
        {
            Admission a = new Admission();
            MainClass.showWindow(a, this);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Roles roll = new Roles();
            MainClass.showWindow(roll, this);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Attendance atd = new Attendance();
            MainClass.showWindow(atd,this);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            marks r = new marks();
            MainClass.showWindow(r,this);
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Fees f = new Fees();
            MainClass.showWindow(f, this);
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            login_win l = new login_win();
            l.Show();
            l.WindowState = FormWindowState.Maximized;
            this.Hide();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            smsPanel.BorderStyle = BorderStyle.FixedSingle;
            smsPanel.Visible = true;
            smsPanel.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            profilePanel.BorderStyle = BorderStyle.FixedSingle;
            profilePanel.Visible = true;
            profilePanel.Enabled = true;
        }
        private void loadData()
        {
            myCon.ConnectionString = MainClass.conn;
            string nQuery;
            nQuery = "select * from massage where m_receiverID=" + MainClass.id + " and m_role='"+MainClass.role+"';";
            MySqlDataAdapter ad = new MySqlDataAdapter(nQuery, myCon);
            DataTable dtblbook = new DataTable();
            msgIDGV.DataPropertyName = "m_id";
            senderIDGV.DataPropertyName = "m_senderID";
            receiverIDGV.DataPropertyName = "m_receiverID";
            roleGV.DataPropertyName = "m_role";
            fromGV.DataPropertyName = "m_sender";
            titleGV.DataPropertyName = "m_title";
            msgGV.DataPropertyName = "m_msg";
            ad.Fill(dtblbook);
            dataGridView1.DataSource = dtblbook;
            dataGridView1.Columns["fromGV"].DisplayIndex = 0;
            dataGridView1.Columns["titleGV"].DisplayIndex = 1;
            dataGridView1.Columns["msgGV"].DisplayIndex = 2;
            dataGridView1.Columns["closeGV"].DisplayIndex = 3;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            notifyPanel.BorderStyle = BorderStyle.FixedSingle;
            notifyPanel.Visible = true;
            notifyPanel.Enabled = true;
            loadData();
        }
        private void button3_Click_2(object sender, EventArgs e)
        {
            infoPanel.Visible = false;
            infoPanel.Enabled = false;
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            //   location  405 191
            //    info     661, 584 
            //    profile  661, 600
            //    massage  661, 695
            infoPanel.BorderStyle = BorderStyle.FixedSingle;
            infoPanel.Visible = true;
            infoPanel.Enabled = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (nameCb.Checked == true)
                nameTxt.Enabled = true;
            else
                nameTxt.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (pswdCb.Checked == true)
                pswdTxt.Enabled = true;
            else
                pswdTxt.Enabled = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            profilePanel.Visible = false;
            profilePanel.Enabled = false;
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            login_win l = new login_win();
            l.Show();
            l.WindowState = FormWindowState.Maximized;
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void smsClose_Click(object sender, EventArgs e)
        {
            smsPanel.Visible = false;
            smsPanel.Enabled = false;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            MySqlCommand msgCmd1,msgCmd2;
            if(toCb.SelectedIndex!=-1 && toTxt.Text!="" && titleTxt.Text!="" && smsTxt.Text!="")
            {
                ArrayList id = new ArrayList();
                string query1 = null, query2 = null;
                myCon.ConnectionString = MainClass.conn;
                if (toCb.SelectedItem.ToString()=="Student")
                {
                    if (toTxt.Text == "All")
                    {
                        query2 = "select std_id from student";
                        msgCmd2 = new MySqlCommand(query2, myCon);
                        MySqlDataReader msgdr2;
                        try
                        {

                            myCon.Open();
                            msgdr2 = msgCmd2.ExecuteReader();
                            while (msgdr2.Read())
                            {
                                id.Add(msgdr2.GetValue(0).ToString());
                            }
                            msgdr2.Close();
                            myCon.Close();

                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.Message);
                        }
                        foreach (String rid in id)
                        {
                            try
                            {
                                myCon.Open();
                                query1 = "insert into  massage values(m_id,'"+titleTxt.Text+"','" + smsTxt.Text + "','"+MainClass.name+"','"+toCb.SelectedItem+"'," + MainClass.id + "," + rid.ToString() + ")";
                                msgCmd1 = new MySqlCommand(query1, myCon);
                                msgCmd1.ExecuteReader();
                                myCon.Close();
                            }
                            catch (Exception exp)
                            {
                                MessageBox.Show(exp.Message);
                            }
                        }
                        MainClass.ShowMSG("Message sent successfully", "Success", "Success");
                    }
                    else
                    {
                        query2 = "select std_id from student where std_std='"+toTxt.Text+"' ";
                        msgCmd2 = new MySqlCommand(query2, myCon);
                        MySqlDataReader msgdr2;
                        try
                        {
                            myCon.Open();
                            msgdr2 = msgCmd2.ExecuteReader();
                            while (msgdr2.Read())
                            {
                                id.Add(msgdr2.GetValue(0).ToString());
                            }
                            msgdr2.Close();
                            myCon.Close();
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.Message);
                        }
                        foreach (String rid in id)
                        {
                            try
                            {
                                myCon.Open();
                                query1 = "insert into  massage values(m_id,'"+titleTxt.Text+"','" + smsTxt.Text + "','"+MainClass.name+"','"+toCb.SelectedItem+"'," + MainClass.id + "," + rid.ToString() + " )";
                                msgCmd1 = new MySqlCommand(query1, myCon);
                                msgCmd1.ExecuteReader();
                                myCon.Close();
                            }
                            catch (Exception exp)
                            {
                                MessageBox.Show(exp.Message);
                            }
                        }
                        MainClass.ShowMSG("Message sent successfully", "Success", "Success");
                    }
                }
                else
                {
                    if (toTxt.Text == "All")
                    {
                        query2 = "select st_id from staff where st_role='"+toCb.SelectedItem.ToString()+"' ";
                        msgCmd2 = new MySqlCommand(query2, myCon);
                        MySqlDataReader msgdr2;
                        try
                        {
                            myCon.Open();
                            msgdr2 = msgCmd2.ExecuteReader();
                            while (msgdr2.Read())
                            {
                                id.Add(msgdr2.GetValue(0).ToString());
                            }
                            msgdr2.Close();
                            myCon.Close();
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.Message);
                        }
                        foreach (String rid in id)
                        {
                            try
                            {
                                myCon.Open();
                                query1 = "insert into  massage values(m_id,'"+titleTxt.Text+"','" + smsTxt.Text + "','"+MainClass.name+"','"+toCb.SelectedItem +"'," + MainClass.id + "," + rid.ToString() + " )";
                                msgCmd1 = new MySqlCommand(query1, myCon);
                                msgCmd1.ExecuteReader();
                                myCon.Close();
                            }
                            catch (Exception exp)
                            {
                                MessageBox.Show(exp.Message);
                            }
                        }
                        MainClass.ShowMSG("Message sent successfully", "Success", "Success");
                    }
                    else
                    {
                        String roll_id;
                        query2 = "select st_id from staff where st_role='"+toCb.SelectedItem.ToString()+"' and st_name='" + toTxt.Text + "' ";
                        msgCmd2 = new MySqlCommand(query2, myCon);
                        MySqlDataReader msgdr2;
                        try
                        {
                            myCon.Open();
                            msgdr2 = msgCmd2.ExecuteReader();
                            msgdr2.Read();
                            roll_id=msgdr2.GetValue(0).ToString();
                            msgdr2.Close();
                            query1 = "insert into  massage values(m_id,'"+titleTxt.Text+"','" + smsTxt.Text + "','"+MainClass.name+"','"+toCb.SelectedItem+"'," + MainClass.id + "," + roll_id + " )";
                            msgCmd1 = new MySqlCommand(query1, myCon);
                            msgCmd1.ExecuteReader();
                            myCon.Close();
                            MainClass.ShowMSG("Message sent successfully", "Success", "Success");
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.Message);
                        }
                    }
                }
                toCb.SelectedIndex = -1;
                toTxt.Text = null;
                titleTxt.Text = null;
                smsTxt.Text = null;
                id.Clear();
            }
            else 
            {
                MainClass.ShowMSG("Feilds are Empty", "Error", "Error");
            }
        }

        private void smsTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void toCb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            notifyPanel.Visible = false;
            notifyPanel.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {

                if (e.ColumnIndex == 0)
                {
                    MySqlCommand noteCmd;
                    string Nquery;
                    myCon.ConnectionString = MainClass.conn;
                    int rowNo;
                    int msgID;
                    rowNo = e.RowIndex;
                    msgID = Convert.ToInt32(dataGridView1.Rows[rowNo].Cells["msgIDGV"].Value.ToString());
                    try
                    {
                        myCon.Open();
                        Nquery = "delete from massage where m_id=" + msgID + " ";
                        noteCmd = new MySqlCommand(Nquery, myCon);
                        noteCmd.ExecuteReader();
                        myCon.Close();
                        loadData();
                        MainClass.ShowMSG("Message deleted successfully", "Success", "Success");
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
            }
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Setting s = new Setting();
            MainClass.showWindow(s, this);
        }

        private void toTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string query=null;
            myCon.ConnectionString = MainClass.conn;
            if ((nameCb.Checked == true && nameTxt.Text != "") && (pswdCb.Checked == true && pswdTxt.Text != ""))
            {
                if (MainClass.role == "Student")
                    query = "update student set std_uname='" + nameTxt.Text + "',std_pswd='" + pswdTxt.Text + "' where std_id=" + MainClass.id + " ";
                else
                    query = "update staff set st_username='" + nameTxt.Text + "',st_pswd='" + pswdTxt.Text + "' where st_id=" + MainClass.id + " ";
            }
            else if (nameCb.Checked == true && nameTxt.Text != "")
            {
                if (MainClass.role == "Student")
                    query = "update student set std_uname='" + nameTxt.Text + "' where std_id=" + MainClass.id + " ";
                else
                    query = "update staff set st_username='" + nameTxt.Text + "' where st_id=" + MainClass.id + " ";
            }
            else if (pswdCb.Checked == true && pswdTxt.Text != "")
            {
                if (MainClass.role == "Student")
                    query = "update student set std_pswd='" + pswdTxt.Text + "' where std_id=" + MainClass.id + " ";
                else
                    query = "update staff set st_pswd='" + pswdTxt.Text + "' where st_id=" + MainClass.id + " ";
            }
            if (query != "")
            {
                myCmd = new MySqlCommand(query, myCon);
                try
                {
                    myCon.Open();
                    myCmd.ExecuteReader();
                    myCon.Close();
                    nameCb.Checked = false;
                    pswdCb.Checked = false;
                    nameTxt.Text = null;
                    pswdTxt.Text = null;
                    MainClass.ShowMSG("Profile updated successfully", "Success", "Success");
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            else
                MainClass.ShowMSG("Fields are empty","Error","Error");
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void HomeScreen_Load(object sender, EventArgs e)
        {
            int sno = 0, tno = 0, stfno = 0, i;
            await Task.Delay(1200);
            myCon.ConnectionString = MainClass.conn;
            string query1 = "select count(*) from sms.staff where st_role='Teacher';";
            string query2 = "select count(*) from sms.student;";
            string query3 = "select count(*) from sms.staff;";
            myCmd1 = new MySqlCommand(query1, myCon);
            myCmd2 = new MySqlCommand(query2, myCon);
            myCmd3 = new MySqlCommand(query3, myCon);
            MySqlDataReader dr1, dr2, dr3;
            try
            {
                myCon.Open();
                dr1 = myCmd1.ExecuteReader();
                dr1.Read();
                tno = Convert.ToInt32(dr1.GetString("count(*)"));
                dr1.Close();
                dr2 = myCmd2.ExecuteReader();
                dr2.Read();
                sno = Convert.ToInt32(dr2.GetString("count(*)"));
                dr2.Close();
                dr3 = myCmd2.ExecuteReader();
                dr3.Read();
                stfno = Convert.ToInt32(dr3.GetString("count(*)"));
                dr3.Close();
                myCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            for (i = 0; i <= sno; i++)
            {
                statLbl2.Text = i.ToString();
                statLbl2.Update();
                if (i <= stfno)
                {
                    statLbl3.Text = i.ToString();
                    statLbl3.Update();
                }
                if (i <= tno)
                {
                    statLbl1.Text = i.ToString();
                    statLbl1.Update();
                }
                await Task.Delay(200);
            }

        }
    }
}
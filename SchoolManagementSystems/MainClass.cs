using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SchoolManagementSystems
{
    class MainClass
    {
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string conn;
        public static string role;
        public static string name;
        public static string id;
        public static string sName;// School name
        public static byte[] sLogo;// School logo
        public static void refresh(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is Label)
                {
                    Label b = (Label)c;
                    if(b.Text=="*")
                        b.Visible = false;
                }
            }
        }
        public static void showWindow(Form openWin,Form closeWin)
        {
            openWin.Show();
            openWin.WindowState = FormWindowState.Maximized;
            closeWin.Hide();
        }
         public static DialogResult ShowMSG(string msg , string heading , string type)
        {
            if(type == "Success")
            {
                return MessageBox.Show(msg , heading , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void disable_reset(Panel p)
        {
            foreach(Control c in p.Controls)
            {
                if(c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    t.Text = null;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }

                if (c is RadioButton)
                {
                    RadioButton r = (RadioButton)c;
                    r.Enabled = false;
                    r.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                    cb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                    dtp.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                if (c is Label)
                {
                    Label b = (Label)c;
                    if (b.Text == "*")
                        b.Visible = false;
                }
            }
        }
        public static void disable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                }
                if (c is RadioButton)
                {
                    RadioButton r = (RadioButton)c;
                    r.Enabled = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                }
                if(c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                if (c is Label)
                {
                    Label b = (Label)c;
                    if (b.Text == "*")
                        b.Visible = false;
                }
            }
        }
        public static void enable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                }
                if (c is RadioButton)
                {
                    RadioButton r = (RadioButton)c;
                    r.Enabled = true;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = true;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                }
                if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                }
                if (c is Label)
                {
                    Label b = (Label)c;
                    if (b.Text == "*")
                        b.Visible = false;
                }
            }
        }
        public static void enable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = null;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton r = (RadioButton)c;
                    r.Enabled = true;
                    r.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    cb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                }
                if (c is Label)
                {
                    Label b = (Label)c;
                    if (b.Text == "*")
                        b.Visible = false;
                }
            }
        }
        public static void enable_reset(GroupBox gb)
        {
            foreach (Control c in gb.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = null;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton r = (RadioButton)c;
                    r.Enabled = true;
                    r.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    cb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                }
            }
        }
        public static void sno(DataGridView gv, String colname)
        {
            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                count += 1;
                row.Cells[colname].Value = count;
            }
        }
    }
}

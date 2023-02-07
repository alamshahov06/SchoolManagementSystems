using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystems
{
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }
        string rol;
        public virtual void addBtn_Click(object sender, EventArgs e) { }
        public virtual void editBtn_Click(object sender, EventArgs e) { }
        public virtual void saveBtn_Click(object sender, EventArgs e) { }
        public virtual void deleteBtn_Click(object sender, EventArgs e) { }
        public virtual void viewBtn_Click(object sender, EventArgs e) { }
        public virtual void searchTxt_TextChanged(object sender, EventArgs e) { }
        public void button1_Click(object sender, EventArgs e)
        {
            rol = MainClass.role;
            if (rol == "Admin")
            {
                HomeScreen hs = new HomeScreen();
                MainClass.showWindow(hs, this);
            }
            else if (rol == "Principal")
            {
                PrincipalHM hs = new PrincipalHM();
                MainClass.showWindow(hs, this);
            }
            else if (rol == "Teacher")
            {
                TeacherHM hs = new TeacherHM();
                MainClass.showWindow(hs, this);
            }
            else if (rol == "Non-Teaching Staff")
            {
                NTStaff hs = new NTStaff();
                MainClass.showWindow(hs, this);
            }
            else if (rol == "Student")
            {
                studentHM hs = new studentHM();
                MainClass.showWindow(hs, this);
            }
        }
        public virtual void searchTxt_Leave(object sender, EventArgs e) { }
        public virtual void textBox1_TextChanged(object sender, EventArgs e) { }
        public virtual void textBox1_Enter(object sender, EventArgs e) { }
        public virtual void textBox1_Leave(object sender, EventArgs e) { }
        public void Sample2_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

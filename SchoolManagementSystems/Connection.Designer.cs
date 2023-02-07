namespace SchoolManagementSystems
{
    partial class Connection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.dbTxt = new System.Windows.Forms.TextBox();
            this.dataSourceTxt = new System.Windows.Forms.TextBox();
            this.dataSourceLbl = new System.Windows.Forms.Label();
            this.pswdTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.dbLbl = new System.Windows.Forms.Label();
            this.pswdLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.dbTxt);
            this.panel1.Controls.Add(this.dataSourceTxt);
            this.panel1.Controls.Add(this.dataSourceLbl);
            this.panel1.Controls.Add(this.pswdTxt);
            this.panel1.Controls.Add(this.usernameTxt);
            this.panel1.Controls.Add(this.dbLbl);
            this.panel1.Controls.Add(this.pswdLbl);
            this.panel1.Controls.Add(this.usernameLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 636);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 71);
            this.panel2.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "School Management System";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saveBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.saveBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveBtn.Location = new System.Drawing.Point(136, 495);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(339, 84);
            this.saveBtn.TabIndex = 37;
            this.saveBtn.Text = "&SAVE";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dbTxt
            // 
            this.dbTxt.BackColor = System.Drawing.Color.Snow;
            this.dbTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dbTxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dbTxt.Location = new System.Drawing.Point(137, 258);
            this.dbTxt.Margin = new System.Windows.Forms.Padding(4);
            this.dbTxt.MaxLength = 20;
            this.dbTxt.Name = "dbTxt";
            this.dbTxt.Size = new System.Drawing.Size(339, 39);
            this.dbTxt.TabIndex = 2;
            // 
            // dataSourceTxt
            // 
            this.dataSourceTxt.BackColor = System.Drawing.Color.Snow;
            this.dataSourceTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataSourceTxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dataSourceTxt.Location = new System.Drawing.Point(137, 179);
            this.dataSourceTxt.Margin = new System.Windows.Forms.Padding(4);
            this.dataSourceTxt.MaxLength = 20;
            this.dataSourceTxt.Name = "dataSourceTxt";
            this.dataSourceTxt.Size = new System.Drawing.Size(339, 39);
            this.dataSourceTxt.TabIndex = 1;
            // 
            // dataSourceLbl
            // 
            this.dataSourceLbl.AutoSize = true;
            this.dataSourceLbl.BackColor = System.Drawing.Color.Transparent;
            this.dataSourceLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataSourceLbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dataSourceLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataSourceLbl.Location = new System.Drawing.Point(129, 143);
            this.dataSourceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dataSourceLbl.Name = "dataSourceLbl";
            this.dataSourceLbl.Size = new System.Drawing.Size(144, 32);
            this.dataSourceLbl.TabIndex = 28;
            this.dataSourceLbl.Text = "Data Source";
            // 
            // pswdTxt
            // 
            this.pswdTxt.BackColor = System.Drawing.Color.Snow;
            this.pswdTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pswdTxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pswdTxt.Location = new System.Drawing.Point(137, 424);
            this.pswdTxt.Margin = new System.Windows.Forms.Padding(4);
            this.pswdTxt.MaxLength = 20;
            this.pswdTxt.Name = "pswdTxt";
            this.pswdTxt.PasswordChar = '*';
            this.pswdTxt.Size = new System.Drawing.Size(339, 39);
            this.pswdTxt.TabIndex = 4;
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.Snow;
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameTxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.usernameTxt.Location = new System.Drawing.Point(137, 338);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTxt.MaxLength = 20;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(339, 39);
            this.usernameTxt.TabIndex = 3;
            // 
            // dbLbl
            // 
            this.dbLbl.AutoSize = true;
            this.dbLbl.BackColor = System.Drawing.Color.Transparent;
            this.dbLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dbLbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dbLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dbLbl.Location = new System.Drawing.Point(129, 222);
            this.dbLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dbLbl.Name = "dbLbl";
            this.dbLbl.Size = new System.Drawing.Size(113, 32);
            this.dbLbl.TabIndex = 39;
            this.dbLbl.Text = "Database";
            // 
            // pswdLbl
            // 
            this.pswdLbl.AutoSize = true;
            this.pswdLbl.BackColor = System.Drawing.Color.Transparent;
            this.pswdLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pswdLbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pswdLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pswdLbl.Location = new System.Drawing.Point(129, 384);
            this.pswdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pswdLbl.Name = "pswdLbl";
            this.pswdLbl.Size = new System.Drawing.Size(112, 32);
            this.pswdLbl.TabIndex = 38;
            this.pswdLbl.Text = "Password";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameLbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.usernameLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usernameLbl.Location = new System.Drawing.Point(129, 302);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(122, 32);
            this.usernameLbl.TabIndex = 36;
            this.usernameLbl.Text = "Username";
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(613, 636);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Connection";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label dbLbl;
        private System.Windows.Forms.TextBox dbTxt;
        private System.Windows.Forms.TextBox dataSourceTxt;
        private System.Windows.Forms.Label dataSourceLbl;
        private System.Windows.Forms.Label pswdLbl;
        private System.Windows.Forms.TextBox pswdTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label label1;
    }
}
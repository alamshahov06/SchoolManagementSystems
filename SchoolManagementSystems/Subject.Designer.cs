namespace SchoolManagementSystems
{
    partial class Subject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subject));
            this.subjectLbl = new System.Windows.Forms.Label();
            this.subjectTxt = new System.Windows.Forms.TextBox();
            this.subjecErrLbl = new System.Windows.Forms.Label();
            this.detailGb = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.classCB = new System.Windows.Forms.ComboBox();
            this.classTxt = new System.Windows.Forms.Label();
            this.classErrLbl = new System.Windows.Forms.Label();
            this.SnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.detailGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(944, 55);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(409, 55);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Size = new System.Drawing.Size(74, 78);
            this.button1.TabIndex = 4;
            // 
            // titleLbl
            // 
            this.titleLbl.Size = new System.Drawing.Size(152, 48);
            this.titleLbl.Text = "Subjects";
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(409, 672);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(409, 78);
            // 
            // rightPanel
            // 
            this.rightPanel.Location = new System.Drawing.Point(409, 0);
            this.rightPanel.Size = new System.Drawing.Size(944, 672);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(944, 78);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.classCB);
            this.panel6.Controls.Add(this.subjectTxt);
            this.panel6.Controls.Add(this.subjectLbl);
            this.panel6.Controls.Add(this.subjecErrLbl);
            this.panel6.Controls.Add(this.classErrLbl);
            this.panel6.Controls.Add(this.classTxt);
            this.panel6.Location = new System.Drawing.Point(0, 78);
            this.panel6.Size = new System.Drawing.Size(409, 594);
            this.panel6.Controls.SetChildIndex(this.classTxt, 0);
            this.panel6.Controls.SetChildIndex(this.panel2, 0);
            this.panel6.Controls.SetChildIndex(this.classErrLbl, 0);
            this.panel6.Controls.SetChildIndex(this.subjecErrLbl, 0);
            this.panel6.Controls.SetChildIndex(this.subjectLbl, 0);
            this.panel6.Controls.SetChildIndex(this.subjectTxt, 0);
            this.panel6.Controls.SetChildIndex(this.classCB, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.detailGb);
            this.panel5.Location = new System.Drawing.Point(0, 78);
            this.panel5.Size = new System.Drawing.Size(944, 594);
            this.panel5.Controls.SetChildIndex(this.panel1, 0);
            this.panel5.Controls.SetChildIndex(this.detailGb, 0);
            // 
            // subjectLbl
            // 
            this.subjectLbl.AutoSize = true;
            this.subjectLbl.BackColor = System.Drawing.Color.Transparent;
            this.subjectLbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.subjectLbl.Location = new System.Drawing.Point(19, 91);
            this.subjectLbl.Name = "subjectLbl";
            this.subjectLbl.Size = new System.Drawing.Size(94, 32);
            this.subjectLbl.TabIndex = 1;
            this.subjectLbl.Text = "Subject";
            // 
            // subjectTxt
            // 
            this.subjectTxt.Location = new System.Drawing.Point(25, 126);
            this.subjectTxt.MaxLength = 15;
            this.subjectTxt.Name = "subjectTxt";
            this.subjectTxt.Size = new System.Drawing.Size(362, 39);
            this.subjectTxt.TabIndex = 1;
            this.subjectTxt.TextChanged += new System.EventHandler(this.subjectTxt_TextChanged);
            this.subjectTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subjectTxt_KeyPress);
            // 
            // subjecErrLbl
            // 
            this.subjecErrLbl.AutoSize = true;
            this.subjecErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.subjecErrLbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.subjecErrLbl.Location = new System.Drawing.Point(361, 101);
            this.subjecErrLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subjecErrLbl.Name = "subjecErrLbl";
            this.subjecErrLbl.Size = new System.Drawing.Size(25, 32);
            this.subjecErrLbl.TabIndex = 13;
            this.subjecErrLbl.Text = "*";
            this.subjecErrLbl.Visible = false;
            // 
            // detailGb
            // 
            this.detailGb.BackColor = System.Drawing.Color.White;
            this.detailGb.Controls.Add(this.dataGridView1);
            this.detailGb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailGb.ForeColor = System.Drawing.Color.Black;
            this.detailGb.Location = new System.Drawing.Point(0, 55);
            this.detailGb.Name = "detailGb";
            this.detailGb.Size = new System.Drawing.Size(944, 539);
            this.detailGb.TabIndex = 2;
            this.detailGb.TabStop = false;
            this.detailGb.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SnoGV,
            this.subjectIDGV,
            this.classGV,
            this.subjectGv});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 35);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(938, 501);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // classCB
            // 
            this.classCB.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classCB.FormattingEnabled = true;
            this.classCB.Location = new System.Drawing.Point(25, 208);
            this.classCB.MaxLength = 15;
            this.classCB.Name = "classCB";
            this.classCB.Size = new System.Drawing.Size(362, 37);
            this.classCB.TabIndex = 2;
            this.classCB.SelectedIndexChanged += new System.EventHandler(this.classCB_SelectedIndexChanged);
            // 
            // classTxt
            // 
            this.classTxt.AutoSize = true;
            this.classTxt.BackColor = System.Drawing.Color.Transparent;
            this.classTxt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.classTxt.Location = new System.Drawing.Point(19, 173);
            this.classTxt.Name = "classTxt";
            this.classTxt.Size = new System.Drawing.Size(109, 32);
            this.classTxt.TabIndex = 15;
            this.classTxt.Text = "Standard";
            // 
            // classErrLbl
            // 
            this.classErrLbl.AutoSize = true;
            this.classErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.classErrLbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.classErrLbl.Location = new System.Drawing.Point(361, 185);
            this.classErrLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classErrLbl.Name = "classErrLbl";
            this.classErrLbl.Size = new System.Drawing.Size(25, 32);
            this.classErrLbl.TabIndex = 16;
            this.classErrLbl.Text = "*";
            this.classErrLbl.Visible = false;
            // 
            // SnoGV
            // 
            this.SnoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SnoGV.HeaderText = "SNO";
            this.SnoGV.MinimumWidth = 8;
            this.SnoGV.Name = "SnoGV";
            this.SnoGV.ReadOnly = true;
            // 
            // subjectIDGV
            // 
            this.subjectIDGV.HeaderText = "Subject ID";
            this.subjectIDGV.MinimumWidth = 8;
            this.subjectIDGV.Name = "subjectIDGV";
            this.subjectIDGV.ReadOnly = true;
            this.subjectIDGV.Visible = false;
            // 
            // classGV
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.classGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.classGV.HeaderText = "Standard";
            this.classGV.MinimumWidth = 8;
            this.classGV.Name = "classGV";
            this.classGV.ReadOnly = true;
            this.classGV.Visible = false;
            // 
            // subjectGv
            // 
            this.subjectGv.HeaderText = "Subject";
            this.subjectGv.MinimumWidth = 8;
            this.subjectGv.Name = "subjectGv";
            this.subjectGv.ReadOnly = true;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 672);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Subject";
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.Subject_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.detailGb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox subjectTxt;
        private System.Windows.Forms.Label subjectLbl;
        private System.Windows.Forms.Label subjecErrLbl;
        private System.Windows.Forms.GroupBox detailGb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label classTxt;
        private System.Windows.Forms.ComboBox classCB;
        private System.Windows.Forms.Label classErrLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn classGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectGv;
    }
}
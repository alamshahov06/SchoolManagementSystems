namespace SchoolManagementSystems
{
    partial class Attendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            this.detailGb = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.atdDP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.stdCB = new System.Windows.Forms.ComboBox();
            this.sectionCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBttn = new System.Windows.Forms.Button();
            this.attendanceGV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atdIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 572);
            this.panel1.Size = new System.Drawing.Size(993, 17);
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.TabIndex = 7;
            // 
            // titleLbl
            // 
            this.titleLbl.Size = new System.Drawing.Size(201, 48);
            this.titleLbl.Text = "Attendance";
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(359, 664);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(993, 664);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(993, 75);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.saveBttn);
            this.panel6.Controls.Add(this.loadBtn);
            this.panel6.Controls.Add(this.sectionCB);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.stdCB);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.atdDP);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Size = new System.Drawing.Size(359, 589);
            this.panel6.Controls.SetChildIndex(this.panel2, 0);
            this.panel6.Controls.SetChildIndex(this.label1, 0);
            this.panel6.Controls.SetChildIndex(this.atdDP, 0);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.stdCB, 0);
            this.panel6.Controls.SetChildIndex(this.label3, 0);
            this.panel6.Controls.SetChildIndex(this.sectionCB, 0);
            this.panel6.Controls.SetChildIndex(this.loadBtn, 0);
            this.panel6.Controls.SetChildIndex(this.saveBttn, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.detailGb);
            this.panel5.Size = new System.Drawing.Size(993, 589);
            this.panel5.Controls.SetChildIndex(this.panel1, 0);
            this.panel5.Controls.SetChildIndex(this.detailGb, 0);
            // 
            // detailGb
            // 
            this.detailGb.BackColor = System.Drawing.Color.White;
            this.detailGb.Controls.Add(this.dataGridView1);
            this.detailGb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailGb.ForeColor = System.Drawing.Color.Black;
            this.detailGb.Location = new System.Drawing.Point(0, 0);
            this.detailGb.Name = "detailGb";
            this.detailGb.Size = new System.Drawing.Size(993, 572);
            this.detailGb.TabIndex = 4;
            this.detailGb.TabStop = false;
            this.detailGb.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendanceGV,
            this.SnoGV,
            this.atdIDGV,
            this.nameGv,
            this.stdIDGV,
            this.stdGv,
            this.clsIDGV,
            this.divIDGV,
            this.divGv,
            this.dateGv});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 35);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(987, 534);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(21, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Date";
            // 
            // atdDP
            // 
            this.atdDP.CustomFormat = "yyyy-MM-dd";
            this.atdDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.atdDP.Location = new System.Drawing.Point(27, 125);
            this.atdDP.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.atdDP.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.atdDP.Name = "atdDP";
            this.atdDP.Size = new System.Drawing.Size(311, 39);
            this.atdDP.TabIndex = 1;
            this.atdDP.Value = new System.DateTime(2020, 3, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(21, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Standard";
            // 
            // stdCB
            // 
            this.stdCB.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdCB.FormattingEnabled = true;
            this.stdCB.Location = new System.Drawing.Point(27, 215);
            this.stdCB.Name = "stdCB";
            this.stdCB.Size = new System.Drawing.Size(311, 37);
            this.stdCB.TabIndex = 2;
            // 
            // sectionCB
            // 
            this.sectionCB.FormattingEnabled = true;
            this.sectionCB.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.sectionCB.Location = new System.Drawing.Point(27, 306);
            this.sectionCB.Name = "sectionCB";
            this.sectionCB.Size = new System.Drawing.Size(311, 40);
            this.sectionCB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(21, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Division";
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.loadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loadBtn.FlatAppearance.BorderSize = 0;
            this.loadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Font = new System.Drawing.Font("Calibri", 18F);
            this.loadBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loadBtn.Location = new System.Drawing.Point(27, 376);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(311, 65);
            this.loadBtn.TabIndex = 4;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBttn
            // 
            this.saveBttn.BackColor = System.Drawing.Color.SteelBlue;
            this.saveBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBttn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveBttn.FlatAppearance.BorderSize = 0;
            this.saveBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.saveBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBttn.Font = new System.Drawing.Font("Calibri", 18F);
            this.saveBttn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveBttn.Location = new System.Drawing.Point(27, 461);
            this.saveBttn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBttn.Name = "saveBttn";
            this.saveBttn.Size = new System.Drawing.Size(311, 65);
            this.saveBttn.TabIndex = 5;
            this.saveBttn.Text = "Save";
            this.saveBttn.UseVisualStyleBackColor = false;
            this.saveBttn.Click += new System.EventHandler(this.saveBttn_Click);
            // 
            // attendanceGV
            // 
            this.attendanceGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.attendanceGV.FalseValue = "False";
            this.attendanceGV.HeaderText = "Attendance";
            this.attendanceGV.MinimumWidth = 8;
            this.attendanceGV.Name = "attendanceGV";
            this.attendanceGV.TrueValue = "True";
            this.attendanceGV.Width = 143;
            // 
            // SnoGV
            // 
            this.SnoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SnoGV.HeaderText = "Roll no.";
            this.SnoGV.MinimumWidth = 8;
            this.SnoGV.Name = "SnoGV";
            this.SnoGV.ReadOnly = true;
            this.SnoGV.Width = 130;
            // 
            // atdIDGV
            // 
            this.atdIDGV.HeaderText = "atdIDGV";
            this.atdIDGV.MinimumWidth = 8;
            this.atdIDGV.Name = "atdIDGV";
            this.atdIDGV.Visible = false;
            // 
            // nameGv
            // 
            this.nameGv.HeaderText = "Student";
            this.nameGv.MinimumWidth = 8;
            this.nameGv.Name = "nameGv";
            this.nameGv.ReadOnly = true;
            // 
            // stdIDGV
            // 
            this.stdIDGV.HeaderText = "stuIDGV";
            this.stdIDGV.MinimumWidth = 8;
            this.stdIDGV.Name = "stdIDGV";
            this.stdIDGV.Visible = false;
            // 
            // stdGv
            // 
            this.stdGv.HeaderText = "Standard";
            this.stdGv.MinimumWidth = 8;
            this.stdGv.Name = "stdGv";
            this.stdGv.ReadOnly = true;
            this.stdGv.Visible = false;
            // 
            // clsIDGV
            // 
            this.clsIDGV.HeaderText = "clsIDGV";
            this.clsIDGV.MinimumWidth = 8;
            this.clsIDGV.Name = "clsIDGV";
            this.clsIDGV.ReadOnly = true;
            this.clsIDGV.Visible = false;
            // 
            // divIDGV
            // 
            this.divIDGV.HeaderText = "divIDGV";
            this.divIDGV.MinimumWidth = 8;
            this.divIDGV.Name = "divIDGV";
            this.divIDGV.ReadOnly = true;
            this.divIDGV.Visible = false;
            // 
            // divGv
            // 
            this.divGv.HeaderText = "Division";
            this.divGv.MinimumWidth = 8;
            this.divGv.Name = "divGv";
            this.divGv.ReadOnly = true;
            this.divGv.Visible = false;
            // 
            // dateGv
            // 
            this.dateGv.HeaderText = "Date";
            this.dateGv.MinimumWidth = 8;
            this.dateGv.Name = "dateGv";
            this.dateGv.ReadOnly = true;
            this.dateGv.Visible = false;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 664);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.attendance_FormClosed);
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

        private System.Windows.Forms.GroupBox detailGb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker atdDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sectionCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox stdCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button saveBttn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn attendanceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn atdIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn divIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn divGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGv;
    }
}
namespace SchoolManagementSystems
{
    partial class Fees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fees));
            this.loadBtn = new System.Windows.Forms.Button();
            this.sectionCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stdCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.detailGb = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feesIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveBttn = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(0, 590);
            this.panel1.Size = new System.Drawing.Size(985, 10);
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            // 
            // titleLbl
            // 
            this.titleLbl.Size = new System.Drawing.Size(91, 48);
            this.titleLbl.Text = "Fees";
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(359, 675);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(985, 675);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(985, 75);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.saveBttn);
            this.panel6.Controls.Add(this.loadBtn);
            this.panel6.Controls.Add(this.sectionCB);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.stdCB);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Size = new System.Drawing.Size(359, 600);
            this.panel6.Controls.SetChildIndex(this.panel2, 0);
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
            this.panel5.Size = new System.Drawing.Size(985, 600);
            this.panel5.Controls.SetChildIndex(this.panel1, 0);
            this.panel5.Controls.SetChildIndex(this.detailGb, 0);
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
            this.loadBtn.Location = new System.Drawing.Point(27, 289);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(311, 65);
            this.loadBtn.TabIndex = 21;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // sectionCB
            // 
            this.sectionCB.FormattingEnabled = true;
            this.sectionCB.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.sectionCB.Location = new System.Drawing.Point(27, 219);
            this.sectionCB.MaxLength = 1;
            this.sectionCB.Name = "sectionCB";
            this.sectionCB.Size = new System.Drawing.Size(311, 40);
            this.sectionCB.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(21, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Select Division";
            // 
            // stdCB
            // 
            this.stdCB.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdCB.FormattingEnabled = true;
            this.stdCB.Location = new System.Drawing.Point(27, 128);
            this.stdCB.MaxLength = 10;
            this.stdCB.Name = "stdCB";
            this.stdCB.Size = new System.Drawing.Size(311, 37);
            this.stdCB.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select Standard";
            // 
            // detailGb
            // 
            this.detailGb.BackColor = System.Drawing.Color.White;
            this.detailGb.Controls.Add(this.dataGridView1);
            this.detailGb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailGb.ForeColor = System.Drawing.Color.Black;
            this.detailGb.Location = new System.Drawing.Point(0, 0);
            this.detailGb.Name = "detailGb";
            this.detailGb.Size = new System.Drawing.Size(985, 590);
            this.detailGb.TabIndex = 6;
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
            this.SnoGV,
            this.feesIDGV,
            this.stdIDGV,
            this.nameGv,
            this.stdGv,
            this.divGv,
            this.paidGV,
            this.remainGV,
            this.amountGV,
            this.statusGV});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 35);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(979, 552);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
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
            // feesIDGV
            // 
            this.feesIDGV.HeaderText = "feesID";
            this.feesIDGV.MinimumWidth = 8;
            this.feesIDGV.Name = "feesIDGV";
            this.feesIDGV.ReadOnly = true;
            this.feesIDGV.Visible = false;
            // 
            // stdIDGV
            // 
            this.stdIDGV.HeaderText = "stdID";
            this.stdIDGV.MinimumWidth = 8;
            this.stdIDGV.Name = "stdIDGV";
            this.stdIDGV.ReadOnly = true;
            this.stdIDGV.Visible = false;
            // 
            // nameGv
            // 
            this.nameGv.HeaderText = "Student";
            this.nameGv.MinimumWidth = 8;
            this.nameGv.Name = "nameGv";
            this.nameGv.ReadOnly = true;
            // 
            // stdGv
            // 
            this.stdGv.HeaderText = "Standard";
            this.stdGv.MinimumWidth = 8;
            this.stdGv.Name = "stdGv";
            this.stdGv.ReadOnly = true;
            this.stdGv.Visible = false;
            // 
            // divGv
            // 
            this.divGv.HeaderText = "Division";
            this.divGv.MinimumWidth = 8;
            this.divGv.Name = "divGv";
            this.divGv.ReadOnly = true;
            this.divGv.Visible = false;
            // 
            // paidGV
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.paidGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.paidGV.HeaderText = "Paid";
            this.paidGV.MaxInputLength = 5;
            this.paidGV.MinimumWidth = 8;
            this.paidGV.Name = "paidGV";
            // 
            // remainGV
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.remainGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.remainGV.HeaderText = "Remain";
            this.remainGV.MinimumWidth = 8;
            this.remainGV.Name = "remainGV";
            this.remainGV.ReadOnly = true;
            // 
            // amountGV
            // 
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.amountGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.amountGV.HeaderText = "Amount";
            this.amountGV.MinimumWidth = 8;
            this.amountGV.Name = "amountGV";
            this.amountGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.MinimumWidth = 8;
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
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
            this.saveBttn.Location = new System.Drawing.Point(27, 382);
            this.saveBttn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBttn.Name = "saveBttn";
            this.saveBttn.Size = new System.Drawing.Size(311, 65);
            this.saveBttn.TabIndex = 22;
            this.saveBttn.Text = "Save";
            this.saveBttn.UseVisualStyleBackColor = false;
            this.saveBttn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 675);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fees";
            this.Text = "Fees";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fees_FormClosed);
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

        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.ComboBox sectionCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox stdCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox detailGb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveBttn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn feesIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn divGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}
namespace SchoolManagementSystems
{
    partial class Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class));
            this.classTxt = new System.Windows.Forms.TextBox();
            this.classLbl = new System.Windows.Forms.Label();
            this.detailGb = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.feesTxt = new System.Windows.Forms.TextBox();
            this.SnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feesGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Size = new System.Drawing.Size(985, 55);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(409, 55);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.TabIndex = 4;
            // 
            // titleLbl
            // 
            this.titleLbl.Size = new System.Drawing.Size(161, 48);
            this.titleLbl.Text = "Standard";
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(409, 668);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(409, 75);
            // 
            // rightPanel
            // 
            this.rightPanel.Location = new System.Drawing.Point(409, 0);
            this.rightPanel.Size = new System.Drawing.Size(985, 668);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(985, 75);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label);
            this.panel6.Controls.Add(this.feesTxt);
            this.panel6.Controls.Add(this.classLbl);
            this.panel6.Controls.Add(this.classTxt);
            this.panel6.Size = new System.Drawing.Size(409, 593);
            this.panel6.Controls.SetChildIndex(this.classTxt, 0);
            this.panel6.Controls.SetChildIndex(this.classLbl, 0);
            this.panel6.Controls.SetChildIndex(this.feesTxt, 0);
            this.panel6.Controls.SetChildIndex(this.label, 0);
            this.panel6.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.detailGb);
            this.panel5.Size = new System.Drawing.Size(985, 593);
            this.panel5.Controls.SetChildIndex(this.panel1, 0);
            this.panel5.Controls.SetChildIndex(this.detailGb, 0);
            // 
            // classTxt
            // 
            this.classTxt.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classTxt.Location = new System.Drawing.Point(27, 104);
            this.classTxt.MaxLength = 10;
            this.classTxt.Name = "classTxt";
            this.classTxt.Size = new System.Drawing.Size(359, 37);
            this.classTxt.TabIndex = 1;
            this.classTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.classTxt_KeyPress);
            // 
            // classLbl
            // 
            this.classLbl.AutoSize = true;
            this.classLbl.BackColor = System.Drawing.Color.Transparent;
            this.classLbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.classLbl.Location = new System.Drawing.Point(21, 69);
            this.classLbl.Name = "classLbl";
            this.classLbl.Size = new System.Drawing.Size(109, 32);
            this.classLbl.TabIndex = 6;
            this.classLbl.Text = "Standard";
            // 
            // detailGb
            // 
            this.detailGb.BackColor = System.Drawing.Color.White;
            this.detailGb.Controls.Add(this.dataGridView1);
            this.detailGb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailGb.ForeColor = System.Drawing.Color.Black;
            this.detailGb.Location = new System.Drawing.Point(0, 55);
            this.detailGb.Name = "detailGb";
            this.detailGb.Size = new System.Drawing.Size(985, 538);
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SnoGV,
            this.classIDGV,
            this.classNameGv,
            this.feesGV});
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
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(979, 500);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label.Location = new System.Drawing.Point(22, 161);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(63, 32);
            this.label.TabIndex = 13;
            this.label.Text = "Fees";
            // 
            // feesTxt
            // 
            this.feesTxt.Location = new System.Drawing.Point(28, 196);
            this.feesTxt.MaxLength = 5;
            this.feesTxt.Name = "feesTxt";
            this.feesTxt.Size = new System.Drawing.Size(359, 39);
            this.feesTxt.TabIndex = 2;
            this.feesTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.feesTxt_KeyPress);
            // 
            // SnoGV
            // 
            this.SnoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SnoGV.HeaderText = "SNO";
            this.SnoGV.MinimumWidth = 8;
            this.SnoGV.Name = "SnoGV";
            this.SnoGV.ReadOnly = true;
            // 
            // classIDGV
            // 
            this.classIDGV.HeaderText = "Class ID";
            this.classIDGV.MinimumWidth = 8;
            this.classIDGV.Name = "classIDGV";
            this.classIDGV.ReadOnly = true;
            this.classIDGV.Visible = false;
            // 
            // classNameGv
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.classNameGv.DefaultCellStyle = dataGridViewCellStyle3;
            this.classNameGv.HeaderText = "Standard";
            this.classNameGv.MinimumWidth = 8;
            this.classNameGv.Name = "classNameGv";
            this.classNameGv.ReadOnly = true;
            // 
            // feesGV
            // 
            this.feesGV.HeaderText = "Fees";
            this.feesGV.MinimumWidth = 8;
            this.feesGV.Name = "feesGV";
            this.feesGV.ReadOnly = true;
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.ClientSize = new System.Drawing.Size(1394, 668);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Class";
            this.Text = "Standard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Class_FormClosed);
            this.Load += new System.EventHandler(this.Class_Load);
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
        private System.Windows.Forms.TextBox classTxt;
        private System.Windows.Forms.Label classLbl;
        private System.Windows.Forms.GroupBox detailGb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox feesTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn feesGV;
    }
}
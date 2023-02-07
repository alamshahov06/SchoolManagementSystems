namespace SchoolManagementSystems
{
    partial class Sections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sections));
            this.sectionLbl = new System.Windows.Forms.Label();
            this.sectionTxt = new System.Windows.Forms.TextBox();
            this.sectionsErrorLbl = new System.Windows.Forms.Label();
            this.classCB = new System.Windows.Forms.ComboBox();
            this.classLbl = new System.Windows.Forms.Label();
            this.classErrLbl = new System.Windows.Forms.Label();
            this.detailGb = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Size = new System.Drawing.Size(933, 55);
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
            this.titleLbl.Size = new System.Drawing.Size(145, 48);
            this.titleLbl.Text = "Division";
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(409, 674);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(409, 75);
            // 
            // rightPanel
            // 
            this.rightPanel.Location = new System.Drawing.Point(409, 0);
            this.rightPanel.Size = new System.Drawing.Size(933, 674);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(933, 75);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.classCB);
            this.panel6.Controls.Add(this.sectionTxt);
            this.panel6.Controls.Add(this.sectionLbl);
            this.panel6.Controls.Add(this.sectionsErrorLbl);
            this.panel6.Controls.Add(this.classErrLbl);
            this.panel6.Controls.Add(this.classLbl);
            this.panel6.Size = new System.Drawing.Size(409, 599);
            this.panel6.Controls.SetChildIndex(this.classLbl, 0);
            this.panel6.Controls.SetChildIndex(this.classErrLbl, 0);
            this.panel6.Controls.SetChildIndex(this.sectionsErrorLbl, 0);
            this.panel6.Controls.SetChildIndex(this.sectionLbl, 0);
            this.panel6.Controls.SetChildIndex(this.panel2, 0);
            this.panel6.Controls.SetChildIndex(this.sectionTxt, 0);
            this.panel6.Controls.SetChildIndex(this.classCB, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.detailGb);
            this.panel5.Size = new System.Drawing.Size(933, 599);
            this.panel5.Controls.SetChildIndex(this.panel1, 0);
            this.panel5.Controls.SetChildIndex(this.detailGb, 0);
            // 
            // sectionLbl
            // 
            this.sectionLbl.AutoSize = true;
            this.sectionLbl.BackColor = System.Drawing.Color.Transparent;
            this.sectionLbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.sectionLbl.Location = new System.Drawing.Point(20, 137);
            this.sectionLbl.Name = "sectionLbl";
            this.sectionLbl.Size = new System.Drawing.Size(171, 32);
            this.sectionLbl.TabIndex = 8;
            this.sectionLbl.Text = "Division Name";
            // 
            // sectionTxt
            // 
            this.sectionTxt.Location = new System.Drawing.Point(26, 171);
            this.sectionTxt.MaxLength = 1;
            this.sectionTxt.Name = "sectionTxt";
            this.sectionTxt.Size = new System.Drawing.Size(363, 39);
            this.sectionTxt.TabIndex = 1;
            this.sectionTxt.TextChanged += new System.EventHandler(this.sectionTxt_TextChanged);
            this.sectionTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sectionTxt_KeyPress);
            // 
            // sectionsErrorLbl
            // 
            this.sectionsErrorLbl.AutoSize = true;
            this.sectionsErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.sectionsErrorLbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.sectionsErrorLbl.Location = new System.Drawing.Point(363, 148);
            this.sectionsErrorLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectionsErrorLbl.Name = "sectionsErrorLbl";
            this.sectionsErrorLbl.Size = new System.Drawing.Size(25, 32);
            this.sectionsErrorLbl.TabIndex = 11;
            this.sectionsErrorLbl.Text = "*";
            this.sectionsErrorLbl.Visible = false;
            // 
            // classCB
            // 
            this.classCB.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classCB.FormattingEnabled = true;
            this.classCB.Location = new System.Drawing.Point(26, 257);
            this.classCB.MaxLength = 10;
            this.classCB.Name = "classCB";
            this.classCB.Size = new System.Drawing.Size(363, 37);
            this.classCB.TabIndex = 2;
            this.classCB.SelectedIndexChanged += new System.EventHandler(this.classCB_SelectedIndexChanged);
            // 
            // classLbl
            // 
            this.classLbl.AutoSize = true;
            this.classLbl.BackColor = System.Drawing.Color.Transparent;
            this.classLbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.classLbl.Location = new System.Drawing.Point(20, 222);
            this.classLbl.Name = "classLbl";
            this.classLbl.Size = new System.Drawing.Size(109, 32);
            this.classLbl.TabIndex = 14;
            this.classLbl.Text = "Standard";
            // 
            // classErrLbl
            // 
            this.classErrLbl.AutoSize = true;
            this.classErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.classErrLbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.classErrLbl.Location = new System.Drawing.Point(363, 232);
            this.classErrLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classErrLbl.Name = "classErrLbl";
            this.classErrLbl.Size = new System.Drawing.Size(25, 32);
            this.classErrLbl.TabIndex = 15;
            this.classErrLbl.Text = "*";
            this.classErrLbl.Visible = false;
            // 
            // detailGb
            // 
            this.detailGb.BackColor = System.Drawing.Color.White;
            this.detailGb.Controls.Add(this.dataGridView1);
            this.detailGb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailGb.ForeColor = System.Drawing.Color.Black;
            this.detailGb.Location = new System.Drawing.Point(0, 55);
            this.detailGb.Name = "detailGb";
            this.detailGb.Size = new System.Drawing.Size(933, 544);
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
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
            this.sectionIDGV,
            this.classGV,
            this.sectionGV});
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
            this.dataGridView1.Size = new System.Drawing.Size(927, 506);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SnoGV
            // 
            this.SnoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SnoGV.HeaderText = "SNO";
            this.SnoGV.MinimumWidth = 8;
            this.SnoGV.Name = "SnoGV";
            this.SnoGV.ReadOnly = true;
            // 
            // sectionIDGV
            // 
            this.sectionIDGV.HeaderText = "Section ID";
            this.sectionIDGV.MinimumWidth = 8;
            this.sectionIDGV.Name = "sectionIDGV";
            this.sectionIDGV.ReadOnly = true;
            this.sectionIDGV.Visible = false;
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
            // 
            // sectionGV
            // 
            this.sectionGV.HeaderText = "Division";
            this.sectionGV.MinimumWidth = 8;
            this.sectionGV.Name = "sectionGV";
            this.sectionGV.ReadOnly = true;
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 674);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sections";
            this.Text = "Division";
            this.Load += new System.EventHandler(this.Sections_Load);
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
        private System.Windows.Forms.Label sectionLbl;
        private System.Windows.Forms.TextBox sectionTxt;
        private System.Windows.Forms.Label sectionsErrorLbl;
        private System.Windows.Forms.ComboBox classCB;
        private System.Windows.Forms.Label classLbl;
        private System.Windows.Forms.Label classErrLbl;
        private System.Windows.Forms.GroupBox detailGb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn classGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionGV;
    }
}
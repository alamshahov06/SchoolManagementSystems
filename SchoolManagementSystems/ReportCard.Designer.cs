namespace SchoolManagementSystems
{
    partial class ReportCard
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
            this.detailGb = new System.Windows.Forms.GroupBox();
            this.leftPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 965);
            this.panel1.Size = new System.Drawing.Size(1565, 10);
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            // 
            // textBox1
            // 
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // titleLbl
            // 
            this.titleLbl.Location = new System.Drawing.Point(677, 11);
            this.titleLbl.Size = new System.Drawing.Size(211, 48);
            this.titleLbl.Text = "Report Card";
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(359, 1050);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1565, 1050);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1565, 75);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(359, 975);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.detailGb);
            this.panel5.Size = new System.Drawing.Size(1565, 975);
            this.panel5.Controls.SetChildIndex(this.panel1, 0);
            this.panel5.Controls.SetChildIndex(this.detailGb, 0);
            // 
            // detailGb
            // 
            this.detailGb.BackColor = System.Drawing.Color.White;
            this.detailGb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailGb.ForeColor = System.Drawing.Color.Black;
            this.detailGb.Location = new System.Drawing.Point(0, 0);
            this.detailGb.Name = "detailGb";
            this.detailGb.Size = new System.Drawing.Size(1565, 965);
            this.detailGb.TabIndex = 6;
            this.detailGb.TabStop = false;
            this.detailGb.Text = "Details";
            // 
            // ReportCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ReportCard";
            this.Text = "ReportCard";
            this.leftPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox detailGb;
    }
}
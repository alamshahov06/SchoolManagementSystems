namespace SchoolManagementSystems
{
    partial class Setting
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sNameTxt = new System.Windows.Forms.TextBox();
            this.saveBttn = new System.Windows.Forms.Button();
            this.brwsBtn = new System.Windows.Forms.Button();
            this.sAddressTxt = new System.Windows.Forms.RichTextBox();
            this.sLogoTxt = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.leftPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 965);
            this.panel1.Size = new System.Drawing.Size(1388, 10);
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
            this.titleLbl.Location = new System.Drawing.Point(621, 11);
            this.titleLbl.Size = new System.Drawing.Size(132, 48);
            this.titleLbl.Text = "Setting";
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(359, 1050);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1388, 1050);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1388, 75);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(359, 975);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.sLogoTxt);
            this.panel5.Controls.Add(this.sAddressTxt);
            this.panel5.Controls.Add(this.brwsBtn);
            this.panel5.Controls.Add(this.saveBttn);
            this.panel5.Controls.Add(this.sNameTxt);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.pictureBox);
            this.panel5.Size = new System.Drawing.Size(1388, 975);
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            this.panel5.Controls.SetChildIndex(this.pictureBox, 0);
            this.panel5.Controls.SetChildIndex(this.panel1, 0);
            this.panel5.Controls.SetChildIndex(this.label1, 0);
            this.panel5.Controls.SetChildIndex(this.label2, 0);
            this.panel5.Controls.SetChildIndex(this.label3, 0);
            this.panel5.Controls.SetChildIndex(this.sNameTxt, 0);
            this.panel5.Controls.SetChildIndex(this.saveBttn, 0);
            this.panel5.Controls.SetChildIndex(this.brwsBtn, 0);
            this.panel5.Controls.SetChildIndex(this.sAddressTxt, 0);
            this.panel5.Controls.SetChildIndex(this.sLogoTxt, 0);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(589, 55);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(210, 210);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(327, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "School Logo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(327, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "School Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(327, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "School Address :";
            // 
            // sNameTxt
            // 
            this.sNameTxt.Location = new System.Drawing.Point(540, 371);
            this.sNameTxt.MaxLength = 100;
            this.sNameTxt.Name = "sNameTxt";
            this.sNameTxt.Size = new System.Drawing.Size(312, 39);
            this.sNameTxt.TabIndex = 7;
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
            this.saveBttn.Location = new System.Drawing.Point(537, 613);
            this.saveBttn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBttn.Name = "saveBttn";
            this.saveBttn.Size = new System.Drawing.Size(311, 65);
            this.saveBttn.TabIndex = 8;
            this.saveBttn.Text = "Save";
            this.saveBttn.UseVisualStyleBackColor = false;
            this.saveBttn.Click += new System.EventHandler(this.saveBttn_Click);
            // 
            // brwsBtn
            // 
            this.brwsBtn.BackColor = System.Drawing.SystemColors.Menu;
            this.brwsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brwsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.brwsBtn.FlatAppearance.BorderSize = 0;
            this.brwsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.brwsBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.brwsBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brwsBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.brwsBtn.Location = new System.Drawing.Point(865, 310);
            this.brwsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.brwsBtn.Name = "brwsBtn";
            this.brwsBtn.Size = new System.Drawing.Size(82, 39);
            this.brwsBtn.TabIndex = 11;
            this.brwsBtn.Text = " Browse";
            this.brwsBtn.UseVisualStyleBackColor = false;
            this.brwsBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // sAddressTxt
            // 
            this.sAddressTxt.Location = new System.Drawing.Point(540, 442);
            this.sAddressTxt.MaxLength = 250;
            this.sAddressTxt.Name = "sAddressTxt";
            this.sAddressTxt.Size = new System.Drawing.Size(312, 121);
            this.sAddressTxt.TabIndex = 12;
            this.sAddressTxt.Text = "";
            // 
            // sLogoTxt
            // 
            this.sLogoTxt.Enabled = false;
            this.sLogoTxt.Location = new System.Drawing.Point(540, 310);
            this.sLogoTxt.Name = "sLogoTxt";
            this.sLogoTxt.Size = new System.Drawing.Size(312, 39);
            this.sLogoTxt.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1747, 1050);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sNameTxt;
        private System.Windows.Forms.Button saveBttn;
        private System.Windows.Forms.Button brwsBtn;
        private System.Windows.Forms.TextBox sLogoTxt;
        private System.Windows.Forms.RichTextBox sAddressTxt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
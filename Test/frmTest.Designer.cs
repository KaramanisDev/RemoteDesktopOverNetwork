namespace Test
{
    partial class frmTest
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
            this.btnSelect1 = new System.Windows.Forms.Button();
            this.btnSelect2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImg1 = new System.Windows.Forms.TextBox();
            this.txtImg2 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.tsCredits = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lblGithubLink = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.tsCredits.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect1
            // 
            this.btnSelect1.Location = new System.Drawing.Point(372, 21);
            this.btnSelect1.Name = "btnSelect1";
            this.btnSelect1.Size = new System.Drawing.Size(112, 20);
            this.btnSelect1.TabIndex = 0;
            this.btnSelect1.Text = "Select ...";
            this.btnSelect1.UseVisualStyleBackColor = true;
            this.btnSelect1.Click += new System.EventHandler(this.btnSelect1_Click);
            // 
            // btnSelect2
            // 
            this.btnSelect2.Location = new System.Drawing.Point(372, 49);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.Size = new System.Drawing.Size(112, 20);
            this.btnSelect2.TabIndex = 1;
            this.btnSelect2.Text = "Select ...";
            this.btnSelect2.UseVisualStyleBackColor = true;
            this.btnSelect2.Click += new System.EventHandler(this.btnSelect2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Image 2:";
            // 
            // txtImg1
            // 
            this.txtImg1.Location = new System.Drawing.Point(84, 21);
            this.txtImg1.Name = "txtImg1";
            this.txtImg1.ReadOnly = true;
            this.txtImg1.Size = new System.Drawing.Size(282, 20);
            this.txtImg1.TabIndex = 4;
            // 
            // txtImg2
            // 
            this.txtImg2.Location = new System.Drawing.Point(84, 49);
            this.txtImg2.Name = "txtImg2";
            this.txtImg2.ReadOnly = true;
            this.txtImg2.Size = new System.Drawing.Size(282, 20);
            this.txtImg2.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(229, 89);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(255, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(23, 89);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(200, 200);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 7;
            this.picBox.TabStop = false;
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(229, 118);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogs.Size = new System.Drawing.Size(255, 171);
            this.txtLogs.TabIndex = 8;
            // 
            // tsCredits
            // 
            this.tsCredits.BackColor = System.Drawing.SystemColors.Control;
            this.tsCredits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsCredits.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsCredits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.lblGithubLink});
            this.tsCredits.Location = new System.Drawing.Point(0, 301);
            this.tsCredits.Name = "tsCredits";
            this.tsCredits.Size = new System.Drawing.Size(506, 25);
            this.tsCredits.TabIndex = 49;
            this.tsCredits.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(108, 22);
            this.toolStripLabel1.Text = "Ilias Karamanis";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(103, 22);
            this.toolStripLabel2.Text = "Github Profile:";
            // 
            // lblGithubLink
            // 
            this.lblGithubLink.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGithubLink.ForeColor = System.Drawing.Color.Maroon;
            this.lblGithubLink.IsLink = true;
            this.lblGithubLink.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lblGithubLink.LinkColor = System.Drawing.Color.Maroon;
            this.lblGithubLink.Name = "lblGithubLink";
            this.lblGithubLink.Size = new System.Drawing.Size(232, 22);
            this.lblGithubLink.Text = "https://github.com/KaramanisWeb";
            this.lblGithubLink.Click += new System.EventHandler(this.lblGithubLink_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 326);
            this.Controls.Add(this.tsCredits);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtImg2);
            this.Controls.Add(this.txtImg1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect2);
            this.Controls.Add(this.btnSelect1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(522, 365);
            this.Name = "frmTest";
            this.Text = "Test Algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.tsCredits.ResumeLayout(false);
            this.tsCredits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect1;
        private System.Windows.Forms.Button btnSelect2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImg1;
        private System.Windows.Forms.TextBox txtImg2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.ToolStrip tsCredits;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel lblGithubLink;
    }
}


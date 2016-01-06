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
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
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
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 308);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtImg2);
            this.Controls.Add(this.txtImg1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect2);
            this.Controls.Add(this.btnSelect1);
            this.Name = "frmTest";
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
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
    }
}


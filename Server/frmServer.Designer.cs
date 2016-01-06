namespace Server
{
    partial class frmServer
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocalIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxScreens = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFrames = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUncomp = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pcbFrame = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCompRatio = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.tbDelay = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblNoAlgo = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblEfficRatio = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbMouse = new System.Windows.Forms.CheckBox();
            this.lblPercentOfIm = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblFramesNoAlgo = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 77);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(119, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(152, 77);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(119, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Local IP:";
            // 
            // txtLocalIP
            // 
            this.txtLocalIP.Location = new System.Drawing.Point(92, 18);
            this.txtLocalIP.Name = "txtLocalIP";
            this.txtLocalIP.ReadOnly = true;
            this.txtLocalIP.Size = new System.Drawing.Size(179, 20);
            this.txtLocalIP.TabIndex = 3;
            this.txtLocalIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port to Listen:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(92, 49);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(87, 20);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "5869";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Screen:";
            // 
            // cbxScreens
            // 
            this.cbxScreens.FormattingEnabled = true;
            this.cbxScreens.Location = new System.Drawing.Point(377, 17);
            this.cbxScreens.Name = "cbxScreens";
            this.cbxScreens.Size = new System.Drawing.Size(151, 21);
            this.cbxScreens.TabIndex = 7;
            this.cbxScreens.Text = " ( . . Screen . . )";
            this.cbxScreens.SelectedIndexChanged += new System.EventHandler(this.cbxScreens_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Client Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(374, 66);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(95, 16);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Disconected";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Statistics";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "____________________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Frames Sent:";
            // 
            // lblFrames
            // 
            this.lblFrames.AutoSize = true;
            this.lblFrames.Location = new System.Drawing.Point(98, 159);
            this.lblFrames.Name = "lblFrames";
            this.lblFrames.Size = new System.Drawing.Size(13, 13);
            this.lblFrames.TabIndex = 13;
            this.lblFrames.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "KBs Uns/ed:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "KBs Com/ed:";
            // 
            // lblUncomp
            // 
            this.lblUncomp.AutoSize = true;
            this.lblUncomp.Location = new System.Drawing.Point(98, 181);
            this.lblUncomp.Name = "lblUncomp";
            this.lblUncomp.Size = new System.Drawing.Size(13, 13);
            this.lblUncomp.TabIndex = 16;
            this.lblUncomp.Text = "0";
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Location = new System.Drawing.Point(98, 204);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(13, 13);
            this.lblComp.TabIndex = 17;
            this.lblComp.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(293, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Last Frame Sent";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(253, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "_________________________________________";
            // 
            // pcbFrame
            // 
            this.pcbFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbFrame.Location = new System.Drawing.Point(297, 152);
            this.pcbFrame.Name = "pcbFrame";
            this.pcbFrame.Size = new System.Drawing.Size(231, 144);
            this.pcbFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFrame.TabIndex = 20;
            this.pcbFrame.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Latest Logs:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(529, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "_________________________________________________________________________________" +
    "______";
            // 
            // lblCompRatio
            // 
            this.lblCompRatio.AutoSize = true;
            this.lblCompRatio.Location = new System.Drawing.Point(98, 226);
            this.lblCompRatio.Name = "lblCompRatio";
            this.lblCompRatio.Size = new System.Drawing.Size(21, 13);
            this.lblCompRatio.TabIndex = 24;
            this.lblCompRatio.Text = "0%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Com/ed Ratio:";
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(13, 380);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogs.Size = new System.Drawing.Size(513, 164);
            this.txtLogs.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 248);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Secs Needed:";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(98, 248);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(18, 13);
            this.lblSeconds.TabIndex = 27;
            this.lblSeconds.Text = "0s";
            // 
            // tbDelay
            // 
            this.tbDelay.LargeChange = 100;
            this.tbDelay.Location = new System.Drawing.Point(369, 96);
            this.tbDelay.Maximum = 6000;
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(164, 45);
            this.tbDelay.TabIndex = 28;
            this.tbDelay.TickFrequency = 250;
            this.tbDelay.ValueChanged += new System.EventHandler(this.tbDelay_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Delay MS:";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(350, 96);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(13, 13);
            this.lblDelay.TabIndex = 30;
            this.lblDelay.Text = "0";
            // 
            // lblNoAlgo
            // 
            this.lblNoAlgo.AutoSize = true;
            this.lblNoAlgo.Location = new System.Drawing.Point(130, 281);
            this.lblNoAlgo.Name = "lblNoAlgo";
            this.lblNoAlgo.Size = new System.Drawing.Size(13, 13);
            this.lblNoAlgo.TabIndex = 32;
            this.lblNoAlgo.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 281);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "KBs w/o Algorithm:";
            // 
            // lblEfficRatio
            // 
            this.lblEfficRatio.AutoSize = true;
            this.lblEfficRatio.Location = new System.Drawing.Point(130, 303);
            this.lblEfficRatio.Name = "lblEfficRatio";
            this.lblEfficRatio.Size = new System.Drawing.Size(21, 13);
            this.lblEfficRatio.TabIndex = 34;
            this.lblEfficRatio.Text = "0%";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 303);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Efficiency Ratio:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 259);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(271, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "____________________________________________";
            // 
            // cbMouse
            // 
            this.cbMouse.AutoSize = true;
            this.cbMouse.Location = new System.Drawing.Point(377, 43);
            this.cbMouse.Name = "cbMouse";
            this.cbMouse.Size = new System.Drawing.Size(98, 17);
            this.cbMouse.TabIndex = 36;
            this.cbMouse.Text = "Capture Mouse";
            this.cbMouse.UseVisualStyleBackColor = true;
            // 
            // lblPercentOfIm
            // 
            this.lblPercentOfIm.AutoSize = true;
            this.lblPercentOfIm.Location = new System.Drawing.Point(400, 305);
            this.lblPercentOfIm.Name = "lblPercentOfIm";
            this.lblPercentOfIm.Size = new System.Drawing.Size(21, 13);
            this.lblPercentOfIm.TabIndex = 38;
            this.lblPercentOfIm.Text = "0%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(301, 305);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "Percent Of Image:";
            // 
            // lblFramesNoAlgo
            // 
            this.lblFramesNoAlgo.AutoSize = true;
            this.lblFramesNoAlgo.Location = new System.Drawing.Point(130, 324);
            this.lblFramesNoAlgo.Name = "lblFramesNoAlgo";
            this.lblFramesNoAlgo.Size = new System.Drawing.Size(13, 13);
            this.lblFramesNoAlgo.TabIndex = 40;
            this.lblFramesNoAlgo.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 324);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(112, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "Frames w/o Algorithm:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(216, 124);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(55, 22);
            this.btnReset.TabIndex = 41;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 556);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblFramesNoAlgo);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblPercentOfIm);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cbMouse);
            this.Controls.Add(this.lblEfficRatio);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblNoAlgo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.lblCompRatio);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pcbFrame);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.lblUncomp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblFrames);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxScreens);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLocalIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDelay);
            this.Controls.Add(this.label20);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(556, 595);
            this.Name = "frmServer";
            this.Text = "Server : RemotePresentationOverNetwork";
            this.Load += new System.EventHandler(this.frmServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocalIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxScreens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFrames;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUncomp;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pcbFrame;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCompRatio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.TrackBar tbDelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label lblNoAlgo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblEfficRatio;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox cbMouse;
        private System.Windows.Forms.Label lblPercentOfIm;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblFramesNoAlgo;
        private System.Windows.Forms.Button btnReset;
    }
}


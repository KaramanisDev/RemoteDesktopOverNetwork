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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFrames = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUncomp = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pcbFrame = new System.Windows.Forms.PictureBox();
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
            this.cbAlgorithm = new System.Windows.Forms.CheckBox();
            this.cbStats = new System.Windows.Forms.CheckBox();
            this.cbLogs = new System.Windows.Forms.CheckBox();
            this.cbLastFrame = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tsCredits = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lblGithubLink = new System.Windows.Forms.ToolStripLabel();
            this.lblPacketDrop = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPacketDrop = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelay)).BeginInit();
            this.tsCredits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPacketDrop)).BeginInit();
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
            this.cbxScreens.Size = new System.Drawing.Size(103, 21);
            this.cbxScreens.TabIndex = 7;
            this.cbxScreens.Text = " ( . . Screen . . )";
            this.cbxScreens.SelectedIndexChanged += new System.EventHandler(this.cbxScreens_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 111);
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
            this.lblStatus.Location = new System.Drawing.Point(108, 109);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(95, 16);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Disconected";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "____________________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Frames Sent:";
            // 
            // lblFrames
            // 
            this.lblFrames.AutoSize = true;
            this.lblFrames.Location = new System.Drawing.Point(98, 171);
            this.lblFrames.Name = "lblFrames";
            this.lblFrames.Size = new System.Drawing.Size(13, 13);
            this.lblFrames.TabIndex = 13;
            this.lblFrames.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "KBs Uns/ed:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "KBs Com/ed:";
            // 
            // lblUncomp
            // 
            this.lblUncomp.AutoSize = true;
            this.lblUncomp.Location = new System.Drawing.Point(98, 193);
            this.lblUncomp.Name = "lblUncomp";
            this.lblUncomp.Size = new System.Drawing.Size(13, 13);
            this.lblUncomp.TabIndex = 16;
            this.lblUncomp.Text = "0";
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Location = new System.Drawing.Point(98, 216);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(13, 13);
            this.lblComp.TabIndex = 17;
            this.lblComp.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(286, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(301, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "_________________________________________________";
            // 
            // pcbFrame
            // 
            this.pcbFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbFrame.Location = new System.Drawing.Point(297, 165);
            this.pcbFrame.Name = "pcbFrame";
            this.pcbFrame.Size = new System.Drawing.Size(282, 166);
            this.pcbFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFrame.TabIndex = 20;
            this.pcbFrame.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 376);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(583, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "_________________________________________________________________________________" +
    "_______________";
            // 
            // lblCompRatio
            // 
            this.lblCompRatio.AutoSize = true;
            this.lblCompRatio.Location = new System.Drawing.Point(98, 238);
            this.lblCompRatio.Name = "lblCompRatio";
            this.lblCompRatio.Size = new System.Drawing.Size(21, 13);
            this.lblCompRatio.TabIndex = 24;
            this.lblCompRatio.Text = "0%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Com/ed Ratio:";
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(13, 393);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogs.Size = new System.Drawing.Size(566, 164);
            this.txtLogs.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Secs Needed:";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(98, 260);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(18, 13);
            this.lblSeconds.TabIndex = 27;
            this.lblSeconds.Text = "0s";
            // 
            // tbDelay
            // 
            this.tbDelay.LargeChange = 100;
            this.tbDelay.Location = new System.Drawing.Point(377, 43);
            this.tbDelay.Maximum = 6000;
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(207, 45);
            this.tbDelay.TabIndex = 28;
            this.tbDelay.TickFrequency = 250;
            this.tbDelay.ValueChanged += new System.EventHandler(this.tbDelay_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Delay MS:";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(350, 50);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(13, 13);
            this.lblDelay.TabIndex = 30;
            this.lblDelay.Text = "0";
            // 
            // lblNoAlgo
            // 
            this.lblNoAlgo.AutoSize = true;
            this.lblNoAlgo.Location = new System.Drawing.Point(130, 293);
            this.lblNoAlgo.Name = "lblNoAlgo";
            this.lblNoAlgo.Size = new System.Drawing.Size(13, 13);
            this.lblNoAlgo.TabIndex = 32;
            this.lblNoAlgo.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 293);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "KBs w/o Algorithm:";
            // 
            // lblEfficRatio
            // 
            this.lblEfficRatio.AutoSize = true;
            this.lblEfficRatio.Location = new System.Drawing.Point(130, 315);
            this.lblEfficRatio.Name = "lblEfficRatio";
            this.lblEfficRatio.Size = new System.Drawing.Size(21, 13);
            this.lblEfficRatio.TabIndex = 34;
            this.lblEfficRatio.Text = "0%";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 315);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Efficiency Ratio:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 271);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(271, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "____________________________________________";
            // 
            // cbMouse
            // 
            this.cbMouse.AutoSize = true;
            this.cbMouse.Location = new System.Drawing.Point(486, 19);
            this.cbMouse.Name = "cbMouse";
            this.cbMouse.Size = new System.Drawing.Size(98, 17);
            this.cbMouse.TabIndex = 36;
            this.cbMouse.Text = "Capture Mouse";
            this.cbMouse.UseVisualStyleBackColor = true;
            // 
            // lblPercentOfIm
            // 
            this.lblPercentOfIm.AutoSize = true;
            this.lblPercentOfIm.Location = new System.Drawing.Point(404, 336);
            this.lblPercentOfIm.Name = "lblPercentOfIm";
            this.lblPercentOfIm.Size = new System.Drawing.Size(21, 13);
            this.lblPercentOfIm.TabIndex = 38;
            this.lblPercentOfIm.Text = "0%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(305, 336);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "Percent Of Image:";
            // 
            // lblFramesNoAlgo
            // 
            this.lblFramesNoAlgo.AutoSize = true;
            this.lblFramesNoAlgo.Location = new System.Drawing.Point(130, 336);
            this.lblFramesNoAlgo.Name = "lblFramesNoAlgo";
            this.lblFramesNoAlgo.Size = new System.Drawing.Size(13, 13);
            this.lblFramesNoAlgo.TabIndex = 40;
            this.lblFramesNoAlgo.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 336);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(112, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "Frames w/o Algorithm:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(216, 136);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(55, 22);
            this.btnReset.TabIndex = 41;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbAlgorithm
            // 
            this.cbAlgorithm.AutoSize = true;
            this.cbAlgorithm.Checked = true;
            this.cbAlgorithm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlgorithm.ForeColor = System.Drawing.Color.Black;
            this.cbAlgorithm.Location = new System.Drawing.Point(297, 106);
            this.cbAlgorithm.Name = "cbAlgorithm";
            this.cbAlgorithm.Size = new System.Drawing.Size(134, 20);
            this.cbAlgorithm.TabIndex = 42;
            this.cbAlgorithm.Text = "Activate Algorithm";
            this.cbAlgorithm.UseVisualStyleBackColor = true;
            this.cbAlgorithm.CheckedChanged += new System.EventHandler(this.cbAlgorithm_CheckedChanged);
            // 
            // cbStats
            // 
            this.cbStats.AutoSize = true;
            this.cbStats.BackColor = System.Drawing.SystemColors.Control;
            this.cbStats.Checked = true;
            this.cbStats.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbStats.Location = new System.Drawing.Point(7, 136);
            this.cbStats.Name = "cbStats";
            this.cbStats.Size = new System.Drawing.Size(97, 24);
            this.cbStats.TabIndex = 43;
            this.cbStats.Text = "Statistics:";
            this.cbStats.UseVisualStyleBackColor = false;
            // 
            // cbLogs
            // 
            this.cbLogs.AutoSize = true;
            this.cbLogs.BackColor = System.Drawing.SystemColors.Control;
            this.cbLogs.Checked = true;
            this.cbLogs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbLogs.Location = new System.Drawing.Point(7, 364);
            this.cbLogs.Name = "cbLogs";
            this.cbLogs.Size = new System.Drawing.Size(116, 24);
            this.cbLogs.TabIndex = 44;
            this.cbLogs.Text = "Latest Logs:";
            this.cbLogs.UseVisualStyleBackColor = false;
            // 
            // cbLastFrame
            // 
            this.cbLastFrame.AutoSize = true;
            this.cbLastFrame.BackColor = System.Drawing.SystemColors.Control;
            this.cbLastFrame.Checked = true;
            this.cbLastFrame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLastFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbLastFrame.Location = new System.Drawing.Point(289, 136);
            this.cbLastFrame.Name = "cbLastFrame";
            this.cbLastFrame.Size = new System.Drawing.Size(147, 24);
            this.cbLastFrame.TabIndex = 45;
            this.cbLastFrame.Text = "Last Frame Sent";
            this.cbLastFrame.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(524, 364);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 22);
            this.btnClear.TabIndex = 46;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.tsCredits.Location = new System.Drawing.Point(0, 564);
            this.tsCredits.Name = "tsCredits";
            this.tsCredits.Size = new System.Drawing.Size(591, 25);
            this.tsCredits.TabIndex = 47;
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
            // lblPacketDrop
            // 
            this.lblPacketDrop.AutoSize = true;
            this.lblPacketDrop.Location = new System.Drawing.Point(421, 80);
            this.lblPacketDrop.Name = "lblPacketDrop";
            this.lblPacketDrop.Size = new System.Drawing.Size(21, 13);
            this.lblPacketDrop.TabIndex = 51;
            this.lblPacketDrop.Text = "0%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Packet Drop Simulation:";
            // 
            // tbPacketDrop
            // 
            this.tbPacketDrop.LargeChange = 10;
            this.tbPacketDrop.Location = new System.Drawing.Point(453, 74);
            this.tbPacketDrop.Maximum = 100;
            this.tbPacketDrop.Name = "tbPacketDrop";
            this.tbPacketDrop.Size = new System.Drawing.Size(131, 45);
            this.tbPacketDrop.TabIndex = 49;
            this.tbPacketDrop.TickFrequency = 10;
            this.tbPacketDrop.ValueChanged += new System.EventHandler(this.tbPacketDrop_ValueChanged);
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 589);
            this.Controls.Add(this.lblPacketDrop);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbPacketDrop);
            this.Controls.Add(this.tsCredits);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbLastFrame);
            this.Controls.Add(this.cbLogs);
            this.Controls.Add(this.cbStats);
            this.Controls.Add(this.cbAlgorithm);
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
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pcbFrame);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.lblUncomp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblFrames);
            this.Controls.Add(this.label8);
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
            this.MaximumSize = new System.Drawing.Size(607, 628);
            this.Name = "frmServer";
            this.Text = "Server : RemoteDesktopOverNetwork";
            this.Load += new System.EventHandler(this.frmServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelay)).EndInit();
            this.tsCredits.ResumeLayout(false);
            this.tsCredits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPacketDrop)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFrames;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUncomp;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pcbFrame;
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
        private System.Windows.Forms.CheckBox cbAlgorithm;
        private System.Windows.Forms.CheckBox cbStats;
        private System.Windows.Forms.CheckBox cbLogs;
        private System.Windows.Forms.CheckBox cbLastFrame;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStrip tsCredits;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel lblGithubLink;
        private System.Windows.Forms.Label lblPacketDrop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar tbPacketDrop;
    }
}


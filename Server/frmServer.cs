using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using RPON;
using RPON.Extensions;
using RPON.Packet;

namespace Server
{
    public partial class frmServer : Form
    {
        private Socket ServerSocket;
        private Socket withClient = null;
        private bool clientConnect = false;
        private int desktopSelected = 0;

        //Statistics
        private int frames = 0;
        private float kbsentuncomp = 0;
        private float kbsentcomp = 0;
        private float compratio = 0;
        private float secondstook = 0;
        private float withoutalgo = 0;
        private float effiratio = 0;
        private int framesnoalgo = 0;

        //ScreenChangeDetect
        ScreenChangeDetect SCD = new ScreenChangeDetect();

        private void ServerConnect(bool status)
        {
            btnStart.Enabled = !status;
            btnStop.Enabled = status;
            txtPort.Enabled = !status;

            try { 

                if (status)
                {

                    ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    ServerSocket.Bind(new IPEndPoint(0, int.Parse(txtPort.Text)));
                    ServerSocket.Listen(10);
                    Log("Server Started...");
                    Log("Begin Listening...On Port: " + txtPort.Text);
                    Log("Waiting for Client...");
                    ServerSocket.BeginAccept(BeginAccept_Callback, null);
                }
                else
                {
                    if (withClient != null && withClient.Connected)
                    {
                        withClient.Shutdown(SocketShutdown.Both);
                        withClient.Disconnect(false);
                        withClient = null;
                        ClientConnect(false);
                    }
                    if (ServerSocket != null)
                    {
                        ServerSocket.Close();
                        ServerSocket = null;
                    }
                    Log("Stopped Listening...");
                    Log("Server Stopped..");
                    Log("========================================================");
                }
            }
            catch (Exception ex)
            {
                //Log("Exception: " + ex.Message);
            }
        }

        private void ClientConnect(bool status)
        {
            if (status && !clientConnect)
            {
                Log("Client Connected");
                Log("Started Streaming Desktop Screen {"+(desktopSelected+1) +"}");
                lblStatus.Invoke((MethodInvoker) delegate
                {
                    lblStatus.Text = "Connected";
                    lblStatus.ForeColor = Color.LimeGreen;
                });
            }
            else if (!status && clientConnect)
            {
                Log("Client Disconnected");
                Log("Waiting for another Client...");
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = "Disconnected";
                    lblStatus.ForeColor = Color.Red;
                });
            }
            clientConnect = status;
        }

        private void UpdateStats(bool nf, float a,float b,long ms,float c)
        {
            int restPacketSize = 26;

            if (nf)
            {
                frames++;
                a += restPacketSize;
                b += restPacketSize;
            }

            framesnoalgo++;
            c += restPacketSize;

            kbsentcomp += a / 1024;
            kbsentuncomp += b / 1024;
            secondstook += (float)ms / 1000f;
            compratio = ((kbsentuncomp - kbsentcomp) / kbsentuncomp) * 100f;

            withoutalgo += c / 1024;
            effiratio = 100 - (kbsentcomp / withoutalgo) * 100f;
            
            this.safeInvoke((t =>
            {
                t.lblFrames.Text = frames.ToString();
                t.lblComp.Text = kbsentcomp.ToString();
                t.lblUncomp.Text = kbsentuncomp.ToString();
                t.lblSeconds.Text = secondstook.ToString();
                t.lblCompRatio.Text = compratio + "%";
                t.lblEfficRatio.Text = effiratio + "%";
                t.lblNoAlgo.Text = withoutalgo.ToString();
                t.lblFramesNoAlgo.Text = framesnoalgo.ToString();
            }));
        }

        private void BeginAccept_Callback(IAsyncResult ar)
        {
            try
            {
                withClient = ServerSocket.EndAccept(ar);
                SCD.Reset();
                while (withClient.Connected)
                {
                    Thread.Sleep(int.Parse(lblDelay.Text));

                    ClientConnect(true);
                    Stopwatch timeProcessed = Stopwatch.StartNew();
                    Rectangle bounds = Rectangle.Empty;

                    Data DT = new Data();

                    Bitmap NewIM = ScreenCapture.CaptureSelectedScreen(desktopSelected, cbMouse.Checked);
                    byte[] newIMdata = NewIM.ToByteArray(ImageFormat.Jpeg);

                    if (cbAlgorithm.Checked)
                    {

                        Bitmap imageChanged = SCD.Check(NewIM, ref bounds);

                        if (bounds != Rectangle.Empty)
                        {
                            pcbFrame.Image = (Bitmap) imageChanged.Clone();
                            this.Invoke((MethodInvoker) delegate
                            {
                                lblPercentOfIm.Text = SCD.PercentOfImage + "%";
                            });

                            byte[] imageDATA = imageChanged.ToByteArray(ImageFormat.Jpeg);
                            byte[] compImage = LZ4mm.LZ4Codec.Encode32(imageDATA, 0, imageDATA.Length);

                            DT.comp = true;
                            if (compImage.Length > imageDATA.Length)
                            {
                                DT.comp = false;
                                compImage = imageDATA;
                            }

                            DT.type = 1;
                            DT.dataSize = imageDATA.Length;
                            DT.dataBytes = compImage;
                            DT.bx = bounds.X;
                            DT.by = bounds.Y;
                            DT.bwidth = bounds.Width;
                            DT.bheight = bounds.Height;

                            UpdateStats(true, (float) compImage.Length, (float) imageDATA.Length,
                                timeProcessed.ElapsedMilliseconds, newIMdata.Length);
                            Log("Screen Sent Size Uncomp: " + (imageDATA.Length/1024) + "KB Comp: " +
                                (compImage.Length/1024) + " KB MS: " +
                                timeProcessed.ElapsedMilliseconds + " Rate: " +
                                (((float) imageDATA.Length - (float) compImage.Length)/(float) imageDATA.Length)*100f +
                                "%");
                        }
                        else
                        {
                            SCD.Reset();
                            UpdateStats(false, 0, 0, 0, newIMdata.Length);
                            Log("No Change Detected No Screen Sent");
                        }
                    }
                    else
                    {
                        SCD.Reset();

                        DT.type = 2;
                        DT.dataSize = newIMdata.Length;
                        DT.dataBytes = newIMdata;

                        UpdateStats(false, 0, 0, 0, newIMdata.Length);
                        Log("Full Screen Sent Size: " + (newIMdata.Length/1024) + " KB.");
                    }

                    byte[] Packet = DT.Serialize();
                    byte[] PacketSize = BitConverter.GetBytes(Packet.Length);

                    withClient.Send(PacketSize);
                    withClient.Send(Packet);

                    timeProcessed.Stop();
                }
            }
            catch (Exception ex)
            {
                //Log("Exception Thrown: " + ex.Message);
                ClientConnect(false);
            }
            if (withClient != null && ServerSocket != null)
                ServerSocket.BeginAccept(BeginAccept_Callback, null);
        }

        private void Log(string text)
        {
            txtLogs.safeInvoke(t =>
            {
                t.Text += text + Environment.NewLine;
                t.SelectionStart = txtLogs.TextLength;
                t.ScrollToCaret();
            });
        }

        public frmServer()
        {
            InitializeComponent();
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Screen.AllScreens.Count(); i++)
            {
                cbxScreens.Items.Add("Screen {" + (1 + i)+"}");
            }

            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    txtLocalIP.Text = ip.ToString();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ServerConnect(true);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ServerConnect(false);
        }

        private void cbxScreens_SelectedIndexChanged(object sender, EventArgs e)
        {
            desktopSelected = int.Parse(cbxScreens.SelectedIndex.ToString());
            Log("Desktop {"+(desktopSelected +1)+ "} selected to stream !");
        }

        private void tbDelay_ValueChanged(object sender, EventArgs e)
        {
            lblDelay.Text = tbDelay.Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frames = 0;
            kbsentuncomp = 0;
            kbsentcomp = 0;
            compratio = 0;
            secondstook = 0;
            withoutalgo = 0;
            effiratio = 0;
            framesnoalgo = 0;

            lblFrames.Text = frames.ToString();
            lblComp.Text = kbsentcomp.ToString();
            lblUncomp.Text = kbsentuncomp.ToString();
            lblSeconds.Text = secondstook.ToString();
            lblCompRatio.Text = compratio + "%";
            lblEfficRatio.Text = effiratio + "%";
            lblNoAlgo.Text = withoutalgo.ToString();
            lblFramesNoAlgo.Text = framesnoalgo.ToString();
        }

        private void cbAlgorithm_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAlgorithm.Checked)
            {
                Log("Screen Change Detection Algorithm Activated !");
            }
            else
            {
                Log("Screen Change Detection Algorithm Deactivated.");
            }
        }
    }
}

using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using RPON;
using RPON.Extensions;
using RPON.Packet;

namespace Client
{
    public partial class frmClient : Form
    {
        private Socket ClientSocket;
        private byte[] lengthBUFF = new byte[4];
        private bool firstImage = false;
        private Bitmap oldImage;
        private int FPS = 0;
        Stopwatch fpsCounter = new Stopwatch();

        public frmClient()
        {
            InitializeComponent();
        }

        private void Connect(bool status)
        {
            btnConnect.Enabled = !status;
            btnDisconnect.Enabled = status;
            txtPort.Enabled = !status;
            txtIP.Enabled = !status;
            try
            {
                if (status)
                {
                    ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    ClientSocket.Connect(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));
                    if (ClientSocket.Connected)
                    {
                        fpsCounter = Stopwatch.StartNew();
                        ClientSocket.BeginReceive(lengthBUFF, 0, lengthBUFF.Length, SocketFlags.None, Begin_Receive,null);
                    }
                }
                else
                {
                    if (ClientSocket != null && ClientSocket.Connected)
                    {
                        ClientSocket.Shutdown(SocketShutdown.Both);
                        ClientSocket.Disconnect(false);
                        ClientSocket = null;
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void Begin_Receive(IAsyncResult ar)
        {
            if (ClientSocket != null)
            {
                try
                {
                    ClientSocket.EndReceive(ar);
                    byte[] Header = lengthBUFF;
                    int length = BitConverter.ToInt32(Header, 0);
                    byte[] Payload = ReceiveData(length, ClientSocket);

                    if (Header.Length == 4 && Payload.Length == length)
                    {
                        Data DTU = Data.Desserialize(Payload);
                        if (DTU.type != 0)
                        {
                            Rectangle bounds = new Rectangle(DTU.bx, DTU.by, DTU.bwidth, DTU.bheight);
                            Image restoreIMG;

                            if (DTU.comp)
                            {
                                restoreIMG =
                                    LZ4mm.LZ4Codec.Decode32(DTU.dataBytes, 0, DTU.dataBytes.Length, DTU.dataSize)
                                        .toImage();
                            }
                            else
                            {
                                restoreIMG = DTU.dataBytes.toImage();
                            }

                            if (!firstImage)
                            {
                                oldImage = (Bitmap) restoreIMG;
                                firstImage = true;
                            }
                            else
                            {
                                Utils.UpdateScreen(ref oldImage, restoreIMG, bounds);
                            }

                            this.pictureBox1.Image = oldImage;

                            FPS++;
                            if (fpsCounter.ElapsedMilliseconds >= 1000)
                            {
                                this.Invoke(new MethodInvoker(() =>
                                {
                                    this.lblFPS.Text = FPS.ToString();
                                }));

                                FPS = 0;
                                fpsCounter = Stopwatch.StartNew();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Exception: " + ex.Message);
                }

                try
                {
                    if (ClientSocket.Connected)
                        ClientSocket.BeginReceive(lengthBUFF, 0, lengthBUFF.Length, SocketFlags.None, Begin_Receive,
                            null);
                }
                catch (Exception ex )
                {
                    Connect(false);
                    //MessageBox.Show("Exception: " + ex.Message);
                }
            }
        }

        private byte[] ReceiveData(int Length, Socket socket)
        {
            byte[] data = new byte[Length];
            int offset = 0;

            while (Length > 0)
            {
                int recv = socket.Receive(data, offset, Length, SocketFlags.None);

                if (recv <= 0)
                    return new byte[0];

                offset += recv;
                Length -= recv;
            }
            return data;
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    txtIP.Text = ip.ToString();
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect(true);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Connect(false);
        }
    }
}

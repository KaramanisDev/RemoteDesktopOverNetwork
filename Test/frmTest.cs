using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using RPON;

namespace Test
{
    public partial class frmTest : Form
    {
        public ScreenChangeDetect SCD = new ScreenChangeDetect(null);

        public void Log(string text)
        {
            txtLogs.Invoke((MethodInvoker)delegate
            {
                txtLogs.Text += text + Environment.NewLine;
                txtLogs.SelectionStart = txtLogs.TextLength;
                txtLogs.ScrollToCaret();
            });
        }

        public void selectImage(TextBox txtb)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            txtb.Text = ofd.FileName;
        }

        public frmTest()
        {
            InitializeComponent();
        }

        private void btnSelect1_Click(object sender, EventArgs e)
        {
            selectImage(txtImg1);
        }
        
        private void btnSelect2_Click(object sender, EventArgs e)
        {
            selectImage(txtImg2);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Bitmap oldIm = (Bitmap)Image.FromFile(txtImg1.Text).Clone();
            Bitmap newIm = (Bitmap)Image.FromFile(txtImg2.Text).Clone();
            Rectangle rect = Rectangle.Empty;

            SCD = new ScreenChangeDetect(this,oldIm);
            Bitmap imageChanged = SCD.Check(newIm, ref rect);
            picBox.Image = (Bitmap)imageChanged.Clone();
        }

        private void lblGithubLink_Click(object sender, EventArgs e)
        {
            Process.Start(lblGithubLink.Text);
        }
    }
}

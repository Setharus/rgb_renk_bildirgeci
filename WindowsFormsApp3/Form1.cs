using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class rValue : Form
    {
        public rValue()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            try {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Color c = bmp.GetPixel(e.X, e.Y);
                pictureBox2.BackColor = c;

                aValue.Text = c.A.ToString();
                rbValue.Text = c.R.ToString();
                gValue.Text = c.G.ToString();
                bValue.Text = c.B.ToString();
            }
            catch(Exception)
            { }
        }
    }
}

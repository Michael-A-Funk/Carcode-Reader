using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;

namespace SS_OpenCV
{
    public partial class ShowImgForm : Form
    {
        public ShowImgForm(Image<Bgr, byte> img1, Image<Bgr, byte> img2, Image<Bgr, byte> img3)
        {
            InitializeComponent();
            pictureBox1.Image = img1.Bitmap;
            pictureBox2.Image = img2.Bitmap;
            pictureBox3.Image = img3.Bitmap;
        }
    }
}

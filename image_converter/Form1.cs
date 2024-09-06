using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace image_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }
        Image image;
        private void btnselect_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files (.jpg)|*.jpg|(.png)|*.png|(.gif)|*.gif|(.ico)|*.ico";
            if (op.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(op.FileName);
            }
        }
        SaveFileDialog sv = new SaveFileDialog();
        private void Gif_Click(object sender, EventArgs e)
        {
            sv.ShowDialog();
            image.Save(sv.FileName + ".gif", System.Drawing.Imaging.ImageFormat.Gif);
        }
        private void Jpg_Click(object sender, EventArgs e)
        {
            sv.ShowDialog();
            image.Save(sv.FileName + ".Jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        private void Png_Click(object sender, EventArgs e)
        {
            sv.ShowDialog();
            image.Save(sv.FileName + ".Png", System.Drawing.Imaging.ImageFormat.Png);
        }
        private void Icon_Click(object sender, EventArgs e)
        {
            sv.ShowDialog();
            image.Save(sv.FileName + ".ico", System.Drawing.Imaging.ImageFormat.Icon);
        }
    }
}

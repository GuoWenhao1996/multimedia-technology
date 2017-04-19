using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imgchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            open();
            label_status.Text = "图片打开成功";
        }

        private void button_renew_Click(object sender, EventArgs e)
        {
            open();
            label_status.Text = "图片还原成功";
        }
       private void open()
        {
            pictureBox1.Image = Image.FromFile(@"E:\郭大神的作业\多媒体技术\第4节课-图像处理\task3-C#\imgchange\imgchange\resource\原图.bmp");

        }

        private void button_hdh_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    var color = bitmap.GetPixel(i,j);
                    var gray = (int)(color.R * 0.299 + color.G * 0.587 + color.B * 0.114);
                    bitmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            pictureBox1.Image = bitmap;
        }
    }
}

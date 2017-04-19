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
        string path = "";
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
            pictureBox1.Image = Image.FromFile(@path);
            label_status.Text = "图片还原成功";
        }
        private void open()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName;
            }
            pictureBox1.Image = Image.FromFile(@path);
        }

        private void button_hdh_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("请先打开图片！", "错误！");
            }
            else {
                Bitmap bitmap = new Bitmap(pictureBox1.Image);
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        var color = bitmap.GetPixel(i, j);
                        var gray = (int)(color.R * 0.299 + color.G * 0.587 + color.B * 0.114);
                        bitmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                    }
                }
                pictureBox1.Image = bitmap;
                label_status.Text = "图片灰度化成功";
            }
        }

        private void button_msk_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("请先打开图片！", "错误！");
            }
            else {
                int effectWidth = (int)numericUpDown_msk.Value;
                Bitmap bitmap = new Bitmap(pictureBox1.Image);
                for (int heightOfffset = 0; heightOfffset < bitmap.Height; heightOfffset += effectWidth)
                {
                    for (int widthOffset = 0; widthOffset < bitmap.Width; widthOffset += effectWidth)
                    {
                        int avgR = 0, avgG = 0, avgB = 0;
                        int blurPixelCount = 0;

                        for (int x = widthOffset; (x < widthOffset + effectWidth && x < bitmap.Width); x++)
                        {
                            for (int y = heightOfffset; (y < heightOfffset + effectWidth && y < bitmap.Height); y++)
                            {
                                System.Drawing.Color pixel = bitmap.GetPixel(x, y);

                                avgR += pixel.R;
                                avgG += pixel.G;
                                avgB += pixel.B;

                                blurPixelCount++;
                            }
                        }
                        // 计算范围平均
                        avgR = avgR / blurPixelCount;
                        avgG = avgG / blurPixelCount;
                        avgB = avgB / blurPixelCount;
                        // 所有范围内都设定此值
                        for (int x = widthOffset; (x < widthOffset + effectWidth && x < bitmap.Width); x++)
                        {
                            for (int y = heightOfffset; (y < heightOfffset + effectWidth && y < bitmap.Height); y++)
                            {
                                System.Drawing.Color newColor = System.Drawing.Color.FromArgb(avgR, avgG, avgB);
                                bitmap.SetPixel(x, y, newColor);
                            }
                        }

                    }
                }
                pictureBox1.Image = bitmap;
                label_status.Text = "图片马赛克成功";
            }
        }

        private void button_byc_cz_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("请先打开图片！", "错误！");
            }
            else {
                Bitmap MyBitmap = (Bitmap)this.pictureBox1.Image.Clone();
                int dw = MyBitmap.Width / 30;
                int dh = MyBitmap.Height;
                Graphics g = this.pictureBox1.CreateGraphics();
                g.Clear(Color.Gray);
                Point[] MyPoint = new Point[30];
                for (int x = 0; x < 30; x++)
                {
                    MyPoint[x].Y = 0;
                    MyPoint[x].X = x * dw;
                }
                Bitmap bitmap = new Bitmap(MyBitmap.Width, MyBitmap.Height);
                for (int i = 0; i < dw; i++)
                {
                    for (int j = 0; j < 30; j++)
                    {
                        for (int k = 0; k < dh; k++)
                        {
                            bitmap.SetPixel(MyPoint[j].X + i, MyPoint[j].Y + k, MyBitmap.GetPixel(MyPoint[j].X + i, MyPoint[j].Y + k));
                        }
                    }
                    this.pictureBox1.Refresh();
                    this.pictureBox1.Image = bitmap;
                    System.Threading.Thread.Sleep(100);
                }
                label_status.Text = "图片垂直百叶窗成功";
            }
        }

        private void button_byc_sp_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("请先打开图片！", "错误！");
            }
            else {
                Bitmap MyBitmap = (Bitmap)this.pictureBox1.Image.Clone();
                int dh = MyBitmap.Height / 20;
                int dw = MyBitmap.Width;
                Graphics g = this.pictureBox1.CreateGraphics();
                g.Clear(Color.Gray);
                Point[] MyPoint = new Point[20];
                for (int y = 0; y < 20; y++)
                {
                    MyPoint[y].X = 0;
                    MyPoint[y].Y = y * dh;
                }
                Bitmap bitmap = new Bitmap(MyBitmap.Width, MyBitmap.Height);
                for (int i = 0; i < dh; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        for (int k = 0; k < dw; k++)
                        {
                            bitmap.SetPixel(MyPoint[j].X + k, MyPoint[j].Y + i, MyBitmap.GetPixel(MyPoint[j].X + k, MyPoint[j].Y + i));
                        }
                    }
                    this.pictureBox1.Refresh();
                    this.pictureBox1.Image = bitmap;
                    System.Threading.Thread.Sleep(100);
                }
                label_status.Text = "图片水平百叶窗成功";
            }
        }
    }
}

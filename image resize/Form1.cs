using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using image_resize.Properties;
using System.Drawing.Imaging;
using System.IO;

namespace image_resize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            property_inputdir.Text = Settings.Default.inputdir;
            property_outputdir.Text = Settings.Default.outputdir;
            property_width.Value = Settings.Default.width;
            property_height.Value = Settings.Default.height;
            property_check_filesizelimit.Checked = Settings.Default.issizelimit;
            property_filesizelimit.Value = Settings.Default.sizelimit;
            property_check_aspect.Checked = Settings.Default.fixedaspect;
            property_check_rotate.Checked = Settings.Default.autorotation;
            colorcombo_Initialize();
            colorcombo.SelectedIndex = colorcombo.Items.IndexOf(Settings.Default.bgcolor.ToKnownColor().ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                property_inputdir.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                property_outputdir.Text = folderBrowserDialog1.SelectedPath;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.inputdir = property_inputdir.Text;
            Settings.Default.outputdir = property_outputdir.Text;
            Settings.Default.width = (int)property_width.Value;
            Settings.Default.height = (int)property_height.Value;
            Settings.Default.issizelimit = property_check_filesizelimit.Checked;
            Settings.Default.sizelimit = (int)property_filesizelimit.Value;
            Settings.Default.fixedaspect = property_check_aspect.Checked;
            Settings.Default.autorotation = property_check_rotate.Checked;
            Settings.Default.bgcolor = Color.FromName(colorcombo.SelectedItem.ToString());
            Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, j, num = 0, cnt = 0;
            string fn, opath = property_outputdir.Text + "\\";
            button3.Enabled = false;

            string[][] fs = {
                System.IO.Directory.GetFiles(property_inputdir.Text, "*.jpg", System.IO.SearchOption.TopDirectoryOnly),
                System.IO.Directory.GetFiles(property_inputdir.Text, "*.bmp", System.IO.SearchOption.TopDirectoryOnly),
                System.IO.Directory.GetFiles(property_inputdir.Text, "*.png", System.IO.SearchOption.TopDirectoryOnly),
            };

            for (i = 0; i < fs.Length; i++) num += fs[i].Length;
            if (num == 0) addlist("INFO: Target file not exist.");

            for (i = 0; i < fs.Length; i++)
                for (j = 0; j < fs[i].Length; j++)
                {
                    fn = fs[i][j].Substring(fs[i][j].LastIndexOf("\\") + 1);
                    fn = fn.Substring(0, fn.LastIndexOf("."));
                    while (System.IO.File.Exists(opath + fn + ".jpg")) fn += "_";
                    fn += ".jpg";
                    addlist("[" + ++cnt + "/" + num + "] " + fn);
                    transImage(fs[i][j], opath + fn);
                }

            button3.Enabled = true;
        }
        private void transImage(string input, string output)
        {
            using (Bitmap img = new Bitmap(input))
            using (Bitmap img2 = new Bitmap((int)property_width.Value, (int)property_height.Value))
            {
                float ratio, ratio2;
                float x = 0, y = 0, w = img2.Width, h = img2.Height;

                if (img.Width < 1) return;
                if (img.Height < 1) return;
                ratio = (float)img.Height / img.Width;
                ratio2 = (float)img2.Height / img2.Width;

                if (((ratio - 1) * (ratio2 - 1) < 0) && property_check_rotate.Checked)
                {
                    addlist("Image rotation");
                    img.RotateFlip((ratio < 1) ? RotateFlipType.Rotate90FlipNone : RotateFlipType.Rotate270FlipNone);
                    ratio = (float)img.Height / img.Width;
                }
                if (property_check_aspect.Checked)
                {
                    ImgFitting(ratio, ratio2, img2.Width, img2.Height, ref x, ref y, ref  w, ref h);
                }
                using (Graphics g = Graphics.FromImage(img2))
                {
                    g.Clear(Color.FromName(colorcombo.SelectedItem.ToString()));
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(img, x, y, w, h);
                }

                if (property_check_filesizelimit.Checked)
                {
                    SizeLimitedSave(img2, output, (int)property_filesizelimit.Value);
                }
                else
                {
                    using (EncoderParameters encps = new EncoderParameters(1))
                    using (encps.Param[0] = new EncoderParameter(Encoder.Quality, 100L))
                        img2.Save(output, GetEncoder(ImageFormat.Jpeg), encps);
                }
            }
        }

        private void ImgFitting(float Ratio1, float Ratio2, int limWidth, int limHeight, ref float PosX, ref float PosY, ref float Width, ref float Height)
        {   // Ratio = Height / Width
            float Ratio = Ratio1;
            if ((Ratio1 - 1) * (Ratio2 - 1) < 0)
            {
                Ratio1 = Ratio2;
                Ratio2 = Ratio;
            }
            if (Ratio1 < Ratio2)
            {
                Width = limHeight / Ratio;
                Height = limHeight;
                PosX = (limWidth - Width) / 2;
                PosY = 0;
            }
            else
            {
                Width = limWidth;
                Height = limWidth * Ratio;
                PosX = 0;
                PosY = (limHeight - Height) / 2;
            }
        }

        private void SizeLimitedSave(Bitmap img, string output, int size_KB)
        {
            long level = 100L;
            bool process = true;
            MemoryStream memstream;
            FileStream outstream;
            ImageCodecInfo jpeg = GetEncoder(ImageFormat.Jpeg);
            using (EncoderParameters encp = new EncoderParameters(1))
                while (process)
                {
                    using (memstream = new MemoryStream())
                    using (encp.Param[0] = new EncoderParameter(Encoder.Quality, level))
                    {
                        img.Save(memstream, jpeg, encp);
                        if ((int)memstream.Length < size_KB * 1024)
                        {
                            using (outstream = new FileStream(output, FileMode.Create))
                                memstream.WriteTo(outstream);
                            process = false;
                        }
                        else
                        {
                            addlist("FileSize over (" + (memstream.Length / 1024).ToString() + "KB) at compression level " + level);
                        }
                        if (--level == 0) process = false;
                    }
                }
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid) return codec;
            }
            return null;
        }

        private void addlist(string msg)
        {
            listBox1.Items.Add(msg);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            Application.DoEvents();
        }

        private void property_width_Enter(object sender, EventArgs e)
        {
            property_width.Select(0, property_width.Value.ToString().Length);
        }

        private void property_height_Enter(object sender, EventArgs e)
        {
            property_height.Select(0, property_height.Value.ToString().Length);
        }

        private void property_filesizelimit_Enter(object sender, EventArgs e)
        {
            property_filesizelimit.Select(0, property_filesizelimit.Value.ToString().Length);
        }

        private void colorcombo_Initialize()
        {
            colorcombo.BeginUpdate();
            colorcombo.Items.Clear();
            foreach(KnownColor k in Enum.GetValues(typeof(KnownColor))){
                colorcombo.Items.Add(k.ToString());
            }
            colorcombo.EndUpdate();
        }

        private void colorcombo_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle b = e.Bounds;
            String name = colorcombo.Items[e.Index].ToString();
            e.DrawBackground();
            Rectangle cb = new Rectangle(b.X + 4, b.Y + 2, 32, b.Height - 4);
            g.FillRectangle(new SolidBrush(Color.FromName(name)), cb);
            g.DrawRectangle(Pens.Black, cb);
            g.DrawString(name, e.Font, Brushes.Black, b.X + 40, b.Y + 1);
            e.DrawFocusRectangle();
        }
    }
}
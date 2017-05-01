using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Digdes_konverter
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        private void convert_button_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(pictureB.Image);
            string file = "convert_image.txt";
            float maxBr, minBr, Br;
            maxBr = minBr = b.GetPixel(0, 0).GetBrightness();

            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    Br = b.GetPixel(x, y).GetBrightness();
                    if (maxBr < Br)
                    {
                        maxBr = Br;
                    }
                    else if (minBr > Br)
                    {
                        minBr = Br;
                    }
                }
            }
            float step = (maxBr - minBr) / 9;

            if (File.Exists(file))
            {
                File.Delete(file);
            }

            using (StreamWriter f= new StreamWriter(file, true, Encoding.ASCII))
            {
                for (int y = 0; y < b.Height; y++)
                {
                    for (int x = 0; x < b.Width; x++)
                    {
                        Br = b.GetPixel(x, y).GetBrightness();
                        if (Br < minBr + step) f.Write('#');
                        else if (Br < minBr + 2 * step) f.Write('@');
                        else if (Br < minBr + 3 * step) f.Write('&');
                        else if (Br < minBr + 4 * step) f.Write('%');
                        else if (Br < minBr + 5 * step) f.Write('/');
                        else if (Br < minBr + 6 * step) f.Write(':');
                        else if (Br < minBr + 7 * step) f.Write(',');
                        else if (Br < minBr + 8 * step) f.Write('.');
                        else f.Write(' ');
                    }
                    f.WriteLine();
                }
            }
            Process.Start("explorer.exe", "/select, \"" + file + "\""); 
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog_image.ShowDialog() == DialogResult.OK)
            {
                pictureB.Image = Image.FromFile(openFileDialog_image.FileName);
                pictureB.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}

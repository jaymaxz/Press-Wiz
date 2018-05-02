using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ImageForm : Form
    {
        string FileName;

        public ImageForm()
        {
            InitializeComponent();
            CalButton.Enabled = false;
        }

        private void CalButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)Image.FromFile(FileName);
            //Used for tally
            int r = 0; //white pixels
            int g = 0; //Black pixelx

            int total = 0;

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    if(Color.FromArgb(255,255,255) == bmp.GetPixel(x,y))
                    {
                        r++;
                    }
                    if(Color.FromArgb(0,0,0) == bmp.GetPixel(x,y))
                    {
                        g++;
                    }
                    total++;
                }
            }
            White.Text = (r*100 / total).ToString();
            Black.Text = (g*100 / total).ToString();
            Colour.Text = (100 - ((r + g)*100 / total)).ToString();
        }

        private void Openbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                Picture.ImageLocation = FileName;
                CalButton.Enabled = true;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

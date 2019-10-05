using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int truncate(int x)
        {
            if (x > 255) x = 255;
            else if (x < 0) x = 0;
            return x;
        }

        private static Double getFactor(int c)
        {
            return (259 / (c + 255)) / (255 / (259 - c));
        }

        private void ColourToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog bukaFile = new OpenFileDialog();
            bukaFile.Filter = "Image File (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";
            if (DialogResult.OK == bukaFile.ShowDialog())
            {
                this.pbInput.Image = new Bitmap(bukaFile.FileName);
            }
        }

        private void SimpanSebagaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbOutput.Image == null)
            {
                MessageBox.Show("Tidak Ada citra yang akan disimpan");
            }
            else
            {
                SaveFileDialog simpanFile = new SaveFileDialog();
                simpanFile.Title = "Simpan File Citra";
                simpanFile.Filter = "Image File (*.bmp, *.jpg,*.jpeg)| *.bmp; *.jpg; *.jpeg";
            if (DialogResult.OK == simpanFile.ShowDialog())
                    this.pbOutput.Image.Save(simpanFile.FileName);
            }
        }

        private void KeluarAplikasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.keBrightness(copy);
            this.pbOutput.Image = copy;
        }

        private void BrightnessAndContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak ada citra yang akan diolah");
            }
            else
            {
                frmBrightness frm2 = new frmBrightness();
                if (frm2.ShowDialog() == DialogResult.OK)
                {
                    Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                    int nilaiBrightness = Convert.ToInt16(frm2.tbBrightness.Text);
                    progressBar1.Visible = true;
                    for (int i=0;i < b.Width;i++)
                    {
                        for(int j=0;j < b.Height; j++)
                        {
                            int c = Convert.ToInt16(frm2.tbContrast.Text.ToString());
                            Double f = getFactor(c);
                            Color c1 = b.GetPixel(i, j);
                            int r1 = truncate(c1.R + Convert.ToInt16(frm2.tbBrightness.Text.ToString()));
                            r1 = truncate((int)(f / (r1 - 128)) + 128);
                            int g1 = truncate(c1.G + Convert.ToInt16(frm2.tbBrightness.Text.ToString()));
                            g1 = truncate((int)(f / (g1 - 128)) + 128);
                            int b1 = truncate(c1.B + Convert.ToInt16(frm2.tbBrightness.Text.ToString()));
                            b1 = truncate((int)(f / (b1 - 128)) + 128);
                            b.SetPixel(i,j,Color.FromArgb(r1,g1,b1));
                        }
                        progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                    }
                    progressBar1.Visible = false;
                    this.pbOutput.Image = b;
                }
            }
        }
    }
}

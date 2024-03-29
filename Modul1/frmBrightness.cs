﻿using System;
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
    public partial class frmBrightness : Form
    {
        public frmBrightness()
        {
            InitializeComponent();
        }

        private void HScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            tbBrightness.Text = hscBrightness.Value.ToString();
        }

        private void HScrollBar1_ValueChanged_1(object sender, EventArgs e)
        {
            tbContrast.Text = hscContrast.Value.ToString();
        }

        private void FrmBrightness_Load(object sender, EventArgs e)
        {
            tbBrightness.Text = hscBrightness.Value.ToString();
            tbContrast.Text = hscContrast.Value.ToString();
        }

        private void TbBrightness_TextChanged(object sender, EventArgs e)
        {
            if ((tbBrightness.Text == "") || (tbBrightness.Text == "-"))
            {
                hscBrightness.Value = 0;
                tbBrightness.Text = "0";
            }
            else if ((Convert.ToInt16(tbBrightness.Text) <= 127) &&
            (Convert.ToInt16(tbBrightness.Text) >= -127))
            {
                hscBrightness.Value = Convert.ToInt16(tbBrightness.Text);
            }
            else
            {
                MessageBox.Show("Input nilai Error");
                tbBrightness.Text = "0";
            }
        }

        private void TbContrast_TextChanged(object sender, EventArgs e)
        {
            if ((tbContrast.Text == "") || (tbContrast.Text == "-"))
            {
                hscContrast.Value = 0;
                tbContrast.Text = "0";
            }
            else if ((Convert.ToInt16(tbContrast.Text) <= 127) &&
            (Convert.ToInt16(tbContrast.Text) >= -127))
            {
                hscContrast.Value = Convert.ToInt16(tbContrast.Text);
            }
            else
            {
                MessageBox.Show("Input nilai Error");
                tbContrast.Text = "0";
            }
        }

        private void TbOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

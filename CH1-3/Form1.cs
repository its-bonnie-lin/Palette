using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void hsbR_Scroll(object sender, ScrollEventArgs e)
        {
            lblRGB.Text = ("RGB(" + hsbR.Value + "," + hsbG.Value + "," + hsbB.Value + ")");
            lblShow.BackColor = Color.FromArgb(hsbR.Value, hsbG.Value, hsbB.Value);
        }

        private void llblPaint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Windows/system32/mspaint.exe");
        }

        private void llblColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.toodoo.com/db/color.html");
        }
    }
}

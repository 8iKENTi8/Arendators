using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            uC_Inbox1.BringToFront();
        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 118, b.Location.Y - 30);
            imgSlide.SendToBack();
        }
        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_Inbox1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            руководители1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            договора1.BringToFront();
        }
    }
}

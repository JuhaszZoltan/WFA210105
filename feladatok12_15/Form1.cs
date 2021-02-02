using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTunjEl_Click(object sender, EventArgs e)
        {
            pbSmiley.Visible = false;
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            pbSmiley.Visible = true;
        }

        Random rnd = new Random();
        private void tbKedvencSzo_TextChanged(object sender, EventArgs e)
        {
            if (tbKedvencSzo.Text == "")
            {
                tbKedvencSzo.BackColor = Color.White;
            }
            else
            {
                tbKedvencSzo.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            }
        }

        private void pbSmiley_Click(object sender, EventArgs e)
        {
            pbSmiley.Location = new Point(
                rnd.Next(this.Width - pbSmiley.Width),
                rnd.Next(this.Height - pbSmiley.Height - 20));
        }

        private void pbSmiley_MouseEnter(object sender, EventArgs e)
        {
            pbSmiley.Image = Properties.Resources.smiley_close;
        }

        private void pbSmiley_MouseLeave(object sender, EventArgs e)
        {
            pbSmiley.Image = Properties.Resources.smiley_open;
        }
    }
}

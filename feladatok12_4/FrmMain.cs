using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_4
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAlap_Click(object sender, EventArgs e)
        {
            lblText.Text = "Hello World!";
            lblText.Font = new Font("Microsoft Sans Serif", 12F);
            lblText.TextAlign = ContentAlignment.TopLeft;
            lblText.ForeColor = Color.Black;
            lblText.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void btnKek_Click(object sender, EventArgs e)
        {
            lblText.ForeColor = Color.Blue;
        }

        private void btnFeher_Click(object sender, EventArgs e)
        {
            lblText.BackColor = Color.White;
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            lblText.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBK_Click(object sender, EventArgs e)
        {
            lblText.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void btnKK_Click(object sender, EventArgs e)
        {
            lblText.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnJK_Click(object sender, EventArgs e)
        {
            lblText.TextAlign = ContentAlignment.MiddleRight;
        }

        private void btnNagy_Click(object sender, EventArgs e)
        {
            lblText.Text = lblText.Text.ToUpper();
        }

        private void btnNagyit_Click(object sender, EventArgs e)
        {
            float meret = lblText.Font.Size;
            lblText.Font = new Font("Microsoft Sans Serif", ++meret);
        }

        private void btnKicsinyit_Click(object sender, EventArgs e)
        {
            float meret = lblText.Font.Size;
            if (meret > 1) lblText.Font = new Font("Microsoft Sans Serif", --meret);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_2
{
    public partial class FrmMain : Form
    {

        Color eredetiSzin;

        public FrmMain()
        {
            InitializeComponent();
            eredetiSzin = this.BackColor;
        }

        private void BtnGombClick(object sender, EventArgs e)
        {
            btnGomb.Text = btnGomb.Text.ToUpper();
        }

        private void BtnGombMouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        private void BtnGombMouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"[X:{Cursor.Position.X} Y:{Cursor.Position.Y}]";
        }

        private void BtnGombMouseLeave(object sender, EventArgs e)
        {
            this.BackColor = eredetiSzin;
            btnGomb.Text = btnGomb.Text.ToLower();
        }
    }
}

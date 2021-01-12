using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_3
{
    public partial class FrmMain : Form
    {
        Color alap;
        public FrmMain()
        {
            InitializeComponent();

            alap = this.BackColor;


            foreach (var control in this.Controls)
            {
                if(control is PictureBox)
                {
                    (control as PictureBox).Click += PBSzinValtas;
                }
            }
        }

        private void PBSzinValtas(object sender, EventArgs e)
        {
            this.BackColor = (sender as PictureBox).BackColor;
        }

        private void BtnAlapClick(object sender, EventArgs e)
        {
            this.BackColor = alap;
        }

        private void BtnExitClick(object sender, EventArgs e)
        {
            //hívó ablak bezárása:
            //this.Dispose();
            //hívó folyamat leállítása:
            Application.Exit();
        }
    }
}

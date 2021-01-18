using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_5
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnClick_Szamol(object sender, EventArgs e)
        {
            lblMuvelet.Text = (sender as Button).Text;

            int a = int.Parse(txtElso.Text);
            int b = int.Parse(txtMasodik.Text);

            switch (lblMuvelet.Text)
            {
                case "Összeadás":
                    txtEredmeny.Text = $"{a + b}";
                    break;
                case "Kivonás":
                    txtEredmeny.Text = $"{a - b}";
                    break;
                case "Szorzás":
                    txtEredmeny.Text = $"{a * b}";
                    break;
                case "Osztás":
                    txtEredmeny.Text = $"{a / (float)b}";
                    break;
            }

        }

        private void TxtAdat_TextChanged(object sender, EventArgs e)
        {
            lblMuvelet.Text = "Művelet eredménye:";
            txtEredmeny.Text = null;
        }

        private void BtnTorles_Click(object sender, EventArgs e)
        {
            foreach (var txt in this.Controls)
            {
                if (txt is TextBox) (txt as TextBox).Text = null;
            }
            lblMuvelet.Text = "Művelet eredménye:";
        }
    }
}

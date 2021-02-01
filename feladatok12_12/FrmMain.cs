using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_12
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnSzamol_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            float c = float.Parse(txtC.Text);

            float d = (b * b) - (4 * a * c);

            if (a == 0) lblX1.Text = $"{-c / b}";
            else if(d == 0) lblX1.Text = $"{-b / (2 * a)}";
            else if (d < 0) lblX1.Text = lblX2.Text = $"nem valós szám";
            else
            {
                lblX1.Text = $"{(-b + Math.Sqrt(d)) / (2 * a)}";
                lblX2.Text = $"{(-b - Math.Sqrt(d)) / (2 * a)}";
            }


        }
    }
}

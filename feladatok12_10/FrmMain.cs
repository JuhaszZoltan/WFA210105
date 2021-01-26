using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_10
{
    public partial class FrmMain : Form
    {

        static Random rnd = new Random();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnGen_Click(object sender, EventArgs e)
        {
            rtbSzamok.Clear();

            for (int i = 0; i < 100; i++)
            {
                var n = rnd.Next((int)nudMin.Value, (int)nudMax.Value + 1);

                rtbSzamok.Text += string.Format("{0}{1, 2} ", 
                    n < 0 ? "-" : " ", Math.Abs(n));

                if ((i + 1) % 9 == 0) rtbSzamok.Text += "\n";
            }
        }
    }
}

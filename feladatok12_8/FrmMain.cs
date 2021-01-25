using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_8
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCalcClick(object sender, EventArgs e)
        {
            lbOsztok.Items.Clear();
            
            int n = int.Parse(txtSzam.Text);

            if (n <= 0) lbOsztok.Items.Add("nn");

            lbOsztok.Items.Add(1);

            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0) lbOsztok.Items.Add(i);

            if(n!= 1) lbOsztok.Items.Add(n);

        }
    }
}

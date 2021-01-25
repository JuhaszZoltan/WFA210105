using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_7
{
    public partial class FrmMain : Form
    {
        static readonly Random rnd = new Random();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnGenClick(object sender, EventArgs e)
        {
            rtxtOutput.Text = null;

            int db = int.Parse(txtInput.Text);
            for (int i = 0; i < db; i++)
            {
                rtxtOutput.Text += $"{rnd.Next(1, 7)} ";
            }

            for (int i = 0; i < rtxtOutput.Text.Length - 1; i++)
            {
                if (rtxtOutput.Text[i] == '1')
                {
                    rtxtOutput.Select(i, 1);
                    rtxtOutput.SelectionColor = Color.Red;
                }
                else if (rtxtOutput.Text[i] == '6')
                {
                    rtxtOutput.Select(i, 1);
                    rtxtOutput.SelectionColor = Color.Green;
                }
            }



        }
    }
}

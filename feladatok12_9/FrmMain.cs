using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_9
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnHozzaad_Click(object sender, EventArgs e) =>
            lbGyumolcsok.Items.Add(txtInput.Text);

        private void BtnOsszesTorol_Click(object sender, EventArgs e) => 
            lbGyumolcsok.Items.Clear();

        private void BtnKijeloltTorol_Click(object sender, EventArgs e) =>
            lbGyumolcsok.Items.Remove(lbGyumolcsok.SelectedItem);
    }
}

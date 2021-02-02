using System;
using System.Drawing;
using System.Windows.Forms;

namespace feladatok12_13
{
    public partial class FrmMain : Form
    {
        Random rnd = new Random();

        int jp = 0;
        int gp = 0;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnJatekos_Click(object sender, EventArgs e)
        {
            //gép sorsol

            Button[] lehetosegek = { btnGep_Ko, btnGep_Ollo, btnGep_Papir };
            var gv = lehetosegek[rnd.Next(lehetosegek.Length)];
            gv.BackColor = Color.Green;
            char g = gv.Text.ToLower()[0];

            //játékos választ

            char j = (sender as Button).Text.ToLower()[0];
            (sender as Button).BackColor = Color.Green;


            //kiértékel

            string eredmeny;

            if(j == g) eredmeny = "döntetlen";
            else if((g == 'k' && j == 'p') || (g == 'p' && j == 'o') || (g == 'o' && j == 'k'))
            {
                eredmeny = "játékos nyert!";
                jp++;
            }
            else
            {
                eredmeny = "gép nyert";
                gp++;
            }

            MessageBox.Show(
                text: eredmeny,
                caption: $"jatekos: {jp} - gép: {gp}");

            foreach (var ctrl in this.Controls)
                if (ctrl is Button) (ctrl as Button).BackColor = Color.LightGray;
        }
    }
}

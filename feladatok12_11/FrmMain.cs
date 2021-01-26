﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_11
{
    struct Dolgozat
    {
        public string Nev { get; set; }
        public int Pontszam { get; set; }
    }

    public partial class FrmMain : Form
    {

        List<Dolgozat> dolgozatok;

        public FrmMain()
        {
            dolgozatok = new List<Dolgozat>();
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //ram

            dolgozatok.Add
                (new Dolgozat() 
                { 
                    Nev = txtNev.Text,
                    Pontszam = int.Parse(txtPontszam.Text),
                });

            //ui

            rtbBolgozatok.Text += string.Format("{0, -20} {1}\n", txtNev.Text, txtPontszam.Text);

        }

        private void BtnAvg_Click(object sender, EventArgs e)
        {
            int sum = 0;

            foreach (var d in dolgozatok)
            {
                sum += d.Pontszam;
            }

            MessageBox.Show($"Dolgozatok átlagpontszáma: {sum / (float)dolgozatok.Count}");
        }
    }
}

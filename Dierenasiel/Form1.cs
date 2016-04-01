﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dierenasiel
{
    public partial class Form1 : Form
    {
        Dierenasiel asiel;
        public Form1()
        {
            InitializeComponent();
            asiel = new Dierenasiel("ABC");
        }

        private void btnVoegHondToe_Click(object sender, EventArgs e)
        {
            Hond hond = new Hond(tbHondNaam.Text);
            asiel.voegHondToe(hond);
        }

        private void btnVoegKatToe_Click(object sender, EventArgs e)
        {
            Kat kat = new Kat(tbKatNaam.Text);
            asiel.voegKatToe(kat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Dier element in asiel.Dieren)
            {
                    listView1.Items.Add(element.Naam + " " + element.Gereserveerd + " " + element.Eigenaar);
            }
        }

        private void btnReserveer_Click(object sender, EventArgs e)
        {

        }
    }
}

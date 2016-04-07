using System;
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
        Webshop shop;
        public Form1()
        {
            InitializeComponent();
            asiel = new Dierenasiel("ABC");
            shop = new Webshop();
        }

        private void btnVoegHondToe_Click(object sender, EventArgs e)
        {
            Hond hond = new Hond(tbHondNaam.Text);
            asiel.voegHondToe(hond);
        }

        private void btnVoegKatToe_Click(object sender, EventArgs e)
        {
            Kat kat = new Kat(tbKatNaam.Text, tbGedrag.Text);
            asiel.voegKatToe(kat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (Dier element in asiel.Dieren)
            {
                    listBox2.Items.Add(element.ToString());
            }
        }

        private void btnReserveer_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Food food = new Food(tbProductNaam.Text, Convert.ToDecimal( tbProductPrijs.Text));
            shop.AddProduct(food);
        }

        private void btnProductOverzicht_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (ISellable element in shop.Producten)
            {
                listBox1.Items.Add(element.ToString());
            }
        }
    }
}

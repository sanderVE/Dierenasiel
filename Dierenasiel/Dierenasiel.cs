using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel
{
    public class Dierenasiel
    {
        private String naam;
        private List<Dier> dieren;

        public String Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public List<Dier> Dieren
        {
            get {return dieren; }
        }

        //constructor
        public Dierenasiel(String naam)
        {
            this.naam = naam;
            dieren = new List<Dier>();
        }



        public void voegHondToe(Hond hond)
        {
            dieren.Add(hond);
        }

        public void voegKatToe(Kat kat)
        {
            dieren.Add(kat);
        }

        public void verwijderHond(Hond hond)
        {
            dieren.Remove(hond);
        }

        public void verwijderKat(Kat kat)
        {
            dieren.Remove(kat);
        }

        public Dier geefDierWeer(String naam)
        {
            foreach(Dier element in dieren)
            {
                if (element.naam == naam)
                {
                    return element;
                }
            }
            return null;
        }

        public void reserveerHond()
        {

        }
    }
}

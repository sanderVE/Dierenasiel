using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel
{
    public class Eigenaar
    {
        private String naam;
        private List<Dier> dieren;
        public String Naam
        {
            get {return naam; }
            set {naam = value; }
        }

        public List<Dier> Dieren
        {
            get {return dieren; }
        }

        //constructor
        public Eigenaar(String naam)
        {
            this.naam = naam;
        }

        public void voegHondToe(Hond hond)
        {
            dieren.Add(hond);
        }

        public void voegKatToe(Kat kat)
        {
            dieren.Add(kat);
        }

        public void reserveerHond(Hond hond)
        {
            hond.Gereserveerd = true;
        }

        public void reserveerKat(Kat kat)
        {

        }
    }
}

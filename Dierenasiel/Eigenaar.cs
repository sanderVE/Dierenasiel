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
        private List<Hond> honden;
        private List<Kat> katten;

        public String Naam
        {
            get {return naam; }
            set {naam = value; }
        }

        public List<Hond> Honden
        {
            get {return honden; }
        }

        public List<Hond> Katten
        {
            get { return honden; }
        }

        //constructor
        public Eigenaar(String naam)
        {
            this.naam = naam
        }

        public void voegHondToe(Hond hond)
        {
            honden.Add(hond);
        }

        public void voegKatToe(Kat kat)
        {
            katten.Add(kat);
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

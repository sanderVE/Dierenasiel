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
        private List<Hond> honden;
        private List<Kat> katten;

        public String Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public List<Hond> Honden
        {
            get {return honden; }
        }

        public List<Kat> Katten
        {
            get { return katten; }
        }

        //constructor
        public Dierenasiel(String naam)
        {
            this.naam = naam;
        }



        public void voegHondToe(Hond hond)
        {
            honden.Add(hond);
        }

        public void voegKatToe(Kat kat)
        {
            katten.Add(kat);
        }

        public void verwijderHond(Hond hond)
        {
            honden.Remove(hond);
        }

        public void verwijderKat(Kat kat)
        {
            katten.Remove(kat);
        }

        public Hond geefHondWeer(String naam)
        {
            for(int i = 0; i < honden.Count(); i++)
            {
                if (honden[i].Naam == naam)
                {
                    return honden[i];
                }
            }
            return null;
        }

        public Kat geefKatWeer(String naam)
        {
            for (int i = 0; i < katten.Count(); i++)
            {
                if (katten[i].Naam == naam)
                {
                    return katten[i];
                }
            }
            return null;
        }


//        public List<> geefDierenweer()
//        {
//            return
//        }
    }
}

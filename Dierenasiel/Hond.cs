using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel
{
    public class Hond : Dier
    {
        //variablen
        private String laatstUitgelaten;
        private static int hondenToegevoegd = 0;

        public String LaatstUitgelaten
        {
            get { return laatstUitgelaten; }
            set { laatstUitgelaten = value; }
        }

        //constructor
        public Hond(String naam) : base(naam)
        {
            this.prijs = 500 - (50 * hondenToegevoegd);
            hondenToegevoegd++;
        }

        public void veranderLaatstUitgelaten(String uitgelaten)
        {
            laatstUitgelaten = uitgelaten;
        }
        public override string ToString()
        {
            return base.ToString() + " " + laatstUitgelaten;
        }
        
    }
}

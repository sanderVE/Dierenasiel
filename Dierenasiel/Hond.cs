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

        public String LaatstUitgelaten
        {
            get { return laatstUitgelaten; }
            set { laatstUitgelaten = value; }
        }

        //constructor
        public Hond(String naam) : base(naam)
        {
            
        }

        public void veranderLaatstUitgelaten(String uitgelaten)
        {
            laatstUitgelaten = uitgelaten;
        }
    }
}

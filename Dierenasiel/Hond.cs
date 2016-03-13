using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel
{
    public class Hond
    {
        private String naam;
        private String laatstUitgelaten;
        private Eigenaar eigenaar;
        private Boolean gereserveerd;

        public String Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public String LaatstUitgelaten
        {
            get { return laatstUitgelaten; }
            set { laatstUitgelaten = value; }
        }

        public Boolean Gereserveerd
        {
            get {return gereserveerd; }
            set {gereserveerd = value; }
        }

        public Eigenaar Eigenaar
        {
            get { return eigenaar; }
            set { eigenaar = value; }
        }

        //constructor
        public Hond(String naam)
        {
            this.naam = naam;
        }
    }
}

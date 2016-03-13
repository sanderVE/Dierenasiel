using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel
{
    public class Kat
    {
        //variabelen
        private String naam;
        private String gedrag;
        private Eigenaar eigenaar;
        private Boolean gereserveerd;

        public String Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public String Gedrag
        {
            get { return gedrag; }
            set { gedrag = value; }
        }

        public Boolean Gereserveerd
        {
            get { return gereserveerd; }
            set { gereserveerd = value; }
        }

        public Eigenaar Eigenaar
        {
            get {return eigenaar; }
            set {eigenaar = value; }
        }

        //constructor
        public Kat(String naam)
        {
            this.naam = naam;
        }
    }
}

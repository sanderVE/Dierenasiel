using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel
{
    public class Dier
    {
        private String naam;
        private Eigenaar eigenaar;
        private Boolean gereserveerd;

        public String Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public Boolean Gereserveerd
        {
            get { return gereserveerd; }
            set { gereserveerd = value; }
        }

        public Eigenaar Eigenaar
        {
            get { return eigenaar; }
            set { eigenaar = value; }
        }

        public Dier(String naam)
        {
            this.naam = naam;
            gereserveerd = false;
        }
    }
}

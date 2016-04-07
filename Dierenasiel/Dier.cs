using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel
{
    public abstract class Dier : ISellable
    {
        public string naam { get; private set; }
        private Eigenaar eigenaar;
        private Boolean gereserveerd;
        public decimal prijs { get; set; }

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

        public override string ToString()
        {
            return naam + " " + prijs;
        }
    }
}

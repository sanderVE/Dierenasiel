using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel
{
    public class Kat : Dier
    {
        //variabelen
        private String gedrag;

        public String Gedrag
        {
            get { return gedrag; }
            set { gedrag = value; }
        }

        //constructor
        public Kat(String naam, String gedrag) : base(naam)
        {
            this.prijs = 350 - (gedrag.Count() * 20);
            if(this.prijs < 35)
            {
                this.prijs = 35;
            }
            this.gedrag = gedrag;
        }

        public void verandergedrag(String gedrag)
        {
            this.gedrag = gedrag;
        }

        public override string ToString()
        {
            return base.ToString() + " " + gedrag;
        }
    }
}

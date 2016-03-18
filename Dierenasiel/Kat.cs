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
        public Kat(String naam) : base(naam)
        {
            
        }

        public void verandergedrag(String gedrag)
        {
            this.gedrag = gedrag;
        }
    }
}

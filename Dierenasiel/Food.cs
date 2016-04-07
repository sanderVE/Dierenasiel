using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel
{
    public class Food : ISellable
    {
        public String naam { get; }
        public decimal prijs { get; set; }

        public Food(String naam, decimal prijs)
        {
            this.naam = naam;
            this.prijs = prijs;
        }

        public override string ToString()
        {
            return naam + " " + prijs.ToString("0.00");
        }
    }
}

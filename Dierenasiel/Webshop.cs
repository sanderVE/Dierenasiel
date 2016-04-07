using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel
{
    public class Webshop
    {
        public List<ISellable> Producten { get; private set; }

        public Webshop()
        {
            this.Producten = new List<ISellable>();
        }

        public void AddProduct(ISellable product)
        {
            this.Producten.Add(product);
        }
    }
}

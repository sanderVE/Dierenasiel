using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dierenasiel.Test
{
    [TestClass]
    public class DierTest
    {
        
        [TestMethod]
        public void DierEigenaar()
        {
            Dier dier = new Hond("hond");
            Eigenaar eigenaar = new Eigenaar("Sander");
            dier.Eigenaar = eigenaar;
            Assert.AreEqual(eigenaar, dier.Eigenaar);
        }
    }
}

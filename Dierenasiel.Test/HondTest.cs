using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dierenasiel;
namespace Dierenasiel.Test
{
    [TestClass]
    public class HondTest
    {
        [TestMethod]
        public void HondNaam()
        {
            Hond hond = new Hond("hond");
            Assert.AreEqual("hond", hond.Naam);
        }

        [TestMethod]
        public void DierEigenaar()
        {
            Hond hond = new Hond("hond");
            Eigenaar eigenaar = new Eigenaar("Sander");
            hond.Eigenaar = eigenaar;
            Assert.AreEqual(eigenaar, hond.Eigenaar);
        }

        [TestMethod]
        public void HondUitgelaten()
        {
            Hond hond = new Hond("hond");
            hond.veranderLaatstUitgelaten("2-11-2013");
            Assert.AreEqual("2-11-2013", hond.LaatstUitgelaten);
        }

        [TestMethod]
        public void Hondgereserveerd()
        {
            Hond hond = new Hond("hond");
            Assert.AreEqual(false, hond.Gereserveerd);
        }
    }
}

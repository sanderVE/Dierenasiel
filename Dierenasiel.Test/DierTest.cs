using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dierenasiel.Test
{
    [TestClass]
    public class DierTest
    {
        [TestMethod]
        public void DierNaam()
        {
            Dier dier = new Dier("dier");
            Assert.AreEqual("dier", dier.Naam);
        }

        [TestMethod]
        public void DierEigenaar()
        {
            Dier dier = new Dier("dier");
            Eigenaar eigenaar = new Eigenaar("Sander");
            dier.Eigenaar = eigenaar;
            Assert.AreEqual(eigenaar, dier.Eigenaar);
        }

        [TestMethod]
        public void Diergereserveerd()
        {
            Dier dier = new Dier("Dier");
            Assert.AreEqual(false, dier.Gereserveerd);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dierenasiel.Test
{
    [TestClass]
    public class KatTest
    {
        [TestMethod]
        public void KatNaam()
        {
            Kat kat = new Kat("kat");
            Assert.AreEqual("kat", kat.Naam);
        }

        [TestMethod]
        public void DierEigenaar()
        {
            Kat kat = new Kat("dier");
            Eigenaar eigenaar = new Eigenaar("Sander");
            kat.Eigenaar = eigenaar;
            Assert.AreEqual(eigenaar, kat.Eigenaar);
        }

        [TestMethod]
        public void KatGedrag()
        {
            Kat kat = new Kat("kat");
            kat.verandergedrag("goed met kinderen");
            Assert.AreEqual("goed met kinderen", kat.Gedrag);
        }

        [TestMethod]
        public void Katgereserveerd()
        {
            Kat kat = new Kat("kat");
            Assert.AreEqual(false, kat.Gereserveerd);
        }
    }
}

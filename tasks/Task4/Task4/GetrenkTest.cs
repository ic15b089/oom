using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task4
{
    class GetrenkTest
    {
        [Test]
        public void TesteGetraenkIdGleichInitialWert()
        {
            var xwge = new Getraenk(14, "Soda", 2.4, "frei");
            Assert.IsTrue(xwge.Id == 14);
        }

        [Test]
        public void TesteGetraenkNameGleichInitialWert()
        {
            var xwge = new Getraenk(14, "Soda", 2.4, "frei");
            Assert.IsTrue(xwge.Name == "Soda");
        }

        [Test]
        public void TesteGetraenkPreisGleichInitialWert()
        {
            var xwge = new Getraenk(14, "Soda", 2.4, "frei");
            Assert.IsTrue(xwge.Preis == 2.4);
        }

        [Test]
        public void TesteGetraenkAlkoholGleichInitialWert()
        {
            var xwge = new Getraenk(14, "Soda", 2.4, "frei");
            Assert.IsTrue(xwge.Alkohol == "frei");
        }
    }
}

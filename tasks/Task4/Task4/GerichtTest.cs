using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task4
{
    class GerichtTest
    {
        [Test]
        public void TesteGerichtIdGleichInitialWert()
        {
            var xwg = new Gericht(13, "Schnizel", 20.5, "Fleich, Sauce, Karotten");
            Assert.IsTrue(xwg.Id == 13);
        }

        [Test]
        public void TesteGerichtNameGleichInitialWert()
        {
            var xwg = new Gericht(13, "Schnizel", 20.5, "Fleich, Sauce, Karotten");
            Assert.IsTrue(xwg.Name == "Schnizel");
        }

        [Test]
        public void TesteGerichtPreisGleichInitialWert()
        {
            var xwg = new Gericht(13, "Schnizel", 20.5, "Fleich, Sauce, Karotten");
            Assert.IsTrue(xwg.Preis == 20.5);
        }

        [Test]
        public void TesteGerichtRezeptGleichInitialWert()
        {
            var xwg = new Gericht(13, "Schnizel", 20.5, "Fleich, Sauce, Karotten");
            Assert.IsTrue(xwg.Rezept == "Fleich, Sauce, Karotten");
        }
    }
}

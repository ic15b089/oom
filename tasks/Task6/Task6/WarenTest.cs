using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task6
{
    class WarenTest
    {
        [Test]
        public void TesteWarenIdGleichInitialWert()
        {
            var xw = new Ware(12, "Ketchup", 12.4);
            Assert.IsTrue(xw.Id == 12);
        }

        [Test]
        public void TesteWarenNameGleichInitialWert()
        {
            var xw = new Ware(12, "Ketchup", 12.4);
            Assert.IsTrue(xw.Name == "Ketchup");
        }

        [Test]
        public void TesteWarenPreisGleichInitialWert()
        {
            var xw = new Ware(12, "Ketchup", 12.4);
            Assert.IsTrue(xw.Preis == 12.4);
        }

    }
}

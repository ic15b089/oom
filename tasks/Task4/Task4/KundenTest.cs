using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task4
{
    class KundenTest
    {
        [Test]
        public void TesteKundenIdGleichInitialWert()
        {
            var xpk = new Kunden(18, "Barbara", "Nik", "Frau", "12.11.1988", 22241972, 22261141972, 1080, "Burggasse", 2, "barbara@yahoo.com", 12352869);
            Assert.IsTrue(xpk.Id == 18);
        }

        [Test]
        public void TesteKundenVornameGleichInitialWert()
        {
            var xpk = new Kunden(18, "Barbara", "Nik", "Frau", "12.11.1988", 22241972, 22261141972, 1080, "Burggasse", 2, "barbara@yahoo.com", 12352869);
            Assert.IsTrue(xpk.Vorname == "Barbara");
        }

        [Test]
        public void TesteKundenNachnameGleichInitialWert()
        {
            var xpk = new Kunden(18, "Barbara", "Nik", "Frau", "12.11.1988", 22241972, 22261141972, 1080, "Burggasse", 2, "barbara@yahoo.com", 12352869);
            Assert.IsTrue(xpk.Nachname == "Nik");
        }

        [Test]
        public void TesteKundenSexGleichInitialWert()
        {
            var xpk = new Kunden(18, "Barbara", "Nik", "Frau", "12.11.1988", 22241972, 22261141972, 1080, "Burggasse", 2, "barbara@yahoo.com", 12352869);
            Assert.IsTrue(xpk.Sex == "Frau");
        }

        [Test]
        public void TesteKundenGeburtstagGleichInitialWert()
        {
            var xpk = new Kunden(18, "Barbara", "Nik", "Frau", "12.11.1988", 22241972, 22261141972, 1080, "Burggasse", 2, "barbara@yahoo.com", 12352869);
            Assert.IsTrue(xpk.Geburtstag == "12.11.1988");
        }

        [Test]
        public void TesteKundenTelefonnummerGleichInitialWert()
        {
            var xpk = new Kunden(18, "Barbara", "Nik", "Frau", "12.11.1988", 22241972, 22261141972, 1080, "Burggasse", 2, "barbara@yahoo.com", 12352869);
            Assert.IsTrue(xpk.Telefonnummer == 22241972);
        }

        [Test]
        public void TesteKundenHandynummerGleichInitialWert()
        {
            var xpk = new Kunden(18, "Barbara", "Nik", "Frau", "12.11.1988", 22241972, 22261141972, 1080, "Burggasse", 2, "barbara@yahoo.com", 12352869);
            Assert.IsTrue(xpk.Handynummer == 22261141972);
        }

        [Test]
        public void TesteKundenPlzGleichInitialWert()
        {
            var xpk = new Kunden(18, "Barbara", "Nik", "Frau", "12.11.1988", 22241972, 22261141972, 1080, "Burggasse", 2, "barbara@yahoo.com", 12352869);
            Assert.IsTrue(xpk.Plz == 1080);
        }

        [Test]
        public void TesteKundenStrasseGleichInitialWert()
        {
            var xpk = new Kunden(18, "Barbara", "Nik", "Frau", "12.11.1988", 22241972, 22261141972, 1080, "Burggasse", 2, "barbara@yahoo.com", 12352869);
            Assert.IsTrue(xpk.Strasse == "Burggasse");
        }

        [Test]
        public void TesteKundenHausnummerGleichInitialWert()
        {
            var xpk = new Kunden(18, "Barbara", "Nik", "Frau", "12.11.1988", 22241972, 22261141972, 1080, "Burggasse", 2, "barbara@yahoo.com", 12352869);
            Assert.IsTrue(xpk.Hausnummer == 2);
        }

        [Test]
        public void TesteKundenEmailGleichInitialWert()
        {
            var xpk = new Kunden(18, "Barbara", "Nik", "Frau", "12.11.1988", 22241972, 22261141972, 1080, "Burggasse", 2, "barbara@yahoo.com", 12352869);
            Assert.IsTrue(xpk.Email == "barbara@yahoo.com");
        }

        [Test]
        public void TesteKundenBestellunsnummerGleichInitialWert()
        {
            var xpk = new Kunden(18, "Barbara", "Nik", "Frau", "12.11.1988", 22241972, 22261141972, 1080, "Burggasse", 2, "barbara@yahoo.com", 12352869);
            Assert.IsTrue(xpk.Bestellungsnummer == 12352869);
        }
    }
}

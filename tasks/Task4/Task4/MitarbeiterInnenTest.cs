using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task4
{
    class MitarbeiterInnenTest
    {
        [Test]
        public void TesteMitarbeiterInnenIdGleichInitialWert()
        {
            var xpm = new MitarbeiterInnen(16, "Jaennette", "Müller", "Frau", "10.08.1982", 12345678, 6771234567, 1070, "Kenyongasse 23-25", 20, "mueller@yahoo.com", 1500, "Angestellin", "Kassa");
            Assert.IsTrue(xpm.Id == 16);
        }

        [Test]
        public void TesteMitarbeiterInnenVornameGleichInitialWert()
        {
            var xpm = new MitarbeiterInnen(16, "Jaennette", "Müller", "Frau", "10.08.1982", 12345678, 6771234567, 1070, "Kenyongasse 23-25", 20, "mueller@yahoo.com", 1500, "Angestellin", "Kassa");
            Assert.IsTrue(xpm.Vorname == "Jaennette");
        }

        [Test]
        public void TesteMitarbeiterInnenNachnameGleichInitialWert()
        {
            var xpm = new MitarbeiterInnen(16, "Jaennette", "Müller", "Frau", "10.08.1982", 12345678, 6771234567, 1070, "Kenyongasse 23-25", 20, "mueller@yahoo.com", 1500, "Angestellin", "Kassa");
            Assert.IsTrue(xpm.Nachname == "Müller");
        }

        [Test]
        public void TesteMitarbeiterInnenSexGleichInitialWert()
        {
            var xpm = new MitarbeiterInnen(16, "Jaennette", "Müller", "Frau", "10.08.1982", 12345678, 6771234567, 1070, "Kenyongasse 23-25", 20, "mueller@yahoo.com", 1500, "Angestellin", "Kassa");
            Assert.IsTrue(xpm.Sex == "Frau");
        }

        [Test]
        public void TesteMitarbeiterInnenGeburtstagGleichInitialWert()
        {
            var xpm = new MitarbeiterInnen(16, "Jaennette", "Müller", "Frau", "10.08.1982", 12345678, 6771234567, 1070, "Kenyongasse 23-25", 20, "mueller@yahoo.com", 1500, "Angestellin", "Kassa");
            Assert.IsTrue(xpm.Geburtstag == "10.08.1982");
        }

        [Test]
        public void TesteMitarbeiterInnenTelefonnummerGleichInitialWert()
        {
            var xpm = new MitarbeiterInnen(16, "Jaennette", "Müller", "Frau", "10.08.1982", 12345678, 6771234567, 1070, "Kenyongasse 23-25", 20, "mueller@yahoo.com", 1500, "Angestellin", "Kassa");
            Assert.IsTrue(xpm.Telefonnummer == 12345678);
        }

        [Test]
        public void TesteMitarbeiterInnenHandynummerGleichInitialWert()
        {
            var xpm = new MitarbeiterInnen(16, "Jaennette", "Müller", "Frau", "10.08.1982", 12345678, 6771234567, 1070, "Kenyongasse 23-25", 20, "mueller@yahoo.com", 1500, "Angestellin", "Kassa");
            Assert.IsTrue(xpm.Handynummer == 6771234567);
        }

        [Test]
        public void TesteMitarbeiterInnenPlzGleichInitialWert()
        {
            var xpm = new MitarbeiterInnen(16, "Jaennette", "Müller", "Frau", "10.08.1982", 12345678, 6771234567, 1070, "Kenyongasse 23-25", 20, "mueller@yahoo.com", 1500, "Angestellin", "Kassa");
            Assert.IsTrue(xpm.Plz == 1070);
        }

        [Test]
        public void TesteMitarbeiterInnenStrasseGleichInitialWert()
        {
            var xpm = new MitarbeiterInnen(16, "Jaennette", "Müller", "Frau", "10.08.1982", 12345678, 6771234567, 1070, "Kenyongasse 23-25", 20, "mueller@yahoo.com", 1500, "Angestellin", "Kassa");
            Assert.IsTrue(xpm.Strasse == "Kenyongasse 23-25");
        }

        [Test]
        public void TesteMitarbeiterInnenHausnummerGleichInitialWert()
        {
            var xpm = new MitarbeiterInnen(16, "Jaennette", "Müller", "Frau", "10.08.1982", 12345678, 6771234567, 1070, "Kenyongasse 23-25", 20, "mueller@yahoo.com", 1500, "Angestellin", "Kassa");
            Assert.IsTrue(xpm.Hausnummer == 20);
        }

        [Test]
        public void TesteMitarbeiterInnenEmailGleichInitialWert()
        {
            var xpm = new MitarbeiterInnen(16, "Jaennette", "Müller", "Frau", "10.08.1982", 12345678, 6771234567, 1070, "Kenyongasse 23-25", 20, "mueller@yahoo.com", 1500, "Angestellin", "Kassa");
            Assert.IsTrue(xpm.Email == "mueller@yahoo.com");
        }

        [Test]
        public void TesteMitarbeiterInnenGehaltGleichInitialWert()
        {
            var xpm = new MitarbeiterInnen(16, "Jaennette", "Müller", "Frau", "10.08.1982", 12345678, 6771234567, 1070, "Kenyongasse 23-25", 20, "mueller@yahoo.com", 1500, "Angestellin", "Kassa");
            Assert.IsTrue(xpm.Gehalt == 1500);
        }

        [Test]
        public void TesteMitarbeiterInnenPositionGleichInitialWert()
        {
            var xpm = new MitarbeiterInnen(16, "Jaennette", "Müller", "Frau", "10.08.1982", 12345678, 6771234567, 1070, "Kenyongasse 23-25", 20, "mueller@yahoo.com", 1500, "Angestellin", "Kassa");
            Assert.IsTrue(xpm.Position == "Angestellin");
        }

        [Test]
        public void TesteMitarbeiterInnenAbteilungGleichInitialWert()
        {
            var xpm = new MitarbeiterInnen(16, "Jaennette", "Müller", "Frau", "10.08.1982", 12345678, 6771234567, 1070, "Kenyongasse 23-25", 20, "mueller@yahoo.com", 1500, "Angestellin", "Kassa");
            Assert.IsTrue(xpm.Abteilung == "Kassa");
        }
    }
}

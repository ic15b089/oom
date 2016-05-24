using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task4
{
    class PersonenTest
    {
        [Test]
        public void TestePersonenIdGleichInitialWert()
        {
            var xp = new Personen(15, "Ben", "Hueber", "Mann", "12.05.1980", 61141972, 67761141972, 1500, "Auf der Schmelz", 52, "ben@yahoo.com");
            Assert.IsTrue(xp.Id == 15);
        }

        [Test]
        public void TestePersonenVornameGleichInitialWert()
        {
            var xp = new Personen(15, "Ben", "Hueber", "Mann", "12.05.1980", 61141972, 67761141972, 1500, "Auf der Schmelz", 52, "ben@yahoo.com");
            Assert.IsTrue(xp.Vorname == "Ben");
        }

        [Test]
        public void TestePersonenNachnameGleichInitialWert()
        {
            var xp = new Personen(15, "Ben", "Hueber", "Mann", "12.05.1980", 61141972, 67761141972, 1500, "Auf der Schmelz", 52, "ben@yahoo.com");
            Assert.IsTrue(xp.Nachname == "Hueber");
        }

        [Test]
        public void TestePersonenSexGleichInitialWert()
        {
            var xp = new Personen(15, "Ben", "Hueber", "Mann", "12.05.1980", 61141972, 67761141972, 1500, "Auf der Schmelz", 52, "ben@yahoo.com");
            Assert.IsTrue(xp.Sex == "Mann");
        }

        [Test]
        public void TestePersonenGeburtstagGleichInitialWert()
        {
            var xp = new Personen(15, "Ben", "Hueber", "Mann", "12.05.1980", 61141972, 67761141972, 1500, "Auf der Schmelz", 52, "ben@yahoo.com");
            Assert.IsTrue(xp.Geburtstag == "12.05.1980");
        }

        [Test]
        public void TestePersonenTelefonnummerGleichInitialWert()
        {
            var xp = new Personen(15, "Ben", "Hueber", "Mann", "12.05.1980", 61141972, 67761141972, 1500, "Auf der Schmelz", 52, "ben@yahoo.com");
            Assert.IsTrue(xp.Telefonnummer == 61141972);
        }

        [Test]
        public void TestePersonenHandynummerGleichInitialWert()
        {
            var xp = new Personen(15, "Ben", "Hueber", "Mann", "12.05.1980", 61141972, 67761141972, 1500, "Auf der Schmelz", 52, "ben@yahoo.com");
            Assert.IsTrue(xp.Handynummer == 67761141972);
        }

        [Test]
        public void TestePersonenPlzGleichInitialWert()
        {
            var xp = new Personen(15, "Ben", "Hueber", "Mann", "12.05.1980", 61141972, 67761141972, 1500, "Auf der Schmelz", 52, "ben@yahoo.com");
            Assert.IsTrue(xp.Plz == 1500);
        }

        [Test]
        public void TestePersonenStrasseGleichInitialWert()
        {
            var xp = new Personen(15, "Ben", "Hueber", "Mann", "12.05.1980", 61141972, 67761141972, 1500, "Auf der Schmelz", 52, "ben@yahoo.com");
            Assert.IsTrue(xp.Strasse == "Auf der Schmelz");
        }

        [Test]
        public void TestePersonenHausnummerGleichInitialWert()
        {
            var xp = new Personen(15, "Ben", "Hueber", "Mann", "12.05.1980", 61141972, 67761141972, 1500, "Auf der Schmelz", 52, "ben@yahoo.com");
            Assert.IsTrue(xp.Hausnummer == 52);
        }

        [Test]
        public void TestePersonenEmailGleichInitialWert()
        {
            var xp = new Personen(15, "Ben", "Hueber", "Mann", "12.05.1980", 61141972, 67761141972, 1500, "Auf der Schmelz", 52, "ben@yahoo.com");
            Assert.IsTrue(xp.Email == "ben@yahoo.com");
        }
    }
}

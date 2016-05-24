using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task4
{
    class LiferantTest
    {
        [Test]
        public void TesteLiferantIdGleichInitialWert()
        {
            var xpl = new Liferant(17, "Benni", "Obi", "Mann", "19.09.1980", 12141972, 12761141972, 1090, "Lanstrasse", 92, "Benni@yahoo.com", 2000, "152228536");
            Assert.IsTrue(xpl.Id == 17);
        }

        [Test]
        public void TesteLiferantVornameGleichInitialWert()
        {
            var xpl = new Liferant(17, "Benni", "Obi", "Mann", "19.09.1980", 12141972, 12761141972, 1090, "Lanstrasse", 92, "Benni@yahoo.com", 2000, "152228536");
            Assert.IsTrue(xpl.Vorname == "Benni");
        }

        [Test]
        public void TesteLiferantNachnameGleichInitialWert()
        {
            var xpl = new Liferant(17, "Benni", "Obi", "Mann", "19.09.1980", 12141972, 12761141972, 1090, "Lanstrasse", 92, "Benni@yahoo.com", 2000, "152228536");
            Assert.IsTrue(xpl.Nachname == "Obi");
        }

        [Test]
        public void TesteLiferantSexGleichInitialWert()
        {
            var xpl = new Liferant(17, "Benni", "Obi", "Mann", "19.09.1980", 12141972, 12761141972, 1090, "Lanstrasse", 92, "Benni@yahoo.com", 2000, "152228536");
            Assert.IsTrue(xpl.Sex == "Mann");
        }

        [Test]
        public void TesteLiferantGeburtstagGleichInitialWert()
        {
            var xpl = new Liferant(17, "Benni", "Obi", "Mann", "19.09.1980", 12141972, 12761141972, 1090, "Lanstrasse", 92, "Benni@yahoo.com", 2000, "152228536");
            Assert.IsTrue(xpl.Geburtstag == "19.09.1980");
        }

        [Test]
        public void TesteLiferantTelefonnummerGleichInitialWert()
        {
            var xpl = new Liferant(17, "Benni", "Obi", "Mann", "19.09.1980", 12141972, 12761141972, 1090, "Lanstrasse", 92, "Benni@yahoo.com", 2000, "152228536");
            Assert.IsTrue(xpl.Telefonnummer == 12141972);
        }

        [Test]
        public void TesteLiferantHandynummerGleichInitialWert()
        {
            var xpl = new Liferant(17, "Benni", "Obi", "Mann", "19.09.1980", 12141972, 12761141972, 1090, "Lanstrasse", 92, "Benni@yahoo.com", 2000, "152228536");
            Assert.IsTrue(xpl.Handynummer == 12761141972);
        }

        [Test]
        public void TesteLiferantPlzGleichInitialWert()
        {
            var xpl = new Liferant(17, "Benni", "Obi", "Mann", "19.09.1980", 12141972, 12761141972, 1090, "Lanstrasse", 92, "Benni@yahoo.com", 2000, "152228536");
            Assert.IsTrue(xpl.Plz == 1090);
        }

        [Test]
        public void TesteLiferantStrasseGleichInitialWert()
        {
            var xpl = new Liferant(17, "Benni", "Obi", "Mann", "19.09.1980", 12141972, 12761141972, 1090, "Lanstrasse", 92, "Benni@yahoo.com", 2000, "152228536");
            Assert.IsTrue(xpl.Strasse == "Lanstrasse");
        }

        [Test]
        public void TesteLiferantHausnummerGleichInitialWert()
        {
            var xpl = new Liferant(17, "Benni", "Obi", "Mann", "19.09.1980", 12141972, 12761141972, 1090, "Lanstrasse", 92, "Benni@yahoo.com", 2000, "152228536");
            Assert.IsTrue(xpl.Hausnummer == 92);
        }

        [Test]
        public void TesteLiferantEmailGleichInitialWert()
        {
            var xpl = new Liferant(17, "Benni", "Obi", "Mann", "19.09.1980", 12141972, 12761141972, 1090, "Lanstrasse", 92, "Benni@yahoo.com", 2000, "152228536");
            Assert.IsTrue(xpl.Email == "Benni@yahoo.com");
        }

        [Test]
        public void TesteLiferantGehaltGleichInitialWert()
        {
            var xpl = new Liferant(17, "Benni", "Obi", "Mann", "19.09.1980", 12141972, 12761141972, 1090, "Lanstrasse", 92, "Benni@yahoo.com", 2000, "152228536");
            Assert.IsTrue(xpl.Gehalt == 2000);
        }

        [Test]
        public void TesteLiferantFuehrerscheinGleichInitialWert()
        {
            var xpl = new Liferant(17, "Benni", "Obi", "Mann", "19.09.1980", 12141972, 12761141972, 1090, "Lanstrasse", 92, "Benni@yahoo.com", 2000, "152228536");
            Assert.IsTrue(xpl.Fuehrerschein == "152228536");
        }
        
    }
}

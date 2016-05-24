using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Kunden : Personen
    {
        private double m_bestellungsnummer;

        public double Bestellungsnummer
        {
            get { return m_bestellungsnummer; }
            set { m_bestellungsnummer = value; }
        }
        //-------------------------------

        public Kunden(int id, string vorname, string nachname, string sex, string geburtstag, decimal telefonnummer, decimal handynummer, int plz, string stasse, int hausnummer, string email, double bestellungsnummer) : base(id, vorname, nachname, sex, geburtstag, telefonnummer, handynummer, plz, stasse, hausnummer, email)
        {
            m_bestellungsnummer = bestellungsnummer;

        }
        //-------------------------------
        public Kunden() : this(-1, "", "", "", "", 0, 0, -1, "", -1, "", 0)
        {

        }
        //------------------------------

        public override void Write()
        {
            base.Write();
            Console.WriteLine("Bestellungsnummer: {0}", Bestellungsnummer);
        }
    }
}
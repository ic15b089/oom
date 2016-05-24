using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Liferant : Personen
    {
        private double m_gehalt;

        public double Gehalt
        {
            get { return m_gehalt; }
            set { m_gehalt = value; }
        }
        //-------------------------------

        private string m_fuehrerschein;

        public string Fuehrerschein
        {
            get { return m_fuehrerschein; }
            set { m_fuehrerschein = value; }
        }
        //-------------------------------

        public Liferant(int id, string vorname, string nachname, string sex, string geburtstag, decimal telefonnummer, decimal handynummer, int plz, string stasse, int hausnummer, string email, double gehalt, string fuehrerschein) : base(id, vorname, nachname, sex, geburtstag, telefonnummer, handynummer, plz, stasse, hausnummer, email)
        {
            m_gehalt = gehalt;
            m_fuehrerschein = fuehrerschein;

        }
        //-------------------------------
        public Liferant() : this(-1, "", "", "", "", 0, 0, -1, "", -1, "", 0, "")
        {

        }
        //------------------------------

        public override void Write()
        {
            base.Write();
            Console.WriteLine("Gehalt:            {0} Euro", Gehalt);
            Console.WriteLine("Position:          {0}", Fuehrerschein);
        }
    }
}
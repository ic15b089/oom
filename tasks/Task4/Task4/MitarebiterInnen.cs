using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MitarbeiterInnen : Personen
    {
        private double m_gehalt;

        public double Gehalt
        {
            get { return m_gehalt; }
            set { m_gehalt = value; }
        }
        //-------------------------------

        private string m_position;

        public string Position
        {
            get { return m_position; }
            set { m_position = value; }
        }
        //-------------------------------

        private string m_abteilung;

        public string Abteilung
        {
            get { return m_abteilung; }
            set { m_abteilung = value; }
        }
        //-------------------------------

        public MitarbeiterInnen(int id, string vorname, string nachname, string sex, string geburtstag, decimal telefonnummer, decimal handynummer, int plz, string stasse, int hausnummer, string email, double gehalt, string position, string abteilung) : base(id, vorname, nachname, sex, geburtstag, telefonnummer, handynummer, plz, stasse, hausnummer, email)
        {
            m_gehalt = gehalt;
            m_position = position;
            m_abteilung = abteilung;
        }
        //-------------------------------
        public MitarbeiterInnen() : this(-1, "", "", "", "", 0, 0, -1, "", -1, "", 0, "", "")
        {

        }
        //------------------------------

        public override void Write()
        {
            base.Write();
            Console.WriteLine("Gehalt:            {0} Euro", Gehalt);
            Console.WriteLine("Position:          {0}", Position);
            Console.WriteLine("Abteilung:         {0}", Abteilung);
        }
    }
}
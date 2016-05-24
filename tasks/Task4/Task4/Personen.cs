using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Personen : IObjekt
    {
        private int m_id;

        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        //------------------------------

        private string m_vorname;

        public string Vorname
        {
            get { return m_vorname; }
            set { m_vorname = value; }
        }
        //-------------------------------

        private string m_nachname;

        public string Nachname
        {
            get { return m_nachname; }
            set { m_nachname = value; }
        }
        //-------------------------------

        private string m_sex;

        public string Sex
        {
            get { return m_sex; }
            set { m_sex = value; }
        }
        //-------------------------------

        private string m_geburtstag;

        public string Geburtstag
        {
            get { return m_geburtstag; }
            set { m_geburtstag = value; }
        }
        //-------------------------------

        private decimal m_telefonnummer;

        public decimal Telefonnummer
        {
            get { return m_telefonnummer; }
            set { m_telefonnummer = value; }
        }
        //-------------------------------
        
        private decimal m_handynummer;

        public decimal Handynummer
        {
            get { return m_handynummer; }
            set { m_handynummer = value; }
        }
        //-------------------------------

        private int m_plz;

        public int Plz
        {
            get { return m_plz; }
            set { m_plz = value; }
        }
        //-------------------------------

        private string m_strasse;

        public string Strasse
        {
            get { return m_strasse; }
            set { m_strasse = value; }
        }
        //-------------------------------

        private int m_hausnummer;

        public int Hausnummer
        {
            get { return m_hausnummer; }
            set { m_hausnummer = value; }
        }
        //-------------------------------

        private string m_email;

        public string Email
        {
            get { return m_email; }
            set { m_email = value; }
        }
        //-------------------------------

                       
        public Personen(int id, string vorname, string nachname, string sex, string geburtstag, decimal telefonnummer, decimal handynummer, int plz, string stasse, int hausnummer, string email)
        {
            m_id = id;
            m_vorname = vorname;
            m_nachname = nachname;
            m_sex = sex;
            m_geburtstag = geburtstag;
            m_telefonnummer = telefonnummer;
            m_handynummer = handynummer;
            m_plz = plz;
            m_strasse = stasse;
            m_hausnummer = hausnummer;
            m_email = email;
        }
        //-------------------------------
        public Personen() : this(-1, string.Empty, string.Empty, string.Empty, string.Empty, 0, 0, 0, string.Empty, 0, string.Empty)
        {

        }
        //------------------------------

        public virtual void Write()
        {
            Console.WriteLine("Id:                {0}", Id);
            Console.WriteLine("Vorname:           {0}", Vorname);
            Console.WriteLine("Nachname:          {0}", Nachname);
            Console.WriteLine("Sex:               {0}", Sex);
            Console.WriteLine("Geburtstag:        {0}", Geburtstag);
            Console.WriteLine("Telefonnummer:     {0}", Telefonnummer);
            Console.WriteLine("Handynummer:       {0}", Handynummer);
            Console.WriteLine("Plz:               {0}", Plz);
            Console.WriteLine("Strasse:           {0}", Strasse);
            Console.WriteLine("Hausnummer         {0}", Hausnummer);
            Console.WriteLine("E-Mail:            {0}", Email);
        }
    }
}
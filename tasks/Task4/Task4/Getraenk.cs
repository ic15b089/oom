using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Getraenk : Ware
    {
        private string m_alkohol;

        public string Alkohol
        {
            get { return m_alkohol; }
            set { m_alkohol = value; }
        }
        //-------------------------------

        public Getraenk(int id, string name, double preis, string alkohol) : base(id, name, preis)
        {
            m_alkohol = alkohol;
        }
        //-------------------------------
        public Getraenk() : this(-1, "", 0, "")
        {

        }
        //------------------------------

        public override void Write()
        {
            base.Write();
            Console.WriteLine("Alkohol:           {0}", Alkohol);
        }
    }
}
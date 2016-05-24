using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Ware : IObjekt
    {
        private int m_id;

        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        //------------------------------

        private string m_name;

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        //-------------------------------

        private double m_preis;

        public double Preis
        {
            get { return m_preis; }
            set { m_preis = value; }
        }
        //-------------------------------

        public Ware(int id, string name, double preis)
        {
            m_id = id;
            m_name = name;
            m_preis = preis;
        }
        //-------------------------------
        public Ware() : this(-1, string.Empty, 0)
        {

        }
        //------------------------------

        public virtual void Write()
        {
            Console.WriteLine("Id:      {0}", Id);
            Console.WriteLine("Name:    {0}", Name);
            Console.WriteLine("Preis:   {0} ", Preis);
        }
    }
}
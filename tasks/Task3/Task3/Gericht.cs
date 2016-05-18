using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Gericht : Ware
    {
        private string m_rezept;

        public string Rezept
        {
            get { return m_rezept;}
            set { m_rezept = value; }
        }
        //-------------------------------

        public Gericht(int id, string name, double preis, string rezept) : base(id, name, preis)
        {
            m_rezept = rezept;
        }
        //-------------------------------
        public Gericht():this(-1, "", 0, "")
        {

        }
        //-------------------------------
        public override void Write()
        {
            base.Write();
            Console.WriteLine("Rezept:  {0}", Rezept);
        }
    }
}

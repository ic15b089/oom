using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class EmployeeDTO
    {
        public decimal IdNummer;
        public string Vorname;
        public string Nachname;
        public int Bruttobetrag;
    }
    class Employee
    {
        //Field | Internal variable
        private decimal m_idnummer;
        private string m_vorname;
        private string m_nachname;
        private int m_bruttobetrag;

        //Method | Behavior | Internal Function
        public int BerechnenNettorBetrag()
        {
            int tax = 0;

            if (m_bruttobetrag < 900)
            {
                tax = 0;
            }
            else if (m_bruttobetrag < 1500)
            {
                tax = (int)((m_bruttobetrag - 900) * 0.1);
            }
            else
            {
                tax = (int)(60 + (m_bruttobetrag - 1500) * 0.2);
            }
            return m_bruttobetrag - tax;
        }

        public Employee(EmployeeDTO n)
        {
            m_idnummer = n.IdNummer;
            m_vorname = n.Vorname;
            m_nachname = n.Nachname;
            m_bruttobetrag = n.Bruttobetrag;
        }

        public void show()
        {
            Console.WriteLine("Ihre Nummer ist:       {0}", m_idnummer);
            Console.WriteLine("Ihr Vorname ist:       {0}", m_vorname);
            Console.WriteLine("Ihr Nachname ist:      {0}", m_nachname);
            Console.WriteLine("Ihr Bruttobetrag ist:  {0}", m_bruttobetrag);
            Console.WriteLine("Ihr Nettobetrag ist:   {0}", BerechnenNettorBetrag());
            Console.WriteLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDTO n;
            n = new EmployeeDTO();

            Console.Write("Geben Sie die ID-Nummer ein:     ");
            n.IdNummer = decimal.Parse(Console.ReadLine());

            Console.Write("Geben Sie den Vorname ein:       ");
            n.Vorname = Console.ReadLine();

            Console.Write("Geben Sie den Nachname ein:      ");
            n.Nachname = Console.ReadLine();

            Console.Write("Geben Sie den Bruttobetrag ein:  ");
            n.Bruttobetrag = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Employee x;
            x = new Employee(n);
            x.show();
        }
    }
}

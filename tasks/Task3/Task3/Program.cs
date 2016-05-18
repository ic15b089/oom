using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ware a = new Ware(1, "Gulash", 10.15);
            a.Write();
            Console.WriteLine("------------------------------------");

            Ware b = new Ware(2, "Orangesaft", 2.55);
            b.Write();
            Console.WriteLine("------------------------------------");

            Gericht c = new Gericht(3, "Gulash", 10.15, "Gemuese, Fleisch, Tomate");
            c.Write();
            Console.WriteLine("------------------------------------");

            Getraenk d = new Getraenk(4, "Gulash", 2.55, "Frei");
            d.Write();
            Console.WriteLine("------------------------------------");

        }
    }
}

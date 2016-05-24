using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Ware a = new Ware(1, "Kartoffeln", 5.5);
            //a.Write();
            //Console.WriteLine("------------------------------------");
            
            Gericht b = new Gericht(2, "Gulash", 10.15, "Gemuese, Fleisch, Tomate");
            //b.Write();
            //Console.WriteLine("------------------------------------");
            
            Getraenk c = new Getraenk(3, "Orangensaft", 2.55, "Frei");
            //c.Write();
            //Console.WriteLine("------------------------------------");
            
            Personen d = new Personen(4, "Alex", "Hueber", "maennlich", "01-08-1987" , 01235456, 067761141972, 1500, "Burggasse", 152-2, "alex.hueber@yahoo.com");
            //d.Write();
            //Console.WriteLine("------------------------------------");
            
            Kunden e = new Kunden(5, "Alex1", "Hueber1", "maennlich1", "01-08-1988", 01235457, 067761141973, 1501, "Burggasse1", 152 - 3, "alex.hueber1@yahoo.com", 1523368);
            //e.Write();
            //Console.WriteLine("------------------------------------");

            Liferant f = new Liferant(6, "Alex2", "Hueber2", "maennlich2", "01-08-1989", 01235458, 067761141974, 1502, "Burggasse21", 1502 - 323, "alex.hueber122@yahoo.com", 1500, "IR52668532");
            //f.Write();
            //Console.WriteLine("------------------------------------");

            MitarbeiterInnen g = new MitarbeiterInnen(7, "Alex3", "Hueber3", "maennlich3", "01-08-1990", 012354507, 0677611419553, 1501, "Burggasse5", 1515- 3, "alex.hueber25301@yahoo.com", 1550, "Angestelle", "Kassa");
            //g.Write();
            //Console.WriteLine("------------------------------------");

            var iObjekte = new IObjekt[]
            {
                a,b,c,d,e,f,g
            };

            foreach (var item in iObjekte)
            {
                item.Write();
                Console.WriteLine("------------------------------------");

            }

            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            var json = JsonConvert.SerializeObject(iObjekte, settings);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filename = Path.Combine(desktop, "iObjekte.json");

            File.WriteAllText(filename, json);
            Console.WriteLine(json);
            Console.WriteLine("------------------------------------");
            var gelesenJson = File.ReadAllText(filename);
            var gelesenIObjekte = JsonConvert.DeserializeObject<IObjekt[]>(gelesenJson, settings);
            foreach (var item in gelesenIObjekte)
            {
                item.Write();       
            }

            /*
            var waren = new []
            {
                new Ware(3, "Kartoffeln", 5.5m, Currency.EUR),
                new Ware(2, "Gulash", 10.15m, Currency.EUR),
                new Ware(1, "Orangensaft", 2.55m, Currency.EUR),
            };

            var currency = Currency.EUR;
            foreach (var x in waren)
            {
                Console.WriteLine("{0} {1,-40} {2,8:0.00} {3}", x.Id, x.Titel.Truncate(40), x.GetPrice(currency), currency);
            }


            
            var ids = waren.Select(x => x.Id).OrderBy(x => x);
            Console.WriteLine();
            Console.WriteLine("ID: (ordentlich)");
            foreach (var x in ids) Console.WriteLine(x);
            */
        }
    }
}

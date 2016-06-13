using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Reactive.Subjects;
using System.Reactive.Linq;

namespace Task6
{
    class Program
    {
        public static void Main(string[] args)
        {
            
           
            PushSubject.Run();

            /*
            Ware a = new Ware(1, "Kartoffeln", 5.5);
            ////a.Write();
            ////Console.WriteLine("------------------------------------");

            Gericht b = new Gericht(2, "Gulash", 8.15, "Gemuese, Fleisch, Tomate");
            Gericht c = new Gericht(3, "Schnitzel ", 10.20, "Schnitzel ,Senf, Kaese, Ei, Meerrettich");
            Gericht d = new Gericht(4, "Rindsschmorbraten mit Essig und Rahm", 9.10, "Rinderbraten, Butter, Mehl, Zwiebel, Essig, Salz");

            Getraenk e = new Getraenk(5, "Orangensaft", 2.55, "Frei");
            Getraenk f = new Getraenk(6, "Soda", 1.85, "frei");
            Getraenk g = new Getraenk(7, "Weiss Wein", 5.45, "mit Alkohol");

            var iObjekte = new IObjekt[]
            {
                a,b,c,d,e,f,g
            };
            
            foreach (var item in iObjekte)
            {
               // item.Write();
                Console.WriteLine(item);
            }

            /*
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
            */
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Task6
{
    public static class PushSubject
    {
        //public static Ware[] w;
        public static void Run()
        {

            Ware a = new Ware(1, "Kartoffeln", 5.5);
            ////a.Write();
            ////Console.WriteLine("------------------------------------");

            Gericht b = new Gericht(2, "Gulash", 8.15, "Gemuese, Fleisch, Tomate");
            Gericht c = new Gericht(3, "Schnitzel ", 10.20, "Schnitzel ,Senf, Kaese, Ei, Meerrettich");
            Gericht d = new Gericht(4, "Rindsschmorbraten mit Essig und Rahm", 9.10, "Rinderbraten, Butter, Mehl, Zwiebel, Essig, Salz");

            Getraenk e = new Getraenk(5, "Orangensaft", 2.55, "Frei");
            Getraenk f = new Getraenk(6, "Soda", 1.85, "frei");
            Getraenk g = new Getraenk(7, "Weiss Wein", 5.45, "mit Alkohol");

            List<Ware> tasks = new List<Ware>();
            tasks.Add(a);
            tasks.Add(b);
            tasks.Add(c);
            tasks.Add(d);
            tasks.Add(e);
            tasks.Add(f);
            tasks.Add(g);






            var source = new Subject<Ware>();

            source
                .Sample(TimeSpan.FromSeconds(2))
                .Subscribe(x => Console.WriteLine($"received:\n{x.getDetails()}\n-------------------------"))                            
                ;
            

            var t = new Thread(() =>
            {
                while (true)
                {
                    Random r = new Random();
                    Ware w = tasks[r.Next(6)];
                    Thread.Sleep(500);
                    source.OnNext(w);
                    Console.WriteLine("sent:");
                    w.Write();
                    Console.WriteLine("-------------------------");
                    //i++;
                }
            });
            t.Start();
        }
    }
}

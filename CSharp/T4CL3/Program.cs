using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4CL3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Buch> buecherliste = new List<Buch>();
            
            buecherliste.Add(new Buch { InventarNr = "001", Titel = "A-Titel", Autor = "E-Autor", Erscheinungsjahr = 2010, Verlag = "A-Verlag" });
            buecherliste.Add(new Buch { InventarNr = "002", Titel = "C-Titel", Autor = "D-Autor", Erscheinungsjahr = 2011, Verlag = "B-Verlag" });
            buecherliste.Add(new Buch { InventarNr = "003", Titel = "E-Titel", Autor = "C-Autor", Erscheinungsjahr = 2012, Verlag = "C-Verlag" });
            buecherliste.Add(new Buch { InventarNr = "004", Titel = "B-Titel", Autor = "B-Autor", Erscheinungsjahr = 2013, Verlag = "D-Verlag" });
            buecherliste.Add(new Buch { InventarNr = "005", Titel = "D-Titel", Autor = "A-Autor", Erscheinungsjahr = 2014, Verlag = "E-Verlag" });

            // wir verwenden Linq anstelle von IComparable
            List<Buch> sortInventar = buecherliste.OrderByDescending(i => i.InventarNr).ToList();
            List<Buch> sortAutor = buecherliste.OrderByDescending(a => a.Autor).ToList();
            List<Buch> sortErscheinungsjahr = buecherliste.OrderByDescending( e => e.Erscheinungsjahr).ToList();
   
            Console.WriteLine("\nSortierung nach InventarNr (absteigend)");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Inv |  Titel  |  Autor  | Jahr | Verlag");
            Console.WriteLine("---------------------------------------------");
            foreach (Buch b in sortInventar)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("\nSortierung nach Autor (absteigend)");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Inv |  Titel  |  Autor  | Jahr | Verlag");
            Console.WriteLine("---------------------------------------------");

            foreach (Buch b in sortAutor)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("\nSortierung nach Erscheinungsjahr (absteigend)");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Inv |  Titel  |  Autor  | Jahr | Verlag");
            Console.WriteLine("---------------------------------------------");
            foreach (Buch b in sortErscheinungsjahr)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("\n-------------------------------------------");

            Console.WriteLine("\nBeliebige Taste drücken!");

            Console.ReadKey();
        }
    }
}

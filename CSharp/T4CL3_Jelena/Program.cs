using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Buch> buecherListe = new List<Buch>();

            buecherListe.Add(new Buch ( "2201", "Wenn der Vater mit dem Sohne", "Phillip Peters", 1990,"ARGE Vater&Sohn"));

            buecherListe.Add(new Buch ( "2230", "Lena und die Wölfe", "Christine Nöstlinger", 2004, "btb-Verlag"));

            buecherListe.Add(new Buch ( "7001", "Rosamunde Pilcher", "Anton Unbekannt", 1988, "Nostalgie"));

            buecherListe.Add(new Buch ( "3360", "Der Cellist von Sarajevo", "Steven Galloway", 2010, "Random House"));
 
            buecherListe.Add(new Buch ( "0328", "Edgar Allan", "John Neufeld", 1999, "Penguin Putnam Books"));

            buecherListe.Add(new Buch ("9872", "Leben zwischen den Seiten", "Corinna Soria", 2002, "Wieser Verlag"));

            buecherListe.Add(new Buch ( "6654", "Verführungen", "Marlene Streeruwitz", 2004, "Fischer Taschenbuch Verlag"));

            buecherListe.Sort(new InventarnummerSortierung());
            Console.WriteLine("Sortierung nach Inventarnummer:");
            foreach (Buch b in buecherListe)
                Console.WriteLine(b);

            Console.WriteLine();
            Console.WriteLine();

            buecherListe.Sort(new AutorSortierung());
            Console.WriteLine("Sortierung nach Autor:");
            foreach (Buch a in buecherListe)
                Console.WriteLine(a);

            Console.WriteLine();
            Console.WriteLine();

            buecherListe.Sort(new ErscheinungsjahrSortierung());
            Console.WriteLine("Sortierung nach Erscheinungsjahr:");
            foreach (Buch c in buecherListe)
                Console.WriteLine(c);


        }
    }
}

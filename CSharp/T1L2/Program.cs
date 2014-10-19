using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1L2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------
            // Header
            // ----------------------------------------------
            Console.WriteLine("#############################");
            Console.WriteLine("Übung    : T1L2");
            Console.WriteLine("Autor    : Pellegrini Roland");
            Console.WriteLine("#############################");

            // ----------------------------------------------
            // Definition von Variablen
            // ----------------------------------------------
            string input = "";
            int n = 0;
            int f = 1;

            // ----------------------------------------------
            // Eingabe der Daten
            // ----------------------------------------------
            Console.Write("Eingabe von N!  : ");
            input = Console.ReadLine();
            n = Convert.ToInt32(input);

            // ----------------------------------------------
            // Berechnung n! = n * (n-1) * (n-2) * ... * 1
            // ----------------------------------------------
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }

            // ----------------------------------------------
            // Ausgabe der Daten
            // ----------------------------------------------
            Console.WriteLine("Ergebnis von N! : " + f);

        }
    }
}

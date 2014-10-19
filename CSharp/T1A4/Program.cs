using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1A4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------
            // Header
            // ----------------------------------------------
            Console.WriteLine("#############################");
            Console.WriteLine("Übung    : T1A4");
            Console.WriteLine("Autor    : Pellegrini Roland");
            Console.WriteLine("#############################");

            // ----------------------------------------------
            // Definition der Variablen
            // ----------------------------------------------
            int max = 30;
            int[] fibonacci = new int[max];

            // ----------------------------------------------
            // Berechnung und Speicherung in Array
            // ----------------------------------------------
            //
            // Array Dimension beginnt bei 0
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < max; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            // ----------------------------------------------
            // Ausgabe Arrayinhalt
            // ----------------------------------------------
            for (int i = 0; i < max; i++)
            {
                if (i > 8)
                    Console.Write((i + 1) + ". Fibo Zahl");
                else
                    Console.Write(" " + (i + 1) + ". Fibo Zahl");

                Console.WriteLine(" --> " + fibonacci[i]);
            }
        }
    }
}


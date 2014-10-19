using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1I2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------
            // Header
            // ----------------------------------------------

            Console.WriteLine("#############################");
            Console.WriteLine("Übung    : T1I2");
            Console.WriteLine("Autor    : Pellegrini Roland");
            Console.WriteLine("#############################");

            // ----------------------------------------------
            // Definition and Initialisierung von Variablen
            // ----------------------------------------------

            string input = "" ;
            int betrag = 500;

            // ----------------------------------------------
            // 
            // ----------------------------------------------

            Console.Write("Sind Sie verheiratet (j/n) ? ");
            input = Console.ReadLine();
            if (input == "j" || input == "J")
            {
                betrag = betrag - 100; // betrag -= 100 ;
            }

            Console.Write("Sind Sie Student (j/n) ? ");
            input = Console.ReadLine();
            if (input == "j" || input == "J")
            {
                betrag = betrag - 200; // betrag -= 200 ;
            }

            // ----------------------------------------------
            // 
            // ----------------------------------------------

            Console.WriteLine("\nMitgliedsbeitrag : " + betrag);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2K7
{
    class Program
    {
        static void Main(string[] args)
        {

            Konto konto = new Konto("Anton", 0, -1000);

            double taschengeld = 500; 
            konto.Einzahlen( taschengeld );
            Console.WriteLine("Kontostand nach Einzahlung von {0}: ", taschengeld);
            konto.Drucken();

            Console.WriteLine("");

            taschengeld = 1000 ;
            Console.WriteLine("Kontostand nach Abhebung von {0}: ", taschengeld);
            konto.Abheben( taschengeld );
            konto.Drucken();

            Console.WriteLine("");

            taschengeld = 400;
            Console.WriteLine("Kontostand nach Abhebung von {0}: ", taschengeld);
            konto.Abheben(taschengeld);
            konto.Drucken();

            Console.WriteLine("");

            taschengeld = 101;

            if ( konto.Abheben(taschengeld) )
            {
                Console.WriteLine("Kontostand nach Abhebung von {0}: ", taschengeld);
            }
            else
            {
                Console.WriteLine("Abbuchung von {0} konnte nicht durchgeführt werden.", taschengeld);
                Console.WriteLine("da Überziehungsrahmen überschritten wurde.");
                Console.WriteLine("Siehe max. verfügbaren Betrag laut Kontoauszug");
            }

            konto.Drucken();


        }
    }
}

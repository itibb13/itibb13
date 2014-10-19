using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1O6
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------
            // Header
            // ----------------------------------------------

            Console.WriteLine("#############################");
            Console.WriteLine("Übung    : T1O6");
            Console.WriteLine("Autor    : Pellegrini Roland");
            Console.WriteLine("#############################");

            // ----------------------------------------------
            // Definition and Initialisierung von Variablen
            // ----------------------------------------------

            string input = "" ;
            double preisBrutto = 0.0 ;
            double preisNetto = 0.0 ;
            double mwstSatz = 0.0 ;
            double betragMWST = 0.0 ;

            // ----------------------------------------------
            // Definierte Werte anzeigen
            // ----------------------------------------------

            Console.WriteLine("\nDefinitionen      :\n--------------------");
            Console.WriteLine("<Keine spezifischen Definitionen vorhanden>");

            // ----------------------------------------------
            // Daten eingeben
            // ----------------------------------------------

            Console.WriteLine("\nProgramm Eingaben :\n--------------------");

            Console.Write("Bitte geben Sie den Bruttopreis ein : ");
            input = Console.ReadLine();

            // einfache Prüfung der Eingabe auf Gültigkeit
            if (input.Length != 0)
                preisBrutto = Convert.ToDouble(input);
            else
                preisBrutto = 0.0;

            Console.Write("Bitte geben Sie den MWST Satz (ohne %) ein : ");
            input = Console.ReadLine();
            
            // einfache Prüfung der Eingabe auf Gültigkeit
            if (input.Length != 0)
                mwstSatz = Convert.ToDouble(input);
            else
                mwstSatz = 0.0;

            // ----------------------------------------------
            // Saten ausgeben
            // ----------------------------------------------

            Console.WriteLine("\nProgramm Ausgaben :\n--------------------");

            preisNetto = preisBrutto / ((100 + mwstSatz) / 100);
            Console.WriteLine("Nettobetrag  : " + preisNetto);

            betragMWST = preisBrutto - preisNetto;
            Console.WriteLine("MWST Betrag  : " + betragMWST);

            Console.WriteLine("--------------------");
            Console.WriteLine("Bruttobetrag : " + preisBrutto);
            Console.WriteLine("\n");

        }
    }
}

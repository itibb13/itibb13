using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1O12
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------
            // Header
            // ----------------------------------------------

            Console.WriteLine("#############################");
            Console.WriteLine("Übung    : T1O12");
            Console.WriteLine("Autor    : Pellegrini Roland");
            Console.WriteLine("#############################");

            // ----------------------------------------------
            // Definition and Initialisierung von Variablen
            // ----------------------------------------------
            
            const double stdProWoche = 38.5 ;
            const int wochenProMonat = 4 ;

            double ueberStundenSatz50 = 0.0 ;
            double ueberStundenSatz100 = 0.0 ;
 
            double stundenSatz = 0.0 ; 

            double grundGehalt = 0.0 ; 
            double zuschlag50 = 0.0 ;
            double zuschlag100 = 0.0 ;

            double gesamtAuszahlungsbetrag = 0.0 ;
            
            string input = "" ; 

            // ----------------------------------------------
            // Definierte Werte anzeigen
            // ----------------------------------------------

            Console.WriteLine("\nDefinitionen      :\n--------------------");
            Console.WriteLine("Stunden pro Woche : " + stdProWoche);
            Console.WriteLine("Wochen pro Monat  : " + wochenProMonat);
            Console.WriteLine("Stunden pro Monat : " + (stdProWoche * wochenProMonat) );

            // ----------------------------------------------
            // Daten eingeben
            // ----------------------------------------------

            Console.WriteLine("\nProgramm Eingaben:\n--------------------");
            Console.Write("Bitte geben Sie den StundenSatz ein : "); 
            input = Console.ReadLine();
           
            // einfache Prüfung der Eingabe auf Gültigkeit
            if (input.Length != 0)
                stundenSatz = Convert.ToDouble(input);
            else
            {
                stundenSatz = 1.0; // gesetzlich vorgeschriebener mindestlohn !!! 
                Console.WriteLine("Es gilt der gesetzliche Mindestlohn : " + stundenSatz);
            }

            Console.Write("Bitte geben Sie die Anzahl der 50% Überstunden ein : ");
            input = Console.ReadLine();

            // einfache Prüfung der Eingabe auf Gültigkeit
            if (input.Length != 0)
                ueberStundenSatz50 = Convert.ToDouble(input) ;
            else
                ueberStundenSatz50 = 0.0 ;
 
            Console.Write("Bitte geben Sie die Anzahl der 100% Überstunden ein : ");
            input = Console.ReadLine();
            
            // einfache Prüfung der Eingabe auf Gültigkeit
            if (input.Length != 0)
                ueberStundenSatz100 = Convert.ToDouble(input);
            else
                ueberStundenSatz100 = 0.0 ;

            // ----------------------------------------------
            // Daten berechnen
            // ----------------------------------------------

            grundGehalt = stundenSatz * stdProWoche * wochenProMonat;
            zuschlag50 = stundenSatz * ueberStundenSatz50 * 1.5 ;
            zuschlag100 = stundenSatz * ueberStundenSatz100 * 2;

            gesamtAuszahlungsbetrag = grundGehalt + zuschlag50 + zuschlag100;

            // ----------------------------------------------
            // Daten ausgeben
            // ----------------------------------------------

            Console.WriteLine("\nProgramm Ausgabe:\n--------------------");

            Console.WriteLine("Grundgehalt               : " + grundGehalt);
            Console.WriteLine("Zuschlag  50% Überstunden : " + zuschlag50);
            Console.WriteLine("Zuschlag 100% Überstunden : " + zuschlag100);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Auszahlungsbetrag         : " + gesamtAuszahlungsbetrag);
            Console.WriteLine("\n");
        }
    }
}

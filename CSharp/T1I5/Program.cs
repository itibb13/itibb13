using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1I5
{
    class Program
    {
        static void Main(string[] args)
        {
            int tagnummer;

            Console.WriteLine("Geben Sie den Tag als Zahl an:");
            string tag = Console.ReadLine();
            int t = Convert.ToInt32(tag);

            Console.WriteLine("Geben Sie den Monat als Zahl an: ");
            string monat = Console.ReadLine();
            int m = Convert.ToInt32(monat);

            Console.WriteLine("Geben Sie das Jahr an: ");
            string jahr = Console.ReadLine();
            int j = Convert.ToInt32(jahr);

            /*
             * rap:
             * ich habe zwei Abfragen eingebaut. 
             * ich habe diese abfrage aber auskommentiert,
             * weil wir unten schon eine eingebaut haben
             * 
             * Diese Abfrage unterscheidet sich 
             * von der Abfrage weiter unten durch das ODER:
             */
            /*if (j < 1601 || j > 2399)
            {
                Console.WriteLine("Das Jahr liegt nicht innerhalb des");
                Console.WriteLine("1601 und 2399. Daher Programmabbruch!");
                return; // hier steigen wir aus der Main-Methode aus !!!!
                // daher ist das gleichzeitig auch das Programm-ende
            }
            */

            // rap
            // diese variante checkt, ob
            // die jahreszahl innerhalb 1601 und 2399 befindet
            //
            // Achtung: Diese Abfrage unterscheidet sich 
            // von der Abfrage oben durch das UND und liest sich so:
            //
            // wenn j größer_gleich 1601 UND j kleiner_gleich 2399 ist,
            // dann rechne die Tagesnummer aus,
            // sonst (weiter unten) stoppe das Programm
            if (j >= 1601 && j <= 2399) // <<<<<< das ist neu, bereich geht bis zur zeile 80
            {
                if (m < 3)
                {
                    tagnummer = t + 31 * m - 31;

                    Console.WriteLine("Die Tagesnummer: " + tagnummer);
                }

                else if ((m >= 3) && ((j % 4) == 0) || (j % 400 == 0))
                {
                    tagnummer = t + (153 * m - 162) / 5;
                    Console.WriteLine("Die Tagesnummer: " + tagnummer);
                }

                else if ((m >= 3) || (j % 100 == 0))
                {
                    tagnummer = t + (153 * m - 162) / 5 + 1;
                    Console.WriteLine("Die Tagesnummer: " + tagnummer);
                }

                else if ((j < 1601) || (j > 2399))
                {
                    Console.WriteLine("ungültige Jahreseingabe");
                }
            }// end of "if (j >= 1601 || j <= 2399)"
            else
                Console.WriteLine("Datum ist ausserhalb des erlaubten Bereiches.");
        } 
        
        }
    }


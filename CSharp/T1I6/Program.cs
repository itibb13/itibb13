using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1I6
{
    class Program
    {
        static void Main(string[] args)
        {

            // ----------------------------------------------
            // Header
            // ----------------------------------------------
            Console.WriteLine("#############################");
            Console.WriteLine("Übung    : T1I6");
            Console.WriteLine("Autor    : Pellegrini Roland");
            Console.WriteLine("#############################");

            // ----------------------------------------------
            // Definition der Variablen
            // ----------------------------------------------
            string input = "";
            double jahresGehalt = 0.0;
            double steuerBetrag = 0.0;

            // ----------------------------------------------
            // Eingabe der Daten
            // ----------------------------------------------
            Console.Write("Geben Sie das Jahresgehalt ein : ");
            input = Console.ReadLine();
            jahresGehalt = Convert.ToDouble(input);

            // ----------------------------------------------
            // Berechnung der Daten
            // ----------------------------------------------
            if (jahresGehalt >= 60001)
            {
                steuerBetrag = (jahresGehalt - 60000) * 0.5 + 20235;
            }
            else 
                if (25001 <= jahresGehalt && jahresGehalt <= 60000)
                {
                    steuerBetrag = (jahresGehalt - 25000)/35000 * 15125 + 5110;
                }
                else 
                    if (11001 <= jahresGehalt && jahresGehalt <= 25000)
                    {
                        steuerBetrag = (jahresGehalt - 11000) / 14000 * 5110;
                    }

            // ----------------------------------------------
            // Ausgabe der Daten
            // ----------------------------------------------
            Console.WriteLine("Steuerbetrag : " + Math.Round(steuerBetrag,2) );
            Console.WriteLine("Steuersatz   : " + Math.Round(steuerBetrag/jahresGehalt*100,2) );

        }
    }
}

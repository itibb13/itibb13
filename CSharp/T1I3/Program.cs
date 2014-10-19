using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1I3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------
            // Header
            // ----------------------------------------------

            Console.WriteLine("#############################");
            Console.WriteLine("Übung    : T1I3");
            Console.WriteLine("Autor    : Pellegrini Roland");
            Console.WriteLine("#############################");

            // ----------------------------------------------
            // Definition and Initialisierung von Variablen
            // ----------------------------------------------

            string input = "";
            double einkaufsBetrag  = 0;
            double rabatt = 0;
            double reduzierterBetrag = 0;

            // ----------------------------------------------
            // 
            // ----------------------------------------------

            Console.Write("Geben Sie den Einkaufsbetrag ein : ");
            input = Console.ReadLine();
            einkaufsBetrag = Convert.ToDouble(input);

            if (einkaufsBetrag < 100)
            {
                rabatt = 0;
            } 
            else
                if (einkaufsBetrag >= 100 && einkaufsBetrag < 200)
                {
                    rabatt = 0.03;
                }
                else
                    if (einkaufsBetrag >= 200 && einkaufsBetrag < 300)
                    {
                        rabatt = 0.08;
                    }
                    else
                        if (einkaufsBetrag >= 300 && einkaufsBetrag < 500)
                        {
                            rabatt = 0.14;
                        }
                        else
                            rabatt = 0.20;

            reduzierterBetrag = einkaufsBetrag - einkaufsBetrag * rabatt ;

            Console.WriteLine("Rabatt in Prozent : " + rabatt * 100);

            Console.WriteLine("Rabatt in Euro    : " + (einkaufsBetrag * rabatt) );
 
            Console.WriteLine("Reduzierter Preis : " + reduzierterBetrag);
 

            // ----------------------------------------------
            // 
            // ----------------------------------------------


            // ----------------------------------------------
            // 
            // ----------------------------------------------

        }
    }
}

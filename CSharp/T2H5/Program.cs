using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zeigt Header an
            ITIBB.ExerciseInfo.Print("T2H5", "Pellegrini Roland");

            // ----------------------------------------------
            // ----------------------------------------------

            // Klassenhierarchie
            // Die klassenhierarchie sieht bei mir so aus: 
            //
            // Fahrzeug (=abstrakte Superklasse)
            // +--> PKW (=abstrakt) 
            //      +--> Limousine
            //      +--> Cabrio
            //      +--> Van
            // +--> LKW (=abstrakt)
            //      +--> Kastenwagen
            //      +--> Pritschenwagen
            //
            //

            Fahrzeug[] fuhrpark = new Fahrzeug[5];

            fuhrpark[0] = new Limousine("VW Passat", 100, 2000, 5);
            fuhrpark[1] = new Cabrio("VW Cabrio", 101, 2001, 4, 5.4);
            fuhrpark[2] = new Van("VW T3", 102, 2002, 7);
            fuhrpark[3] = new Kastenwagen("VW Kastenwagen", 103, 2003, 1000);
            fuhrpark[4] = new Pritschenwagen("VW Pritschenwagen", 104, 2004, 1000, false);

            // einfach ausgeben, leerzeile nicht vergessen
            foreach (Fahrzeug kfz in fuhrpark)
            {
                kfz.Drucken();
                Console.WriteLine("");
            }
            
        }
    }
}

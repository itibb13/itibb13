using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2K15___Mitarbeiter
{
    class Program
    {
        static void Main(string[] args)
        {
            // benutzerdefinierter Datentyp MITARBEITER
            Mitarbeiter Franz = new Mitarbeiter ("Franz", "Mayer",1000);
            Franz.Drucken();

            Console.WriteLine(); // leerzeile
            
            Mitarbeiter Sepp = new Mitarbeiter("Josef", "Huber", 2000);
            Sepp.Drucken();

            //gehalt = gehalt + gehalt * 0.15
            //gehalt = gehalt / 100 * 115;

            Console.WriteLine("\nNach der Gehaltserhöhung bekommt ... \n"); // leerzeile

            double altesGehalt = Franz.Monatsgehalt;
            double neuesGehalt = altesGehalt + altesGehalt * 0.15;
            Franz.Monatsgehalt = neuesGehalt;
            Franz.Drucken();
            
            Console.WriteLine(); // leerzeile
            
            double altesGehalt2 = Sepp.Monatsgehalt;
            double neuesGehalt2 = altesGehalt2 + altesGehalt2 * 0.03;
            Sepp.Monatsgehalt = neuesGehalt2;
            Sepp.Drucken();

            // Sepp.Gehaltserhöhung(0.10);
            // Sepp.Drucken();

        }
    }

    /*
     +Mitarbeiter (v : string, n : string, g : double)
     +SetVorname (v : string )
     +SetNachname (n : string )
     +SetGehalt (g : double)

     +GetNachname() : string
     +GetVorname(): string
     +GetGehalt() : double

     +Drucken() : void
     */

    class Mitarbeiter
    {
        private string vorname;
        private string nachname;
        private double monatsgehalt;

        public Mitarbeiter(string vname, string nname, double mgehalt)
        {
            vorname = vname;
            nachname = nname;
            monatsgehalt = mgehalt;
        }

         public string Vorname {
            get { return vorname;}
            set { vorname = value; }
        } // end getter-setter

         public string Nachname
         {
             get { return nachname; }
             set { nachname = value; }
         } // end getter-setter

         public double Monatsgehalt
         {
             get { return monatsgehalt; }
             set { monatsgehalt = value; }
         } // end getter-setter


         public void Drucken()
         {
             Console.WriteLine("Name        : " + vorname + " " + nachname);
             Console.WriteLine("Monatsgehalt: " + monatsgehalt);
             Console.WriteLine("Jahresgehalt: " + monatsgehalt * 14 );
         }

        /*
         public void Jahresgehalt()
         {
             Console.WriteLine("Jahresgehalt: " + monatsgehalt * 14 );
         }
        */
        
        /*
        public void Gehaltserhöhung (double erhoehung)
        {
            monatsgehalt = monatsgehalt + monatsgehalt * erhoehung ;
        }
        */
    } // end class
  
} // end namespace


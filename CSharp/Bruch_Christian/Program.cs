using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roland___B2_Bruch
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Geben Sie den Zähler ein: ");
            int Zaehler = Convert.ToInt16(Console.ReadLine());
            
            Console.Write("Geben Sie den Nenner ein: ");
            int Nenner = Convert.ToInt16(Console.ReadLine());

            Bruch Berechnung = new Bruch (Zaehler, Nenner);

            Berechnung.Drucken();

            Console.ReadKey();
        }
    }   // end class program




    class Bruch
    {   // Instanzvariablen
        private int zaehler;
        private int nenner;

        // Konstruktor
            public Bruch (int z, int n)
            {
                zaehler = z;
                nenner = n;
            }
            
        // Methoden
            public int Nenner
            {    
                get { return nenner; }
                set { nenner = value; }
            }
           
            public int Zaehler
            {
                get { return zaehler; }
                set { zaehler = value; }
            }

        // Ausgabe
            public void Drucken()
            {

                double e = zaehler/nenner;
                double r;
                r = zaehler - (e * nenner);

                Console.WriteLine("Das Ergebnis lautet: " + e + " Ganze und " +r+ "/"+nenner);
            }
    }   // end class Bruch
   
}       // end namespace

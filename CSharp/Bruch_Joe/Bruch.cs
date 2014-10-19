using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruchrechnen
{
    class Bruch
    {
        // Instanzvariablen
        private int zaehler;
        private double nenner;
        private double ergebnis;

        // Konstruktor
        public Bruch(int z, double n)
        {
            zaehler = z;
            nenner = n;
            ergebnis = 0;
        }

        public double Division()
        {
            ergebnis = zaehler / nenner;
            return ergebnis;
        }

        public double Nenner
        {
            get { return nenner; }
            set { nenner = value; }
        }

        public int Zaehler
        {
            get { return zaehler; }
            set { zaehler = value; }
        }

        public void Darstellen()
        {
            Console.Clear();
            Console.WriteLine("####################################################################");
            Console.WriteLine("Der Bruch " + zaehler + " / " + nenner + " hat {0:F4} zum Ergebnis.", ergebnis);
            Console.WriteLine("####################################################################");
        }
    }
}

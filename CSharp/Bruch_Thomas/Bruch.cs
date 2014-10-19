using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruch
{
    class Bruch
    {
        private double zaehler;
        private double nenner;

        public Bruch(double z, double n){
            this.nenner = n;
            this.zaehler = z;
        }

        public double Nenner {
            get { return nenner; }
            set { nenner = value; }
        }
        public double Zaehler
        {
            get { return zaehler; }
            set { zaehler = value; }
        }

        public double Berechnen() {
            double Ergebnis = zaehler / nenner;
            return Ergebnis;
        }

        public void Ausgabe() {
            Console.WriteLine("Der Bruch lautet:" + zaehler +"/"+nenner +" = " + zaehler/nenner);
        }
    }
}

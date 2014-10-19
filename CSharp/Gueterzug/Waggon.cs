using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gueterzug
{
    abstract class Waggon
    {
        private int achsen;
        private double eigengewicht;

        public Waggon (int achsen, double eigengewicht)
        {
            this.achsen = achsen;
            this.eigengewicht = eigengewicht;
        }

        public int Achsen { get { return this.achsen; } }
        public double Eigengewicht { get { return this.eigengewicht; } }

        public abstract double MaximalGewicht();

        public virtual void Drucken()
        {
            Console.WriteLine("Anzahl der Achsen : " + this.achsen);
            Console.WriteLine("Eigengewicht      : " + this.eigengewicht);
        }


    }
}

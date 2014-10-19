using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gueterzug
{
    class Silowaggon : Waggon
    {

        private double liter;
        public Silowaggon(int achsen, double eigengewicht, double liter ) : base (achsen, eigengewicht)
        {
            this.liter = liter;
        }


        public override double MaximalGewicht()
        {
            return (base.Eigengewicht + (this.liter * 0.001) );
        }

        public override void Drucken()
        {
            Console.WriteLine("SILOWAGGON:");
            base.Drucken();
            Console.WriteLine("Max Liter im Tank : " + this.liter);
            Console.WriteLine("Gesamtgewicht     : " + this.MaximalGewicht() );
        }
    }
}

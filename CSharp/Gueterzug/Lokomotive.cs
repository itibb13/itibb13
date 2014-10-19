using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gueterzug
{
    class Lokomotive : Waggon
    {

        public Lokomotive(int achsen, double eigengewicht ) : base (achsen, eigengewicht)
        {}



        public override double MaximalGewicht()
        {
            return base.Eigengewicht;
        }
        public override void Drucken()
        {
            Console.WriteLine("LOKOMOTIVE:");
            base.Drucken();
        }
    }
}

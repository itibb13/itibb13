using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gueterzug
{
    class Gueterwaggon  : Waggon
    {
        private double ladung;
        public Gueterwaggon(int achsen, double eigengewicht, double ladung ) : base (achsen, eigengewicht)
        {
            this.ladung = ladung;
        }


        public override double MaximalGewicht()
        {
            return (base.Eigengewicht + this.ladung);
        }

        public override void Drucken()
        {
            Console.WriteLine("GUETERWAGGON:");
            base.Drucken();
            Console.WriteLine("Maximal Ladung    : " + this.ladung);
            Console.WriteLine("Gesamtgewicht     : " + this.MaximalGewicht());
        }
    }
}

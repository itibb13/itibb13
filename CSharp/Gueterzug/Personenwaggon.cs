using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gueterzug
{
    class Personenwaggon : Waggon
    {
        private int passagiere;

        public Personenwaggon(int achsen, double eigengewicht, int passagiere ) : base (achsen, eigengewicht)
        {
            this.passagiere = passagiere;
        }

        public override double MaximalGewicht()
        {
            // achtung: kg in tonnen umwandeln
            return (base.Eigengewicht + (this.passagiere * 0.075 ) );
        }

        public override void Drucken()
        {
            Console.WriteLine("PERSONENWAGGON:");
            base.Drucken();
            Console.WriteLine("Max Passagiere    : " + this.passagiere);
            Console.WriteLine("Gesamtgewicht     : " + this.MaximalGewicht());
        }
    }
}

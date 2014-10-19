using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H7
{
    class CEO : BonusMA
    {
        int option; //erhält einen einmaligen Zuschlag am Ende des Jahres

        public CEO(int pe, string na, string ad, int ei, double st, double b, int o)
            : base(pe, na, ad, ei, st, b)
        {
            option = o;
        }

        public override double Monatslohn()
        {
            return (base.Monatslohn() + option);
        }

        public override void Drucken()
        {
            Console.WriteLine("\nCEO:");
            base.Drucken();
            Console.WriteLine("Erhält zusätzlich zum Bonus einen einmaligen Zuschlag am Ende des Jahres in Höhe von " + option + " Euro");
        }

    }
}

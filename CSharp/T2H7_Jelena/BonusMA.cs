using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H7
{
    class BonusMA : Mitarbeiter
    {
        double bonus;

        public BonusMA(int pe, string na, string ad, int ei, double st, double b)
            : base(pe, na, ad, ei, st)
        {
            bonus = b;
        }

        public override double Monatslohn()
        {
            double ml = base.Monatslohn();
            double molohn = (ml + bonus);
            return molohn;

        }

        public override void Drucken()
        {
            base.Drucken();
            Console.WriteLine("Erhält Bonus in Höhe von: " + bonus + " Euro");
        }
    }
}

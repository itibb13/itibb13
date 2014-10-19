using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H7
{
    class Manager : BonusMA
    {
        public Manager(int pe, string na, string ad, int ei, double st, double b)
            : base(pe, na, ad, ei, st, b)
        { }

        public override void Drucken()
        {
            Console.WriteLine("\nManager:");
            base.Drucken();
        }
    }
}

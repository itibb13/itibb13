using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H7
{
    class Angestellter : Mitarbeiter
    {
        public Angestellter(int p, string n, string a, int e, double s)
            : base(p, n, a, e, s)
        { }

        public override void Drucken()
        {
            Console.WriteLine("\nAngestellte:");
            base.Drucken();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H7
{
    class Arbeiter : Mitarbeiter
    {
        double schichtzulage;

        public Arbeiter(int p, string n, string a, int e, double s, double sch)
            : base(p, n, a, e, s)
        {
            schichtzulage = sch;
        }

        public override double Monatslohn()
        {
            return (base.Monatslohn() + schichtzulage);
        }

        public override void Drucken()
        {
            Console.WriteLine("\nArbeiter:");
            base.Drucken();
            Console.WriteLine("Erhält eine Schichtzulage in Höhe von " + schichtzulage + " Euro");

        }



    }
}

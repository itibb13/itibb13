using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Hofmann
namespace T2H5___Kraftfahrzeug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("T2H5 Kraftfahrzeug Hofmann" );
            Console.WriteLine("-----------------------------");
            Kfz[] auto = new Kfz[5];
            auto[0] = new Limousine("Limousine", 400, 2005, 7);
            auto[1] = new Cabrio("Cabrio", 350, 2000, 2, "10:00 - 15:00");
            auto[2] = new Van("Van", 140, 2010, 4);
            auto[3] = new Kastenwagen("Kastenwagen", 120, 1995, 500);
            auto[4] = new Pritschenwagen("Pritschenwagen", 130, 2004, 500, true);

            foreach (Kfz k in auto)
                k.Drucken();



        }
    }
    abstract class Kfz
    {
        private string modellname;
        private int leistung;
        private int baujahr;

        public Kfz(string mn, int l, int bj)
        {
            this.modellname = mn;
            this.leistung = l;
            this.baujahr = bj;
        }
        public virtual void Drucken()
        {
            Console.WriteLine("\nModellname: " + modellname);
            Console.WriteLine("Leistung: " + leistung + " PS");
            Console.WriteLine("Baujahr: " + baujahr);
        }
    }

    abstract class Personentransport : Kfz
    {
        private int anzP;
        public Personentransport(string mn, int l, int bj, int anzP)
            : base(mn, l, bj)
        {
            this.anzP = anzP;
        }
        public override void Drucken()
        {
            base.Drucken();
            Console.WriteLine("Die Anzahl der Personen beträgt: " + anzP);
        }
    }
    abstract class Nutzauto : Kfz
    {
        private int nutzlast;
        public Nutzauto(string mn, int l, int bj, int nl)
            : base(mn, l, bj)
        {
            this.nutzlast = nl;
        }
        public override void Drucken()
        {
            base.Drucken();
            Console.WriteLine("Die Nutzlast beträgt: " + nutzlast + " kg");
        }
    }
    class Limousine : Personentransport
    {
        public Limousine(string mn, int l, int bj, int anzP) : base(mn, l, bj, anzP) { }
        public override void Drucken()
        {
            base.Drucken();
        }
    }
    class Cabrio : Personentransport
    {
        private string ÖffVerdeck;
        public Cabrio(string mn, int l, int bj, int anzP, string öv)
            : base(mn, l, bj, anzP)
        {
            this.ÖffVerdeck = öv;
        }
        public override void Drucken()
        {
            base.Drucken();
            Console.WriteLine("Die Öffnungzeiten für das Verdeck beträgt: " + ÖffVerdeck);
        }
    }
    class Van : Personentransport
    {
        public Van(string mn, int l, int bj, int anzP) : base(mn, l, bj, anzP) { }
        public override void Drucken()
        {
            base.Drucken();
        }
    }
    class Kastenwagen : Nutzauto
    {
        public Kastenwagen(string mn, int l, int bj, int nl) : base(mn, l, bj, nl) { }
        public override void Drucken()
        {
            base.Drucken();
        }
    }
    class Pritschenwagen : Nutzauto
    {
        private bool kippbar = false;
        public Pritschenwagen(string mn, int l, int bj, int nl, bool kb)
            : base(mn, l, bj, nl)
        {
            this.kippbar = kb;
        }
        public override void Drucken()
        {
            base.Drucken();
            if (kippbar == false) {
                Console.WriteLine("Der Pritschenwagen ist nicht kippbar.");
            }
            else if (kippbar == true)
            {
                Console.WriteLine("Der Pritschenwagen ist kippbar.");
            }
        }
    }
}

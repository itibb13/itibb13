using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H5
{
    //ITIBB13 Scheck
    class Program
    {
        static void Main(string[] args)
        {
            Kraftfahrzeug[] kfz = new Kraftfahrzeug[5];
            kfz[0] = new Limousine("VW Golf", 96, 2003, 5);
            kfz[1] = new Cabrio("Mercedes SL", 325, 2010, 4, 300);
            kfz[2] = new Van("Fiat Doblo", 90, 2005, 9);
            kfz[3] = new Kastenwagen("VW Transporter", 105, 2003, 750);
            kfz[4] = new Pritschenwagen("VW Amarok", 220, 2011, 750, "ja");

            foreach (Kraftfahrzeug k in kfz)
            {
                k.Drucken();
            }


        }
    }


    abstract class Kraftfahrzeug
    {
        private string modellname;
        private int leistung;
        private int baujahr;

        public Kraftfahrzeug(string m, int l, int b)
        {
            modellname = m;
            leistung = l;
            baujahr = b;
        }

        public virtual void Drucken()
        {
            Console.WriteLine("Modellname: " +modellname);
            Console.WriteLine("Leistung: " +leistung);
            Console.WriteLine("Baujahr: " +baujahr);

        }

    }

    abstract class Personenfahrzeug : Kraftfahrzeug
    {
        int passagiere;

        public Personenfahrzeug(string m, int l, int b, int p)
            : base(m, l, b)
        {
            passagiere = p;
        }

        public override void Drucken()
        {
            base.Drucken();
            Console.WriteLine("Passagiere: " +passagiere);
        }
    }


    class Limousine : Personenfahrzeug
    {
        public Limousine(string m, int l, int b, int p)
            : base(m, l, b, p)
        {
        }
        public override void Drucken()
        {
            Console.WriteLine("\nLimousine");
            base.Drucken();
           
        }

    }

    class Cabrio : Personenfahrzeug
    {
        double verdeckzeit;

        public Cabrio(string m, int l, int b, int p, double vz)
            : base(m, l, b, p)
        {
            verdeckzeit = vz;
        }
        public override void Drucken()
        {
            Console.WriteLine("\nCabrio");
            
            base.Drucken();
            Console.WriteLine("Verdecköffnungszeit in sek: " + verdeckzeit);
            
            
        }

    }

    class Van : Personenfahrzeug
    {
        public Van(string m, int l, int b, int p)
            : base(m, l, b, p)
        {
        }
        public override void Drucken()
        {
            Console.WriteLine("\nVan");
            base.Drucken();
            
        }

    }

    abstract class Nutzfahrzeug : Kraftfahrzeug
    {
        int nutzlast;

        public Nutzfahrzeug(string m, int l, int b, int nl)
            : base(m, l, b)
        {
            nutzlast = nl;
        }


        public override void Drucken()
        {
            
            base.Drucken();
            Console.WriteLine("Nutzlast: " + nutzlast);
            
        }


    }

    class Kastenwagen : Nutzfahrzeug
    {
        public Kastenwagen(string m, int l, int b, int nl)
            : base(m, l, b,nl)
        {
        }

        public override void Drucken()
        {
            Console.WriteLine("\nKastenwagen");
            base.Drucken();
            
        }

    }

    class Pritschenwagen : Nutzfahrzeug
    {
        string kippbar;
        public Pritschenwagen(string m, int l, int b, int nl, string kb)
            : base(m, l, b,nl)
        {
            kippbar = kb;
        }

        public override void Drucken()
        {
            Console.WriteLine("\nPritschenwagen");
            
            base.Drucken();
            Console.WriteLine("kippbar: " +kippbar);
            
        }

    }



}

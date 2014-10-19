using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H7
{
    class Mitarbeiter
    {
        int personalnr;
        string name;
        string adresse;
        int eintrittsjahr;
        double stundenlohn;

        public Mitarbeiter(int p, string n, string a, int e, double s)
        {
            personalnr = p;
            name = n;
            adresse = a;
            eintrittsjahr = e;
            stundenlohn = s;
        }

        public virtual double Monatslohn()
        {
            double monatslohn = (stundenlohn * 154);
            Console.WriteLine("\nMonatslöhne: ");
            Console.WriteLine("Der Monatslohn von Mitarbeiter/in " + name + " beträgt Euro " + monatslohn);
            return monatslohn;
        }

        public virtual void Drucken()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Adresse: " + adresse);
            Console.WriteLine("Personalnummer: " + personalnr);
            Console.WriteLine("Eintrittsjahr: " + eintrittsjahr);
            Console.WriteLine("Stundenlohn: " + stundenlohn);
        }
    }
}

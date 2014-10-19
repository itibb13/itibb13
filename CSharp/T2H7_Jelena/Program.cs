using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H7
{
    class Program
    {
        static void Main(string[] args)
        {
            double lohnkosten = 0;
            double monatslohn = 0;
            
            CEO ceo = new CEO(01, "Paul P.", "Rosenberg 2, A-3002 Purkersdorf", 1995, 1, 3, 3);
            Manager manager = new Manager(02, "Tom T.", "teststrasse 1, A-7551 Stegersbach", 1999, 14.50, 400);
            Angestellter angestellter = new Angestellter(03, "Katharina K.", "Gartenstr. 33, A-7400 Oberwart", 2000, 10.50);
            Arbeiter arbeiter = new Arbeiter(04, "Doris D.", "Straße 2, A-2565 Weißenbach", 2001, 7.50, 35);

            Mitarbeiter[] mitarbeiter = new Mitarbeiter[4];
            mitarbeiter[0] = ceo;
            mitarbeiter[1] = manager;
            mitarbeiter[2] = angestellter;
            mitarbeiter[3] = arbeiter;

            foreach (Mitarbeiter m in mitarbeiter)
            {
                m.Drucken();
                monatslohn = m.Monatslohn();
                Console.WriteLine("Der Mitarbeiter verdient monatlich " + monatslohn + " Euro");
                lohnkosten = lohnkosten + monatslohn;
            }
            Console.WriteLine("\nMonatliche Lohnkosten:");
            Console.WriteLine("Die monatlichen Gesamtlohnkosten betragen Euro " + lohnkosten);
        }
    }
}

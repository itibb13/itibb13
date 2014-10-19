using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruchrechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##############################################################");
            Console.WriteLine("Dieses Programm errechnet für ganzzahlige Zähler und Nenner \n den Bruch als Kommazahl. \n");
            Console.Write("Bitte geben sie den Zähler ein : ");
            int iZaehler = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Bitte geben sie den Nenner ein: ");
            int iNenner = Convert.ToInt16(Console.ReadLine());
            if (iNenner == 0)
            {
                while (iNenner == 0)
                {
                    Console.WriteLine();
                    Console.Write("Der Nenner darf nicht Null sein! Bitte geben sie einen anderen Nenner ein: ");
                    iNenner = Convert.ToInt16(Console.ReadLine());
                }
            }

            Bruch b1 = new Bruch(iZaehler, iNenner);
            b1.Division();
            b1.Darstellen();
            b1.Nenner = iNenner;
            b1.Zaehler = iZaehler;
            Console.WriteLine("Der Zähler ist " + b1.Zaehler);
            Console.WriteLine("Der Nenner ist " + b1.Nenner);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte einen Zähler eingeben! ");
            double Z =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte einen Nenner eingeben! ");
            double N =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------------------------------");

            Bruch b1 = new Bruch(Z, N);
            b1.Ausgabe();
            //2. Variante zur Ausgabe
            //Console.WriteLine("Der Bruch lautet:" + b1.Zaehler + "/" + b1.Nenner + "=" + b1.Berechnen());
        }
    }
}

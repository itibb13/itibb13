using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1A5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie Ihr Sparguthaben ein: ");
            string s = Console.ReadLine();
            double kapital = Convert.ToDouble(s);

            Console.WriteLine("Geben Sie Ihren Zisantz ein: ");
            string z = Console.ReadLine();
            double zinsatz = Convert.ToDouble(z);

            double[] SparArray = new double[10];

            double kapitalNeu = kapital;

            for (int i = 0; i < 10; i++)
            {
                kapitalNeu = kapitalNeu + ((kapital * zinsatz * 360) / 36000);

                SparArray[i] = kapitalNeu;

                Console.WriteLine("Ihr Sparguthaben für das Jahr: " + (i + 1) + " beträgt: " + kapitalNeu + "Euro");
            }
        }
    }
}

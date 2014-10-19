using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roland___Celsius_Fahrenheit_Umrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 101;
            double[] Celsius = new double[max];

            Celsius[0] = 32;
            // Celsius[1] = (1 * 1.8) + 32;
            //int i;

            for (int i = 1; i < max; i++)
            {
                Celsius[i] = (i * 1.8) + 32;
            }

            Console.Write(" Bitte um Eingabe der Grad Celsius (0-100): ");
            int Eingabe = Convert.ToInt16(Console.ReadLine());

            if (Eingabe < 0 || Eingabe > 100)
            {

                Console.Write("\n Eingabe falsch. \n Bitte nur von 0-100 Grad.");
                Console.Write("\n Bitte um Eingabe der Grad Celsius (0-100): ");
                Eingabe = Convert.ToInt16(Console.ReadLine());     
            }

            else

                Console.WriteLine("\n Ihre Eingabe in Grad Celsius    : " + Eingabe);
                Console.WriteLine(" ergibt umgerechnet in Fahrenheit: " + Celsius[Eingabe]);
                
            Console.ReadKey();
         }
    }       // end class
}

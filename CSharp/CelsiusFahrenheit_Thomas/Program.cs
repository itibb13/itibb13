using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_Fahrenheit_neu
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[100];

            for (int i = 0; i < array.Length; i++)
            {

                array[i] = i * 1.8 + 32;
           }  
            foreach (double x in array)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Bitte geben sie einen Celsiuswert ein:");

            // rap: begin of changes
            int c = Convert.ToInt32(Console.ReadLine());
            if ( c >= 0 && c <= 100)
                Console.WriteLine("Die Fahrenheit beträgt:" + array[c]);
            else
                Console.WriteLine("Falsche Eingabe. Programmabbruch");
            /*
            double c= Convert.ToDouble(Console.ReadLine());
            double f = c * 1.8 + 32;

            for (int i = 0; i < array.Length; i++) {
                if (f == array[i]) {
                    Console.WriteLine("Die Fahrenheit beträgt:" + array[i]);
                }
            } */

            // rap: end of changes
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write ("Please enter a number to square : ");
            string input = Console.ReadLine();
            double d = Convert.ToDouble(input);
            double result = d*d;
            Console.WriteLine("Square number : " + result);
        }
    }
}

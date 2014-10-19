using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1K1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert an Integer : ");
            string input = Console.ReadLine();
            int i = Convert.ToInt32(input);
            Console.WriteLine("You entered the following integer: " + i);

            Console.Write("Please insert a Double : ");
            input = Console.ReadLine();
            double d = Convert.ToDouble(input);
            Console.WriteLine("You entered the following double: " + d);

            Console.Write("Please press a Key : ");
            input = Console.ReadLine();
            char c = Convert.ToChar(input);
            Console.WriteLine("You entered the following double: " + c);

        }
        /*
        private void Display (String param)
        {
            Console.WriteLine(param);

        }
        */
    }
}

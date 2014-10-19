using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert the amounts of tickets : ");
            string input = Console.ReadLine();
            int amount = Convert.ToInt32(input);

            Console.Write("Please insert the price of a single ticket : ");
            input = Console.ReadLine();
            int price = Convert.ToInt32(input);

            Console.Write("Please insert the discount for one ticket (without %): ");
            input = Console.ReadLine();
            double discount = Convert.ToDouble(input);

            // ------------------------------------------------------
            //
            // ------------------------------------------------------
            Console.WriteLine("\n-----------------------\nResult \n-----------------------");
            Console.WriteLine("Amount of tickets : " + amount);
            
            double priceDiscounted = price - price * discount / 100;

            Console.WriteLine("Discounted price per ticket : " + priceDiscounted);
            Console.WriteLine("Total price : " + priceDiscounted * amount);
            Console.WriteLine("\n-----------------------\nStopped\n-----------------------");            
            
        }
    }
}

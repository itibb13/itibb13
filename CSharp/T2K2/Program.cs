using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2K2
{
    class Program
    {
        static void Main(string[] args)
        {
            Uhrzeit u1 = new Uhrzeit(0, 0, 0);
            Uhrzeit u2 = new Uhrzeit(23, 59, 59);
            Uhrzeit u3 = new Uhrzeit(00, 0, 2);
            Uhrzeit u4 = new Uhrzeit (25,0,0);
            Uhrzeit u5 = new Uhrzeit(12, 00, 00);

            Console.WriteLine("Startzeit");
            u1.Drucken();

            Console.WriteLine("\n+ 23std 59min 59sec");
            u1.addUhrzeit(u2);
            u1.Drucken();

            Console.WriteLine("\n+ 00std 00min 02sec");
            u1.addUhrzeit(u3);
            u1.Drucken();

            Console.WriteLine("\n- 25std 00min 00sec");
            u1.subUhrzeit(u4);
            u1.Drucken();

            Console.WriteLine("\nDifferenz zu 12 Uhr mittags ?");
            u1.diffUhrzeit(u5);

            Console.WriteLine("\nEndzeit");
            u1.Drucken();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gueterzug
{
    class Program
    {
        static void Main(string[] args)
        {
            // es sind für 4 waggons vorgesehen
            Waggon[] gueterzug = new Waggon[4];

            gueterzug[0] = new Lokomotive( 8, 10000 );
            gueterzug[1] = new Gueterwaggon(8, 10000, 10000);
            gueterzug[2] = new Silowaggon(8, 10000, 10000);
            gueterzug[3] = new Personenwaggon(8, 10000, 100);

            int achsen = 0;
            double eigengewicht = 0;
            double gesamtgewicht = 0;

            foreach (Waggon waggon in gueterzug)
            {
                
                achsen = achsen + waggon.Achsen;
                eigengewicht = eigengewicht + waggon.Eigengewicht;
                gesamtgewicht = gesamtgewicht + waggon.MaximalGewicht();
                waggon.Drucken();
                Console.WriteLine("");
            }

            Console.WriteLine("Achsen gesamt: " + achsen);
            Console.WriteLine("Eigengewicht gesamt: " + eigengewicht);
            Console.WriteLine("Gesamtgewicht : " + gesamtgewicht);
         }
    }
}

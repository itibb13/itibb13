using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2K4
{
    class Ratespiel
    {
        private int zufallsZahl;
        private Random random = new Random();
        private Spieler[] spieler = new Spieler[3];

        public void Spiele()
        {
            zufallsZahl = random.Next(0, 10);
            Console.WriteLine("Computer denkt sich folgende Zahl aus: " + zufallsZahl);
            Console.WriteLine("");

            Spieler anton = new Spieler("Anton", random);
            spieler[0] = anton;
            
            Spieler berta = new Spieler("Berta", random);
            spieler[1] = berta;

            Spieler caesar = new Spieler ("Cäsar", random);
            spieler[2] = caesar;

            bool zahl_erraten = false;

            while (zahl_erraten == false)
            {
                for (int i = 0; i < 3; i++)
                {
                    int spielerZahl = spieler[i].RateZahl();
                    Console.WriteLine(spieler[i].Name() + " denkt sich folgende Zahl aus: " + spielerZahl );

                    if (spielerZahl == zufallsZahl)
                    {
                        zahl_erraten = true;
                        Console.WriteLine("");
                        Console.WriteLine( spieler[i].Name() + " konnte die gesuchte Zahl erraten");
                        break;
                    }
                }
            } // end while


        }

    }
}

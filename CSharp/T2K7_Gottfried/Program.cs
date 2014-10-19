using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2K7Konto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie den Namen des Kontoinhaber ein: ");
            string Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie Ihren Kontostand Betrag in Euro an: ");
            double Guthaben= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie Ihren Überziehungsrahmen an: ");
            double Rahmen = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie den abzuhebenden Betrag ein: ");
            double Abheben = Convert.ToDouble(Console.ReadLine());

            Konto k1 = new Konto(Name, Guthaben, Rahmen);
            k1.Abheben(Abheben);
            k1.Output();
          
    }
} 
class Konto
{

    private string name;
    private double guthaben;
    private double rahmen;

public Konto(string n, double g, double r)
            {
                this.name = n;
                this.guthaben =Math.Abs(g);
                this.rahmen = Math.Abs(r);
                   
            }

        public void Einzahlen (double betrag)
        {
            this.guthaben=this.guthaben+betrag;
        }

        public bool Abheben (double abheben)
        {
            if (abheben >= (this.rahmen + this.guthaben))
            {
                Console.WriteLine("Behebung nicht möglich");

                return false;
            }
            else
            {
                this.guthaben = this.guthaben - abheben;
                return true;
            }
        }

        public void Output ()
    {
        
        Console.WriteLine("Kontostand beträgt: " + this.guthaben + " für Kontoinhaber: " +this.name);
 
    }

    public double Guthaben
{
    get {return this.guthaben;}
}

    }

}


        
    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2K7
{
    class Konto
    {
        /// <summary>
        /// Membervariablen
        /// </summary>
        private string name;
        private double guthaben;
        private double rahmen;

        /// <summary>
        /// Contructor
        /// Der Konstruktor erzeugt ein neues Object an.
        /// 
        /// Achtung:
        /// Überziehungsrahmen wird umgangssprachlich immer als positiver Wert angegeben.
        /// Zum Beispiel sagt man: Ich erhöhe (!!!) den Rahmen. Gemeint ist aber, dass 
        /// der Kunde noch mehr ins Minus gehen kann.
        /// 
        /// Unser Parameter akzeptiert sowohl pos als auch neg. Werte,
        /// wobei ein neg. Wert als positiver Wert abgespeichert wird
        /// </summary>
        /// <param name="name">Name des Kontoinhabers</param>
        /// <param name="guthaben">Startguthaben</param>
        /// <param name="rahmen">Überziehungsrahmen</param>
        public Konto(string name, double guthaben, double rahmen) 
        {
            this.name = name;
            this.guthaben = guthaben ;
            // wir stellen sicher, dass der Rahmen 
            // innerhalb der Klasse immer positiv ist
            // sonst stimmt die berechnung nicht ;-)
            this.rahmen = Math.Abs(rahmen) ;
        }

        /// <summary>
        /// Betrag einzahlen, führt zu einer Erhöhung des Guthabens
        /// </summary>
        /// <param name="betrag">Der zu einzahlende Betrag</param>
        public void Einzahlen(double betrag)
        {
            this.guthaben = this.guthaben + betrag;
        }

        /// <summary>
        /// Betrag abheben, dabei wird der Überziehungsrahmen berücksichtigt.
        /// Abbuchung erfolgt erst nach pos. Prüfung des Ü-Rahmens
        /// </summary>
        /// <param name="betrag">Der abzuhebende Betrag</param>
        /// <returns></returns>
        public bool Abheben (double betrag)
        {
            // wir berechnen uns zuerst einen zwischenbetrag  
            // (guthaben + überziehungsrahmen = verfügbares gesamtkapital)
            double zwischenbetrag = this.guthaben + this.rahmen;

            // ist der anzuhebender betrag größer als das verfügbare gesamtkapital ? 
            // wenn ja, dann können wir nichts mehr 
            // abheben und steigen mit dem Rückgabewert 
            // false aus.

            if ( betrag > zwischenbetrag )
                return false;

            // wenn nein, dann können wir abheben 
            // und reduzieren das guthaben um den betrag, den wir abbuchen
            // und wir liefern true zurück, weil alles gutgegangen ist
            this.guthaben = this.guthaben - betrag;
            return true;

            // hier ist eine zweite variante (zwecks verwirrung LOL)
            // wir berechnen uns zuerst einen zwischenbetrag
            
            // double zwischenbetrag = this.guthaben - betrag;

            // ist der betrag kleiner als der ü-rahmen?
            // wenn ja, dann können wir nichts mehr 
            // abheben und steigen mit dem Rückgabewert 
            // false aus.
            //
            // Information:
            // (-1) wird deswegen verwendet, weil der rahmen
            // umgangsprachlich immer positiv angegeben wird.
            // der rahmen ist aber ein neg. wert und daher
            // multiplizieren wir mir -1. Dadurch können
            // wir den Rahmen leicht mit dem oben berechneten
            // zwischenbetrag (=guthaben - abbuchungsbetrag) 
            // vergleichen
            
            //if (zwischenbetrag < (-1) * this.rahmen)
            //    return false;

            // Wir sind noch innerhalb des Ü-Rahmens,
            // daher passen wir das Guthaben neu an und 
            // liefern "true" zurück
            
            //this.guthaben = zwischenbetrag;
            //return true;
        }
        
        /// <summary>
        /// Liefert Guthaben zurück
        /// </summary>
        /// <returns>Das Guthaben</returns>
        public double Guthaben()
        {
            return this.guthaben;
        }

        /// <summary>
        /// Einfacher Kontoauszug
        /// </summary>
        public void Drucken()
        {
            Console.WriteLine("Name     : " + this.name);
            Console.WriteLine("Guthaben : " + this.guthaben);
            Console.WriteLine("Rahmen   : " + this.rahmen);
            Console.WriteLine("Verfügar : " + (this.guthaben + this.rahmen) );

        }

    }
}

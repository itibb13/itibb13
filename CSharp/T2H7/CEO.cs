using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H7
{
    /// <summary>
    /// Klasse CEO ist abgeleitet von Klasse Manager
    /// </summary>
    class CEO : Manager
    {
        /// <summary>
        /// Optionen sind Teil des Gehalts, wird 1x pro Monat ausbezahlt
        /// </summary>
        private double optionen;

        /// <summary>
        /// Initialisiert ein CEO Objekt, abgeleitet von Manager Object
        /// </summary>
        /// <param name="personalnummer">Personalnummer</param>
        /// <param name="name">Name</param>
        /// <param name="adresse">Adresse</param>
        /// <param name="eintrittsjahr">Eintrittsjahr</param>
        /// <param name="stundenlohn">Stundenlohn</param>
        /// <param name="bonus">Bonus (Teil des Gehalts)</param>
        /// <param name="optionen">Optionen (Teil des Gehalts)</param>
        public CEO (int personalnummer, string name, 
                         string adresse, int eintrittsjahr,
                         double stundenlohn, double bonus, double optionen) 
                        : base (personalnummer, name, adresse, eintrittsjahr, stundenlohn, bonus)
        {
            this.optionen = optionen;
        } // end class

        /// <summary>
        /// Druckt Stammdaten (analog Manager) plus Optionen aus
        /// </summary>
        public override void Drucken()
        {
            base.Drucken();
            Console.WriteLine("Optionen        : " + this.optionen);

        } // end drucken

        /// <summary>
        /// Berechnet das Gehalt (analog Manager) plus Optionen.
        /// </summary>
        /// <returns>Gehalt</returns>
        public override double Berechnen()
        {
            return ( base.Berechnen() + optionen );
        }
    } // end class
} // end namespace

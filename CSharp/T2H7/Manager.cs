using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H7
{
    /// <summary>
    /// Klasse Manager ist abgeleitet von Klasse Mitarbeiter
    /// </summary>
    class Manager : Mitarbeiter
    {
        /// <summary>
        /// Bonus ist Teil des Gehalts, wird 1x pro Monat ausbezahlt
        /// </summary>
        private double bonus;

        /// <summary>
        /// Initialisiert Manager Object, abgeleitet von Mitarbeiter
        /// </summary>
        /// <param name="personalnummer">Personalnummer</param>
        /// <param name="name">Name</param>
        /// <param name="adresse">Adresse</param>
        /// <param name="eintrittsjahr">Eintrittsjahr</param>
        /// <param name="stundenlohn">Stundenlohn</param>
        /// <param name="bonus">Bonus</param>
        public Manager (int personalnummer, string name, 
                        string adresse, int eintrittsjahr,
                        double stundenlohn, double bonus) 
                        : base (personalnummer,name,adresse,eintrittsjahr,stundenlohn)
        {
            this.bonus = bonus;
        }

        /// <summary>
        /// Druckt Stammdaten (analog Mitarbeiter) plus Bonus aus
        /// </summary>
        public override void Drucken()
        {
            base.Drucken();
            Console.WriteLine("Bonus           : " + this.bonus);
        } // end drucken

        /// <summary>
        /// Berechnet das Gehalt (analog Mitarbeiter) plus Bonus.
        /// </summary>
        /// <returns>Gehalt</returns>
        public override double Berechnen()
        {
            return (base.Berechnen() + this.bonus);
        }
    } // end class
} // end namespace

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H7
{
    /// <summary>
    /// Klasse Arbeiter, abgeleitet von Mitarbeiter
    /// </summary>
    class Arbeiter : Mitarbeiter
    {
        /// <summary>
        /// Teil des Gehalts, wird 1x pro Monat ausbezahlt
        /// </summary>
        private double schichtzulage;

        /// <summary>
        /// Initialisiert ein Arbeiter Objekt.
        /// </summary>
        /// <param name="personalnummer">Personalnummer</param>
        /// <param name="name">Name</param>
        /// <param name="adresse">Adresse</param>
        /// <param name="eintrittsjahr">Eintrittsjahr</param>
        /// <param name="stundenlohn">Stundenlohn</param>
        /// <param name="schichtzulage">Schichtzulage</param>
        public Arbeiter (int personalnummer, string name, 
                         string adresse, int eintrittsjahr,
                         double stundenlohn, double schichtzulage) 
                        : base (personalnummer,name,adresse,eintrittsjahr,stundenlohn)
        {
            this.schichtzulage = schichtzulage;
        }

        /// <summary>
        /// Druckt Stammdaten (analog Mitarbeiter) plus Optionen aus
        /// </summary>
        public override void Drucken()
        {
            base.Drucken();
            Console.WriteLine("Schichtzulage   : " + this.schichtzulage);
        }

        /// <summary>
        /// Berechnet das Gehalt (analog Mitarbeiter) plus Schichtzulage.
        /// </summary>
        /// <returns>Gehalt</returns>
        public override double Berechnen()
        {
            return (base.Berechnen() + this.schichtzulage);
        }

    } // end class
} // end namespace

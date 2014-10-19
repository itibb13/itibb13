using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H7
{
    /// <summary>
    /// Abstrakte Klasse Mitarbeiter
    /// </summary>
    public abstract class Mitarbeiter
    {
        /// <summary>
        /// Personalnummer des Mitarbeiters
        /// </summary>
        private int personalnummer;
        
        /// <summary>
        /// Name des Mitarbeiters
        /// </summary>
        private string name;
        
        /// <summary>
        /// Adresse des Mitarbeiters
        /// </summary>
        private string adresse;

        /// <summary>
        /// Eintrittsjahr des Mitarbeiters
        /// </summary>
        private int eintrittsjahr;
        
        /// <summary>
        /// Stundenlohn des Mitarbeiters
        /// </summary>
        private double stundenlohn;

        /// <summary>
        /// Initialisiert ein Mitarbeiter Objekt.
        /// </summary>
        /// <param name="personalnummer">Personalnummer</param>
        /// <param name="name">Name</param>
        /// <param name="adresse">Adresse</param>
        /// <param name="eintrittsjahr">Eintrittsjahr</param>
        /// <param name="stundenlohn">Stundenlohn</param>
        public Mitarbeiter ( int personalnummer,
                            string name, 
                            string adresse, 
                            int eintrittsjahr,
                            double stundenlohn)
        {
            this.personalnummer = personalnummer;
            this.name = name;
            this.adresse = adresse;
            this.eintrittsjahr = eintrittsjahr;
            this.stundenlohn = stundenlohn;
        } // end constructor

        /// <summary>
        /// Druckt Datenblatt des Mitarbeiters aus
        /// </summary>
        public virtual void Drucken()
        {
            Console.WriteLine("Datenblatt      : ");
            Console.WriteLine("==============================");
            Console.WriteLine("Personalnummer  : " + this.personalnummer);
            Console.WriteLine("Name            : " + this.name);
            Console.WriteLine("Adresse         : " + this.adresse);
            Console.WriteLine("Eintrittsjahr   : " + this.eintrittsjahr);
            Console.WriteLine("Stundenlohn     : " + this.stundenlohn);
        } // end drucken

        /// <summary>
        /// Berechnet Monatslohn unter der Annahme von 154 Stunden pro Monat.
        /// </summary>
        /// <returns>Gehalt</returns>
        public virtual double Berechnen()
        {
            return ( 154 * this.stundenlohn );
        } // end berechnen

    } // end class
} // end namespace

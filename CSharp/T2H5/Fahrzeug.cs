using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H5
{
    /// <summary>
    /// Abstrakte Klasse
    /// </summary>
    public abstract class Fahrzeug
    {
        /// <summary>
        /// Modellname 
        /// </summary>
        private string modellname;
        /// <summary>
        /// Leisting in PS
        /// </summary>
        private double leistung;
        /// <summary>
        /// Baujahr in Jahrenzahl
        /// </summary>
        private int baujahr;

        /// <summary>
        /// Initialisiert ein Fahrzeug
        /// </summary>
        /// <param name="modellname">Name des Modells</param>
        /// <param name="leistung">Leistung in PS</param>
        /// <param name="baujahr">Baujahr</param>
        public Fahrzeug(string modellname, double leistung, int baujahr)
        {
            this.modellname = modellname;
            this.leistung = leistung;
            this.baujahr = baujahr;
        }

        /// <summary>
        /// Druckt Datenblatt des Fahrzeugs aus
        /// </summary>
        public virtual void Drucken()
        {
            Console.WriteLine("Modellname      : " + this.modellname);
            Console.WriteLine("Leistung        : " + this.leistung);
            Console.WriteLine("Baujahr         : " + this.baujahr);
        } // end drucken


    }
}

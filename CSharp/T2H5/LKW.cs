using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H5
{
    /// <summary>
    /// Abstrakte Klasse LKW, abgeleitet von Fahrzeug
    /// </summary>
    public abstract class LKW : Fahrzeug
    {
        /// <summary>
        /// Nutzlast in Tonnen
        /// </summary>
        private double nutzlast;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modellname">Name des Modells</param>
        /// <param name="leistung">Leistung in PS</param>
        /// <param name="baujahr">Baujahr</param>
        /// <param name="nutzlast">Nutzlast in Tonnen</param>
        public LKW (string modellname, double leistung, int baujahr, double nutzlast) : base (modellname,leistung,baujahr)
        {
            this.nutzlast = nutzlast;
        }

        /// <summary>
        /// Druckt Datenblatt aus
        /// </summary>
        public override void Drucken()
        {
 	        base.Drucken();
            Console.WriteLine("Nutzlast        : " + this.nutzlast);
        }
    }
}

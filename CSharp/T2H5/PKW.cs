using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H5
{
    /// <summary>
    /// Abstrakte Klasse PWK, abgeleitet von Fahrzeug
    /// </summary>
    public abstract class PKW : Fahrzeug
    {
        /// <summary>
        /// Anzahl der Sitzpl#tze
        /// </summary>
        private int sitzplaetze;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modellname">Name des Modells</param>
        /// <param name="leistung">Leistung in PS</param>
        /// <param name="baujahr">Baujahr</param>
        /// <param name="sitzplaetze">Anzahl der Sitzplaetze</param>
        public PKW (string modellname, double leistung, int baujahr, int sitzplaetze) : base (modellname,leistung,baujahr)
        {
            this.sitzplaetze = sitzplaetze;
        }

        /// <summary>
        /// Druckt Datenblatt aus
        /// </summary>
        public override void Drucken()
        {
 	        base.Drucken();
            Console.WriteLine("Sitzplaetze     : " + this.sitzplaetze);
        }
    }
}

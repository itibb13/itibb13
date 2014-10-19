using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H5
{
    /// <summary>
    /// Abgeleitet von PWK
    /// </summary>
    class Limousine : PKW
    {
        /// <summary>
        /// Initialisiert eine Limousine
        /// </summary>
        /// <param name="modellname">Name</param>
        /// <param name="leistung">Leistung in PS</param>
        /// <param name="baujahr">Baujahr</param>
        /// <param name="sitzplaetze">Anzahl der Sitzplätze</param>
        public Limousine(string modellname, double leistung,
                         int baujahr, int sitzplaetze)
            : base(modellname, leistung, baujahr, sitzplaetze)
        { }
        /// <summary>
        /// Druckt Datenblatt aus
        /// </summary>
        public override void Drucken()
        {
            Console.WriteLine("Datenblatt      : Limousine");
            Console.WriteLine("================================");
            base.Drucken();
        }
    }
}

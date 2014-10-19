using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H5
{
    /// <summary>
    /// 
    /// </summary>
    public class Cabrio : PKW
    {
        /// <summary>
        /// 
        /// </summary>
        private double oeffnungszeitVerdeck;

        /// <summary>
        /// Initialisiert ein Cabrio
        /// </summary>
        /// <param name="modellname">Modellname</param>
        /// <param name="leistung">Leistung in PS</param>
        /// <param name="baujahr">Baujahr</param>
        /// <param name="sitzplaetze">Anzahl der Sitzplaetze</param>
        /// <param name="oeffnungszeitVerdeck">Zeit in Sekunden</param>
        public Cabrio(string modellname, double leistung, int baujahr, int sitzplaetze, double oeffnungszeitVerdeck)
                    : base(modellname, leistung, baujahr, sitzplaetze)
        {
            this.oeffnungszeitVerdeck = oeffnungszeitVerdeck;
        }

        /// <summary>
        /// Druckt Datenblatt aus
        /// </summary>
        public override void Drucken()
        {
            Console.WriteLine("Datenblatt      : Cabrio");
            Console.WriteLine("================================");
            base.Drucken();
            Console.WriteLine("Verdeck (Zeit)  : " + this.oeffnungszeitVerdeck);
        }
    }
}

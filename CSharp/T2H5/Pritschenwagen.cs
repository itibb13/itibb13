using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2H5
{
    /// <summary>
    /// Abgeleitet von LKW
    /// </summary>
    class Pritschenwagen : LKW
    {
        /// <summary>
        /// Ist die Ladeflaeche kippbar?
        /// </summary>
        private bool kippbar;

        /// <summary>
        /// Initialisiert einen Pritschenwagen
        /// </summary>
        /// <param name="modellname">Modellname</param>
        /// <param name="leistung">Leistung in PS</param>
        /// <param name="baujahr">Baujahr</param>
        /// <param name="nutzlast">Nutzlast in Tonnen</param>
        /// <param name="kippbar">true oder false</param>
        public Pritschenwagen (string modellname, double leistung, int baujahr, double nutzlast, bool kippbar) 
            : base (modellname,leistung,baujahr,nutzlast)
        {
            this.kippbar = kippbar;
        }

        /// <summary>
        /// Druckt Datenblatt aus
        /// </summary>
        public override void Drucken()
        {
            Console.WriteLine("Datenblatt      : Pritschenwagen");
            Console.WriteLine("================================");
            base.Drucken();
            if ( this.kippbar )
                Console.WriteLine("Kippbar         : ja");
            else
                Console.WriteLine("Kippbar         : nein");
        }
    }
}

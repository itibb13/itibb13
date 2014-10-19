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
    class Van : PKW
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modellname"></param>
        /// <param name="leistung"></param>
        /// <param name="baujahr"></param>
        /// <param name="sitzplaetze"></param>
        public Van(string modellname, double leistung,int baujahr, int sitzplaetze)
                : base(modellname, leistung, baujahr, sitzplaetze)
        { }

        /// <summary>
        /// Druckt Datenblatt aus
        /// </summary>
        public override void Drucken()
        {
            Console.WriteLine("Datenblatt      : Van");
            Console.WriteLine("================================");
            base.Drucken();
         }
    }
}

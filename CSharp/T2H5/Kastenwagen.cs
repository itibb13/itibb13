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
    public class Kastenwagen : LKW
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modellname"></param>
        /// <param name="leistung"></param>
        /// <param name="baujahr"></param>
        /// <param name="nutzlast"></param>
        public Kastenwagen (string modellname, double leistung, int baujahr, double nutzlast) 
            : base (modellname,leistung,baujahr,nutzlast)
        {
        }
        /// <summary>
        /// Druckt Datenblatt aus
        /// </summary>
        public override void Drucken()
        {
            Console.WriteLine("Datenblatt      : Kastenwagen");
            Console.WriteLine("================================");
            base.Drucken();
        } 
    }
}

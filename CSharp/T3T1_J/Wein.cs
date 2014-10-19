using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3T1
{
    class Wein
    {
        public string Name { get; set; }
        public int Jahrgang { get; set; }
        public string Hersteller { get; set; }

        public string Detailanzeige()
        {
            return
                ("\nName: " + Name +
                "\nJahrgang: " + Jahrgang +
                    "\nHersteller: " + Hersteller);
        }

        public override string ToString()
        {
            return Name;
        }

    }
}

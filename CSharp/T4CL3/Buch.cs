using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4CL3
{
    public class Buch
    {

        public string InventarNr { get; set; }
        public string Titel { get; set; }
        public string Autor { get; set; }
        public int Erscheinungsjahr { get; set; }
        public string Verlag { get; set; }

        public override string ToString()
        {
            return InventarNr + " | " + Titel + " | " + Autor + " | " + Erscheinungsjahr + " | " + Verlag; 
        }

    }
}

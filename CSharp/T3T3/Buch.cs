using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3T3
{
    class Buch
    {
        public string ISBN { get; set; }
        public string Autor { get; set; }
        public string Titel { get; set; }
        public int Jahr { get; set; }
        public bool Gebraucht { get; set; }


        public override string ToString()
        {
            return Titel + " (" + Autor + ")";
        }
    } // end class
} // end namespace

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3T1
{
    public class Winzer
    {
        public string name { get; set; }
        public string ort { get; set; }
        public string bundesland { get; set; }

        public Winzer(string name, string ort, string bundesland)
        {
            this.name = name;
            this.ort = ort;
            this.bundesland = bundesland;
        }
     }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3T1
{
    class Wine
    {
        public string Vineyard { get; set; }
        public string Country { get; set; }
        public string Year { get; set; }
        public string Name { get; set; }
        public string Alcohol { get; set; }
        public string Color { get; set; }
        public string Taste { get; set; }
        public string Temperature { get; set; }
        public string Sugar { get; set; }

        public string MsgBoxOutput()
        {
            return ("Information" + 
                    "\n======================" +
                    "\nName : " + Name + 
                    "\nVineyard : " + Vineyard + 
                    "\nTaste : " + Taste + 
                    "\nYear : " + Year);
        }

        public override string ToString()
        {
            return Name + " (" + Year + ")";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace T3TA3_Gebrauchte_Booteverkauf
{

    public class Boote
    {
        public string Modell { get; set; }
        public int Plätze {get; set ;}
        public string Preis { get; set; }
        public BitmapImage Bilddatei;
    
        
        public Boote(string Modell, int Plätze, string Preis, BitmapImage Bilddatei)
        {
            this.Modell = Modell;
            this.Plätze = Plätze;
            this.Preis = Preis;
            this.Bilddatei = Bilddatei;

        }

    }
}

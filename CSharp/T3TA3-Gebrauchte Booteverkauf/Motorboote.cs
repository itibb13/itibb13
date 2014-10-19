using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace T3TA3_Gebrauchte_Booteverkauf
{
    public class Motorboote : Boote
    {
        public int Motorleistung;
        public Motorboote(string Modell, int Plätze, string Preis, BitmapImage Bilddatei, int Motorleistung)
            : base(Modell, Plätze, Preis, Bilddatei)

        { this.Motorleistung = Motorleistung; }


    }
}

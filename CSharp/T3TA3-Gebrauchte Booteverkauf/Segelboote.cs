using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace T3TA3_Gebrauchte_Booteverkauf
{
    public class Segelboote : Boote
    {
        public double Segelfläche;

        public Segelboote(string Modell, int Plätze, string Preis, BitmapImage Bilddatei, double Segelfläche)
            : base(Modell, Plätze, Preis, Bilddatei)

        { this.Segelfläche = Segelfläche; }

    }
}

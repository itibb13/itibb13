using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace T3TA3_Gebrauchte_Booteverkauf
{
    /// <summary>
    /// Interaktionslogik für Details_Boote.xaml
    /// </summary>
    public partial class Details_Boote : Window
    {
        public Details_Boote(Boote d)
        {
            InitializeComponent();
            modell.Content = d.Modell;
            plätze.Content = d.Plätze;
            preis.Content = d.Preis;
            bild.Source = d.Bilddatei;

            if (d is Motorboote)
            {
                Motorboote a = (Motorboote)d;
                zusatzinfo.Content = a.Motorleistung + " PS-Motorlesitung";
            }

            if (d is Segelboote)
            {
                Segelboote s = (Segelboote)d;
                zusatzinfo.Content =s.Segelfläche + " m² Segelfläche";
            }

        }
    }
}

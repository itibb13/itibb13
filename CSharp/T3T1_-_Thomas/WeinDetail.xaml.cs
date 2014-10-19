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

namespace T3T1
{
    /// <summary>
    /// Interaction logic for WeinDetail.xaml
    /// </summary>
    public partial class WeinDetail : Window
    {
        public WeinDetail(Wein wein1)
        {
            InitializeComponent();

            // Label je nach Weintyp einfärben
            switch (wein1.typ)
            {
                case "rot":
                    lblColor.Background = Brushes.Red;
                    break;

                case "weiss":
                    lblColor.Background = Brushes.LightGoldenrodYellow;
                    break;

                case "rose":
                    lblColor.Background = Brushes.LightPink;
                    break;
            }

            // Befüllen der Textfelder und Labels
            lblName.Content = wein1.name + " " + wein1.jahrgang;
            lblProd.Content = wein1.winzer.name;
            txtGebiet.Text = wein1.winzer.bundesland + ", " + wein1.winzer.ort;
            txtSorten.Text = wein1.sorte;
            txtAlkohol.Text = Convert.ToString(wein1.alkoholgehalt) + "%";

            // Darstellung des Bildes
            BitmapImage jpg = new BitmapImage();
            jpg.BeginInit();
            jpg.UriSource = new Uri("images\\" + wein1.bild,UriKind.Relative);
            jpg.EndInit();
            Image img = new Image();
            img.Source = jpg;
            lblBild.Content = img;

        }

        private void evtBtnClose(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

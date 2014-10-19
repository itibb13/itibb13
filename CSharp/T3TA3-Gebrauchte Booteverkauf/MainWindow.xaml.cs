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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace T3TA3_Gebrauchte_Booteverkauf
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TreeViewItem ruderboot = new TreeViewItem();
            ruderboot.Header = "Ruderboote";
            TreeViewItem segelboot = new TreeViewItem();
            segelboot.Header = "Segelboote";
            TreeViewItem motorboot = new TreeViewItem();
            motorboot.Header = "Motorboote";

            root.Items.Add(ruderboot);
            root.Items.Add(segelboot);
            root.Items.Add(motorboot);
        }


        private void OnSelected(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem boot = e.NewValue as TreeViewItem;
            if (boot.Header.ToString() == "Ruderboote")
            {
                BitmapImage jpg = new BitmapImage();
                jpg.BeginInit();
                jpg.UriSource = new Uri("Images\\ruderboot1.jpg", UriKind.Relative);
                jpg.EndInit();
                Boote r1 = new Boote("Ruderboot 350", 2, "€ 250", jpg);

                BitmapImage jpg1 = new BitmapImage();
                jpg1.BeginInit();
                jpg1.UriSource = new Uri("Images\\ruderboot2.jpg", UriKind.Relative);
                jpg1.EndInit();
                Boote r2 = new Boote("Ruderboot 440",3,"€ 1450", jpg1);

                Liste_Boote l = new Liste_Boote(r1, r2);
                l.Owner = this;
                l.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
                l.ShowDialog();
            }

            if (boot.Header.ToString() == "Segelboote")
            {
                BitmapImage jpg = new BitmapImage();
                jpg.BeginInit();
                jpg.UriSource = new Uri("Images\\segelboot1.jpg", UriKind.Relative);
                jpg.EndInit();
                Segelboote s1 = new Segelboote("Segelboot", 8, "€ 2500", jpg, 228.5);

                BitmapImage jpg1 = new BitmapImage();
                jpg1.BeginInit();
                jpg1.UriSource = new Uri("Images\\segelboot2.jpg", UriKind.Relative);
                jpg1.EndInit();
                Segelboote s2 = new Segelboote("Segelboot2", 12, "€ 8800", jpg1, 139.5);

                Liste_Boote l = new Liste_Boote(s1, s2);
                l.Owner = this;
                l.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
                l.ShowDialog();
            }

                        
            if (boot.Header.ToString() == "Motorboote")
            {
                BitmapImage jpg = new BitmapImage();
                jpg.BeginInit();
                jpg.UriSource = new Uri("Images\\motorboot1.jpg", UriKind.Relative);
                jpg.EndInit();
                Motorboote m1 = new Motorboote("Motorboot", 2, "€ 1500", jpg, 250);

                BitmapImage jpg1 = new BitmapImage();
                jpg1.BeginInit();
                jpg1.UriSource = new Uri("Images\\motorboot2.jpg", UriKind.Relative);
                jpg1.EndInit();
                Motorboote m2 = new Motorboote("Motorboot2", 4,"€ 4000", jpg1, 500);

                Liste_Boote l = new Liste_Boote(m1, m2);
                
                l.Owner = this;
                l.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
                l.ShowDialog();
            }

        }
    }
}

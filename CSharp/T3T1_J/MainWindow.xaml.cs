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

namespace T3T1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Wein weißwein1 = new Wein ()
                {
                    Name = "Chardonnay",
                    Jahrgang = 2002,
                    Hersteller = "Winzerhof Achau",
                };

            Wein weißwein2 = new Wein() { Name = "Grüner Veltliner", Jahrgang = 1999, Hersteller = "Pferschy-Seper" };
            Wein weißwein3 = new Wein() { Name = "Welschriesling", Jahrgang = 2008, Hersteller = "Weingut Mühlfeldhof" };
            
            Wein rosewein1 = new Wein () { Name = "Rose vom Zweigelt", Jahrgang = 2013, Hersteller = "Wein&Co Selection"};
            Wein rosewein2 = new Wein() { Name = "Secco", Jahrgang = 2012 , Hersteller = "Hillinger"};
            Wein rosewein3 = new Wein() { Name = "Schilcher Klassik", Jahrgang = 2013, Hersteller = "Strohmaier" };

            Wein rotwein1 = new Wein () {Name = "Zweigelt", Jahrgang = 2009, Hersteller = "Hauerhof"};
            Wein rotwein2 = new Wein() { Name = "Blauburgunger", Jahrgang = 2009, Hersteller = "Weingut Schachl" };
            Wein rotwein3 = new Wein() { Name = "St. Laurent", Jahrgang = 2009, Hersteller = "Pfeiffer" };

            TreeViewItem weißwein = new TreeViewItem();
            weißwein.Header = "Weißwein";
            root.Items.Add(weißwein);
            TreeViewItem w1 = new TreeViewItem();
            w1.Header = weißwein1;
            weißwein.Items.Add(w1);
            TreeViewItem w2 = new TreeViewItem();
            w2.Header = weißwein2;
            weißwein.Items.Add(w2);
            TreeViewItem w3 = new TreeViewItem();
            w3.Header = weißwein3;
            weißwein.Items.Add(w3);

            TreeViewItem rosewein = new TreeViewItem();
            rosewein.Header = "Rosewein";
            root.Items.Add(rosewein);
            TreeViewItem rose1 = new TreeViewItem();
            rose1.Header = rosewein1;
            rosewein.Items.Add(rose1);
            TreeViewItem rose2 = new TreeViewItem();
            rose2.Header = rosewein2;
            rosewein.Items.Add(rose2);
            TreeViewItem rose3 = new TreeViewItem();
            rose3.Header = rosewein3;
            rosewein.Items.Add(rose3);

            TreeViewItem rotwein = new TreeViewItem();
            rotwein.Header = "Rotwein";
            root.Items.Add(rotwein);
            TreeViewItem rot1 = new TreeViewItem();
            rot1.Header = rotwein1;
            rotwein.Items.Add(rot1);
            TreeViewItem rot2 = new TreeViewItem();
            rot2.Header = rotwein2;
            rotwein.Items.Add(rot2);
            TreeViewItem rot3 = new TreeViewItem();
            rot3.Header = rotwein3;
            rotwein.Items.Add(rot3);

                }


        private void TreeView_SelectedItemChanged_2(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem tvi = e.NewValue as TreeViewItem;
            if (tvi.Header is Wein)
            {
                WeinDetailDialog wmd = new WeinDetailDialog("Ausgewählt wurde: " + ((Wein)tvi.Header).Detailanzeige() );
                wmd.Owner = this;
                wmd.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                wmd.ShowDialog();
            }
        }
       

    }
}

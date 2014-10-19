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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Declare Arrays for Wines
        private Wein[] Weine = new Wein[100];
        
        public MainWindow()
        {
            InitializeComponent();

            Winzer feilerartinger = new Winzer("Feiler-Artinger", "Rust am See", "Burgenland");
            Winzer hofstaedter = new Winzer("Kirchheuriger Hofstädter", "Guntramsdorf", "Niederösterreich");
            Winzer scheiblhofer = new Winzer("Scheiblhofer", "Antau", "Burgenland");
            Winzer umathum = new Winzer("Umathum", "Frauenkirchen", "Burgenland");
            Winzer wieninger = new Winzer("Wieninger", "Wien", "Wien");
            Winzer tement = new Winzer("Tement", "Berghausen", "Steiermark");
            Winzer prieler = new Winzer("Prieler", "Schützen am Gebirge", "Burgenland");

            // Es werden einige Weine hinzugefügt
            Weine[0] = new Wein("Quartett Spätlese", "weiss", feilerartinger, "Chardonnay, Weissburgunder, Welschriesling und Ruländer", 2011, 11, "FA_Quartett_SL_2011.jpg");
            Weine[1] = new Wein("Rotgipfler Spätlese", "weiss", hofstaedter, "Rotgipfler", 2012, 10, "noimage.jpg");
            Weine[2] = new Wein("Temento Rose 2013", "rose", tement, "Cuvee Rose", 2013, 11, "Tement_Rose2013.jpg");
            Weine[3] = new Wein("Rose vom Stein", "rose", prieler, "Cuvee Rose", 2012, 12, "Prieler_Rose2012.jpg");
            Weine[4] = new Wein("Zweigelt Neusiedlersee DAC", "rot", scheiblhofer, "Zweigelt", 2012, 13, "Scheiblhofer_Zweigelt.jpg");
            Weine[5] = new Wein("Blaufränkisch Kirschgarten", "rot", umathum, "Blaufränkisch", 2009, 13, "Umathum_Kirschgarten.jpg");
            Weine[6] = new Wein("Wiener Trilogie", "rot", wieninger, "Cuvee Rot", 2011, 13, "Wieninger_Wiener-Trilogie.jpg");
            Weine[7] = new Wein("Solitaire", "rot", feilerartinger, "Blaufränkisch, Merlot, Cabernet Sauvignon", 2006, 13, "FA_Solitaire2006.jpg");
            Weine[8] = new Wein("Solitaire", "sonstige", feilerartinger, "Blaufränkisch, Merlot, Cabernet Sauvignon", 2006, 13, "FA_Solitaire2006.jpg");
   
            // Erstellung der Parent-Items
            TreeViewItem tviRotWeinParent = new TreeViewItem();
            tviRotWeinParent.Header = "Rotwein";
            wineTree.Items.Add(tviRotWeinParent);

            TreeViewItem tviRoseWeinParent = new TreeViewItem();
            tviRoseWeinParent.Header = "Rosewein";
            wineTree.Items.Add(tviRoseWeinParent);

            TreeViewItem tviWeissWeinParent = new TreeViewItem();
            tviWeissWeinParent.Header = "Weißwein";
            wineTree.Items.Add(tviWeissWeinParent);

            TreeViewItem tviUndefParent = new TreeViewItem();
            tviUndefParent.Header = "Sonstige";
            wineTree.Items.Add(tviUndefParent);

            // Überprüfen ob der Platz im Array befüllt ist, Treeviewitem erstellen und dem jeweiligen Parent zuordnen
            for (int i = 0; i < 20; i ++)
            {
                TreeViewItem[] tviWeissWeinChild = new TreeViewItem[75];
                TreeViewItem[] tviRotWeinChild = new TreeViewItem[75];
                TreeViewItem[] tviRoseWeinChild = new TreeViewItem[75];
                TreeViewItem[] tviUndefChild = new TreeViewItem[75];

                if (Weine[i] != null)
                {
                    switch (Weine[i].typ)
                    {
                        case "weiss":
                            tviWeissWeinChild[i] = new TreeViewItem();
                            tviWeissWeinChild[i].Header = Weine[i];
                            tviWeissWeinParent.Items.Add(tviWeissWeinChild[i]);
                            break;

                        case "rose":
                            tviRoseWeinChild[i] = new TreeViewItem();
                            tviRoseWeinChild[i].Header = Weine[i];
                            tviRoseWeinParent.Items.Add(tviRoseWeinChild[i]);
                            break;

                        case "rot":
                            tviRotWeinChild[i] = new TreeViewItem();
                            tviRotWeinChild[i].Header = Weine[i];
                            tviRotWeinParent.Items.Add(tviRotWeinChild[i]);
                            break;

                        default:
                            tviUndefChild[i] = new TreeViewItem();
                            tviUndefChild[i].Header = Weine[i];
                            tviUndefParent.Items.Add(tviUndefChild[i]);
                            break;
                    }
                }
            }
        }

        // Eventhandler für Auswahländerungen
        private void evtWineTreeSelChange(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem tvix = (TreeViewItem)e.NewValue;

            // Falls eine Exception beim Casten auftritt, wird diese abgefangen
            try
            {
                Wein wx = (Wein)tvix.Header;
                WeinDetail wd1 = new WeinDetail(wx);
                wd1.Owner = this;
                wd1.ShowDialog();
            }
            catch (InvalidCastException ie)
            {

                Console.WriteLine( "Stacktrace = " + ie.ToString() );

            }
        }

        // Eventhandler für das Menü
        private void miEventHandler(object sender, RoutedEventArgs e)
        {
            MenuItem mi = sender as MenuItem;

            switch (mi.Name)
            {
                case "menuClose":
                    Close();
                    break;

                case "menuAbout":
                    Info i1 = new Info();
                    i1.Owner = this;
                    i1.ShowDialog();
                    break;

                default:
                    MessageBox.Show(mi.Name + " wird durch den Event Handler nicht behandelt (miEventHandler)");
                    break;
            }
        }
    }
}

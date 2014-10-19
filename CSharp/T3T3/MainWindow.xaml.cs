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

namespace T3T3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            Buch krimi = new Buch() 
            { 
                ISBN = "1111", 
                Autor = "Anton", 
                Titel = "Der Anfang vom Ende", 
                Jahr = 2000, 
                Gebraucht = true 
            };

            Buch kochen = new Buch() 
            { 
                ISBN = "2222", 
                Autor = "Berta", 
                Titel = "Der Ofen brennt", 
                Jahr = 2001, 
                Gebraucht = false 
            };
            
            Buch reise = new Buch() 
            { 
                ISBN = "3333", 
                Autor = "Caesar", 
                Titel = "Die Reise ohne Wiederkehr", 
                Jahr = 2002, 
                Gebraucht = false 
            };
            TreeViewItem item_krimi = new TreeViewItem();
            item_krimi.Header = "Kriminalromane";
            root.Items.Add(item_krimi);
            TreeViewItem k1 = new TreeViewItem();
            k1.Header = krimi;
            item_krimi.Items.Add(k1);

        }

        private void rootSelection(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem tvi = e.NewValue as TreeViewItem;
            if (tvi.Header is Buch)
            {
                MessageBox.Show("Ausgewählt wurde " + ((Buch)tvi.Header).ToString() );
            }
        }
    }
}

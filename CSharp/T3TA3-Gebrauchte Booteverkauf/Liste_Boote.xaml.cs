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
    /// Interaktionslogik für Liste_Boote.xaml
    /// </summary>
    public partial class Liste_Boote : Window
    {
        public Liste_Boote(Boote a1, Boote a2)
        {
            InitializeComponent();
            Boote[] boot = new Boote[] { a1, a2 };
            Grid.ItemsSource =boot;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Boote boote = (Boote)Grid.SelectedItem;
            
            // rap - begin 
            if (boote == null)
                return;
            // rap - end

            Details_Boote db = new Details_Boote(boote);
            db.Owner= this;
            db.WindowStartupLocation= System.Windows.WindowStartupLocation.CenterOwner;
            db.ShowDialog();
        }
    }
}

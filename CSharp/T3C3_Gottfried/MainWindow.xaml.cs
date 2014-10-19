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

//ITIBB13 Scheck
namespace T3C3_combobox
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void selchangedColor(object sender, SelectionChangedEventArgs e)
            
        {
            
            ComboBox cb = sender as ComboBox;
                   
           tb.Text = ((ComboBoxItem)cb.SelectedItem).Content.ToString();
            if (tb.Text == "Rot")
           {
               tb.Foreground = Brushes.Red;
           }
           
           else if (tb.Text == "Blau")
           {
               tb.Foreground = Brushes.Blue;
           }
           else if (tb.Text == "Gelb")
           {
               tb.Foreground = Brushes.Yellow;
           }
           else if (tb.Text == "Schwarz")
           {
               tb.Foreground = Brushes.Black;
           }
           else  if (tb.Text == "Grün")
           {
               tb.Foreground = Brushes.Green;
           }
        }
    }
}

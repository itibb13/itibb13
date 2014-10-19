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

namespace T3B2
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

        private void Radiob1_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Die Antwort ist: JA";
        }

        private void Radiob2_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Die Antwort ist: NEIN";
        }

        private void Radiob3_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Die Antwort ist: VIELLEICHT";
        }
    }
}

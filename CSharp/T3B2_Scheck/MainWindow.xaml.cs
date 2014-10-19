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

        private void radioButton_Checked(object sender, EventArgs e)
        {
            label1.Content = "selected Button: " + ((RadioButton)sender).Content;
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            label1.Content = "selected Button: " + ((RadioButton)sender).Content;
        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            label1.Content = "selected Button: " + ((RadioButton)sender).Content;
        }
        
    }
}

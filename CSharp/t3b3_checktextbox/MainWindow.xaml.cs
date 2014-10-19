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

namespace T3B3_CheckTextbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void checkbox1_Click(object sender, RoutedEventArgs e)
        {
            if (this.checkbox1.IsChecked == true && this.checkbox2.IsChecked == true)
            {
                this.label.Content = "doublecheck";
            }
            else if (this.checkbox1.IsChecked == true || this.checkbox2.IsChecked == true)
            {
                this.label.Content = "singlecheck";
            }
            else
            {
                this.label.Content = "no check";
            }
        }
        

        private void checkbox2_Click(object sender, RoutedEventArgs e)
        {
            if (this.checkbox1.IsChecked == true && this.checkbox2.IsChecked == true)
            {
                this.label.Content = "doublecheck";
            }
            else if (this.checkbox1.IsChecked == true || this.checkbox2.IsChecked == true)
            {
                this.label.Content = "singlecheck";
            }
            else
            {
                this.label.Content = "no check";
            }
        }

       
    }
}

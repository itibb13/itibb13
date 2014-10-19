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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /*
         * Alternativ könnte man auch nur eine Callback Methode implementieren, 
         * welche als ActionListener registriert wird.   
         * Ich habe drei Callbacks geschrieben, da jede Callback eine
         * andere action (=text ausgabe) ausführt.
         */

        /// <summary>
        /// Change content of label when Radio Button 1 has been pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = "Good. You pressed " + ((RadioButton)sender).Content;
        }

        /// <summary>
        /// Change content of label when Radio Button 2 has been pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = "Awesome. You found " + ((RadioButton)sender).Content;
        }
        /// <summary>
        /// Change content of label when Radio Button 3 has been pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = "Terrific. Now you know how to click on " + ((RadioButton)sender).Content;
        }
    }
}

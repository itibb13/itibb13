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

namespace T3C3___ComboBox
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

        private void evtSelChange(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb1 = sender as ComboBox;
            string selection = ((ComboBoxItem)cb1.SelectedItem).Content.ToString();
            
            switch (selection)
            { 
                case "Blau":
                    txtOutput.Foreground = Brushes.Blue;
                    txtOutput.Text = "Blau";
                    break;

                case "Grün":
                    txtOutput.Foreground = Brushes.Green;
                    txtOutput.Text = "Grün";
                    break;

                case "Rot":
                    txtOutput.Foreground = Brushes.Red;
                    txtOutput.Text = "Rot";
                    break;

                case "Violett":
                    txtOutput.Foreground = Brushes.Violet;
                    txtOutput.Text = "Violett";
                    break;

                default:
                    break;
            }
        }

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
                    MessageBox.Show(mi.Name + " is not handled by the Menu Event Handler (miEventHandler)");
                    break;
            }

        }
    }
}

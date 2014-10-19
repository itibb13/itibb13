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

namespace T3D2
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

        private void OnCalculate(object sender, RoutedEventArgs e)
        {
            try
            {
                int z1 = Convert.ToInt32(tbZahl1.Text);
                int z2 = Convert.ToInt32(tbZahl2.Text);

                ResultDialog rd = new ResultDialog(z1, z2);
                rd.Owner = this;

                rd.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
                rd.ShowDialog();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Fehlerhafte Eingabe." +  ex.ToString() );
            }
        }
    }
}

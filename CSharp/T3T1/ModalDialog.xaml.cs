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

namespace T3T1
{
    /// <summary>
    /// Interaction logic for ModalDialog.xaml
    /// </summary>
    public partial class ModalDialog : Window
    {
        public ModalDialog(string text)
        {
            InitializeComponent();

            label.Content = text;
        }

        private void onButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

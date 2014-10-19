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
    /// Interaktionslogik für WeinDetailDialog.xaml
    /// </summary>
    public partial class WeinDetailDialog : Window
    {
        public WeinDetailDialog(string text)
        {
            InitializeComponent();
            l1.Content = (text);
        }
    }
}

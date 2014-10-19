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

namespace T3D2
{
    /// <summary>
    /// Interaction logic for ResultDialog.xaml
    /// </summary>
    public partial class ResultDialog : Window
    {
        public ResultDialog(int z1, int z2)
        {
            InitializeComponent();
            Result.Content = z1 + " ** " + z2 + " = " + Math.Pow(z1, z2);
        }
    }
}

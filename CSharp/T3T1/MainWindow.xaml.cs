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

namespace T3T1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            this.ShowWelcomeMsg();

            /*
             * Lets create red, rose and 
             * white wines in a loop. 
             * you know, programmers are lazy ;-)
             */
            Wine red = null;
            Wine rose = null;
            Wine white = null;

            Random random = null;
            string[] taste = new string[4] { "dry", "medium dry", "medium", "sweet" };
            string[] year = new string[10] { "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004" };
            string[] country = new string[5] { "Austria", "Spain", "France", "Italy", "Unknown (maybe smuggled)" };
            string[] vineyard = new string[4] { "Hypo Ranch", "In The Middle of Nowhere", "White Sands (US atom bomb area)", "Krim Island" };

            for (int i = 0; i < 15; i++)
            {
                random = new Random(DateTime.Now.Millisecond);

                red = CreateWine(vineyard[random.Next(0, 4)], country[random.Next(0, 5)],
                                year[random.Next(0, 10)], "Red Wine " + i.ToString(),
                                "6.0 %", "Red", taste[random.Next(0, 4)], "10-16°C", "45g/l");
                AddRedWine(red);

                rose = CreateWine(vineyard[random.Next(0, 4)], country[random.Next(0, 5)],
                                year[random.Next(0, 10)], "Rose Wine " + i.ToString(),
                                "5.5 %", "Rose", taste[random.Next(0, 4)], "11-17°C", "20g/l");
                AddRoseWine(rose);

                white = CreateWine(vineyard[random.Next(0, 4)], country[random.Next(0, 5)],
                                year[random.Next(0, 10)], "White Wine " + i.ToString(),
                                "5.0 %", "White", taste[random.Next(0, 4)], "9-15°C", "5g/l");
                AddWhiteWine(white);

            }
        }

        /// <summary>
        /// Add white wine to treeview
        /// </summary>
        /// <param name="white"></param>
        private void AddWhiteWine(Wine white)
        {
            TreeViewItem item = new TreeViewItem();
            item.Header = white;
            tvi_whitewine.Items.Add(item);
        }

        /// <summary>
        /// Add rose wine to treeview
        /// </summary>
        /// <param name="rose"></param>
        private void AddRoseWine(Wine rose)
        {
            TreeViewItem item = new TreeViewItem();
            item.Header = rose;
            tvi_rosewine.Items.Add(item);
        }

        /// <summary>
        /// Add red wine to treeview
        /// </summary>
        /// <param name="red"></param>
        private void AddRedWine(Wine red)
        {
            TreeViewItem item = new TreeViewItem();
            item.Header = red;
            tvi_redwine.Items.Add(item);
        }

        /// <summary>
        /// Create a wine object
        /// </summary>
        /// <param name="vineyard"></param>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="name"></param>
        /// <param name="alcohol"></param>
        /// <param name="color"></param>
        /// <param name="taste"></param>
        /// <param name="temperature"></param>
        /// <param name="sugar"></param>
        /// <returns></returns>
        private Wine CreateWine(string vineyard, string country, string year,
                                string name, string alcohol, string color,
                                string taste, string temperature, string sugar)
        {
            Wine wine = new Wine()
            {
                Vineyard = vineyard,
                Country = country,
                Year = year,
                Name = name,
                Alcohol = alcohol,
                Color = color,
                Taste = taste,
                Temperature = temperature,
                Sugar = sugar
            };

            return wine;
        }


        /// <summary>
        /// Select treeviewitem and show result.
        /// If checkbox is checked then user will get more information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rootSelection(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem tvi = e.NewValue as TreeViewItem;

            if (tvi.Header is Wine)
            {
                // does user want more details ?
                bool flag = checkbox.IsChecked.Value;
                // yes
                if (true == flag)
                {
                    textbox.Clear();

                    textbox.AppendText(((Wine)tvi.Header).Name + Environment.NewLine);
                    textbox.AppendText("==================================" + Environment.NewLine);
                    textbox.AppendText("Vineyard : " + ((Wine)tvi.Header).Vineyard + Environment.NewLine);
                    textbox.AppendText("Country : " + ((Wine)tvi.Header).Country + Environment.NewLine);
                    textbox.AppendText("Year : " + ((Wine)tvi.Header).Year + Environment.NewLine);
                    textbox.AppendText("Alcohol : " + ((Wine)tvi.Header).Alcohol + Environment.NewLine);
                    textbox.AppendText("Color : " + ((Wine)tvi.Header).Color + Environment.NewLine);
                    textbox.AppendText("Taste : " + ((Wine)tvi.Header).Taste + Environment.NewLine);
                    textbox.AppendText("Temp : " + ((Wine)tvi.Header).Temperature + Environment.NewLine);
                    textbox.AppendText("Sugar : " + ((Wine)tvi.Header).Sugar + Environment.NewLine);
                }
                else
                {
                    // no, user only wants a short description
                    // I personally prefer MessageBox but you can also use a ModalDialog
                    // just uncomment the dialog you prefer
                    // but dont use both at the same time ;-)

                    MessageBox.Show(((Wine)tvi.Header).MsgBoxOutput(), "Short description");

                    /*
                    ModalDialog dialog = new ModalDialog( ((Wine)tvi.Header).MsgBoxFormat() );
                    dialog.Title = "Short description";
                    dialog.Owner = this;
                    dialog.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
                    dialog.ShowDialog();
                     */
                }

            }
        }

        /// <summary>
        /// Close window and exit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Reset the treeview and the textbox when user clicks on detail checkbox.
        /// Why? It looks nicer ;-) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkbox_Click(object sender, RoutedEventArgs e)
        {
            foreach (TreeViewItem item in treeview.Items)
                item.IsExpanded = false;
            this.ShowWelcomeMsg();
        }

        /// <summary>
        /// Show welcome message in textbox
        /// </summary>
        private void ShowWelcomeMsg()
        {
            textbox.Clear();
            textbox.AppendText("Welcome to our Wine Product Manager\n\n");
            textbox.AppendText("Please feel free to explore our products.\n\n");
            textbox.AppendText("If you wish to get more details please click on checkbox 'Details'");
        }

    } // end class
} // end namespace

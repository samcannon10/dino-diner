/*DrinkSelection.xaml.cs
 * Author: Samuel Cannon
 */

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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Initializes DrinkSelection Page
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            LemonButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Collapsed;
            DecafButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Collapsed;
            SweetButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Sends user to FlavorSelection Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ChooseFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        public void WaterClick(object sender, RoutedEventArgs args)
        {
            LemonButton.Visibility = Visibility.Visible;
            IceButton.Visibility = Visibility.Visible;

            FlavorButton.Visibility = Visibility.Hidden;
            FlavorButton.Visibility = Visibility.Collapsed;
            SweetButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Collapsed;
            DecafButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Collapsed;
        }

        public void SodasaurusClick(object sender, RoutedEventArgs args)
        {
            IceButton.Visibility = Visibility.Visible;
            FlavorButton.Visibility = Visibility.Visible;

            SweetButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Collapsed;
            DecafButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Collapsed;
            LemonButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Collapsed;
        }

        public void JavaClick(object sender, RoutedEventArgs args)
        {
            DecafButton.Visibility = Visibility.Visible;

            LemonButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Collapsed;
            SweetButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Collapsed;
            FlavorButton.Visibility = Visibility.Hidden;
            FlavorButton.Visibility = Visibility.Collapsed;
            IceButton.Visibility = Visibility.Hidden;
            IceButton.Visibility = Visibility.Collapsed;
        }

        public void TyrannoteaClick(object sender, RoutedEventArgs args)
        {
            LemonButton.Visibility = Visibility.Visible;
            SweetButton.Visibility = Visibility.Visible;
            IceButton.Visibility = Visibility.Visible;

            DecafButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Collapsed;
            FlavorButton.Visibility = Visibility.Hidden;
            FlavorButton.Visibility = Visibility.Collapsed;
        }
    }
}

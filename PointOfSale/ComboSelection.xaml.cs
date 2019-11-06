/*ComboSelection.xaml.cs
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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// Constructor for ComboSelection Page
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds Steakosaurus Burger combo, then navigates
        /// to its customization page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                order.Add(new CretaceousCombo(new SteakosaurusBurger()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(true));
            }
        }

        /// <summary>
        /// Adds Brontowurst combo, then navigates
        /// to its customization page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new CretaceousCombo(new Brontowurst()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeBrontowurst(true));
            }
        }

        /// <summary>
        /// AddsTRex King Burger combo, then navigates
        /// to its customization page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new CretaceousCombo(new TRexKingBurger()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeKingBurger(true));
            }
        }

        /// <summary>
        /// Adds Prehistoric PB&amp;J combo, then navigates
        /// to its customization page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new CretaceousCombo(new PrehistoricPBJ()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizePrehistoricPBJ(true));
            }
        }

        /// <summary>
        /// Adds Veloci-Wrap combo, then navigates
        /// to its customization page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new CretaceousCombo(new VelociWrap()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeVelociWrap(true));
            }
        }

        /// <summary>
        /// Adds Dino-Nuggets combo, then navigates
        /// to its customization page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new CretaceousCombo(new DinoNuggets()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeDinoNuggets(true));
            }
        }

        /// <summary>
        /// Adds Pterodactyl Wings combo, then navigates
        /// to its customization page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddPterdactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new CretaceousCombo(new PterodactylWings()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
    }
}

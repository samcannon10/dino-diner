/*FlavorSelection.xaml.cs
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        protected Sodasaurus soda;
        private bool isCombo;

        /// <summary>
        /// Initializes FlavorSelection Page
        /// </summary>
        public FlavorSelection(bool combo)
        {
            InitializeComponent();
            isCombo = combo;
        }

        /// <summary>
        /// Changes flavor of selected Sodasaurus to Cola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ChangeToCola(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Cola;
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Drink as Sodasaurus).Flavor = SodasaurusFlavor.Cola;
                }
                NavigationService.Navigate(new DrinkSelection(isCombo));
            }
        }

        /// <summary>
        /// Changes flavor of selected Sodasaurus to Vanilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ChangeToVanilla(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Vanilla;
                }
                else if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Drink as Sodasaurus).Flavor = SodasaurusFlavor.Vanilla;
                }
                NavigationService.Navigate(new DrinkSelection(isCombo));
            }
        }

        /// <summary>
        /// Changes flavor of selected Sodasaurus to RootBeer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ChangeToRootBeer(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.RootBeer;
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Drink as Sodasaurus).Flavor = SodasaurusFlavor.RootBeer;
                }
                NavigationService.Navigate(new DrinkSelection(isCombo));
            }
        }

        /// <summary>
        /// Changes flavor of selected Sodasaurus to Chocolate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ChangeToChocolate(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Chocolate;
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Drink as Sodasaurus).Flavor = SodasaurusFlavor.Chocolate;
                }
                NavigationService.Navigate(new DrinkSelection(isCombo));
            }
        }

        /// <summary>
        /// Changes flavor of selected Sodasaurus to Orange
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ChangeToOrange(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Orange;
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Drink as Sodasaurus).Flavor = SodasaurusFlavor.Orange;
                }
                NavigationService.Navigate(new DrinkSelection(isCombo));
            }
        }

        /// <summary>
        /// Changes flavor of selected Sodasaurus to Cherry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ChangeToCherry(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Cherry;
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Drink as Sodasaurus).Flavor = SodasaurusFlavor.Cherry;
                }
                NavigationService.Navigate(new DrinkSelection(isCombo));
            }
        }

        /// <summary>
        /// Changes flavor of selected Sodasaurus to Lime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ChangeToLime(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Lime;
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Drink as Sodasaurus).Flavor = SodasaurusFlavor.Lime;
                }
                NavigationService.Navigate(new DrinkSelection(isCombo));
            }
        }
    }
}

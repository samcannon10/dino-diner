/*SideSelection.xaml.cs
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        private bool isCombo;

        /// <summary>
        /// Initializes SideSelection Page
        /// </summary>
        public SideSelection(bool combo)
        {
            InitializeComponent();
            isCombo = combo;
        }

        /// <summary>
        /// Adds Friceritops to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddFryceritops(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if (isCombo == false)
                {
                    order.Add(new Fryceritops());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Side = new Fryceritops();
                    NavigationService.Navigate(new CustomizeCombo());
                }
            }
        }

        /// <summary>
        /// Adds Triceritots to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (isCombo == false)
                {
                    order.Add(new Triceritots());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Side = new Triceritots();
                    NavigationService.Navigate(new CustomizeCombo());
                }
            }
        }

        /// <summary>
        /// Adds Mezzorella Sticks to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (isCombo == false)
                {
                    order.Add(new MezzorellaSticks());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Side = new MezzorellaSticks();
                    NavigationService.Navigate(new CustomizeCombo());
                }
            }
        }

        /// <summary>
        /// Adds MeteorMacAndCheese to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddMacAndCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (isCombo == false)
                {
                    order.Add(new MeteorMacAndCheese());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Side = new MeteorMacAndCheese();
                    NavigationService.Navigate(new CustomizeCombo());
                }
            }
        }

        /// <summary>
        /// Sets the current side to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetLarge(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    LargeButton.IsChecked = true;
                    side.Size = DinoDiner.Menu.Size.Large;
                    if (isCombo == true) NavigationService.Navigate(new CustomizeCombo());
                    else NavigationService.Navigate(new MenuCategorySelection());
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    UpdateSize();
                    NavigationService.Navigate(new CustomizeCombo());
                }
            }
        }

        /// <summary>
        /// Sets the current item to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetMedium(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    MediumButton.IsChecked = true;
                    side.Size = DinoDiner.Menu.Size.Medium;
                    if (isCombo == true) NavigationService.Navigate(new CustomizeCombo());
                    else NavigationService.Navigate(new MenuCategorySelection());
                }
                else if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    UpdateSize();
                    NavigationService.Navigate(new CustomizeCombo());
                }
            }
        }

        /// <summary>
        /// Sets the current item to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetSmall(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    SmallButton.IsChecked = true;
                    side.Size = DinoDiner.Menu.Size.Small;
                    if (isCombo == true) NavigationService.Navigate(new CustomizeCombo());
                    else NavigationService.Navigate(new MenuCategorySelection());
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    UpdateSize();
                    NavigationService.Navigate(new CustomizeCombo());
                }
            }
        }

        /// <summary>
        /// Updates the size controls to reflect
        /// the current selected side
        /// </summary>
        public void UpdateSize()
        {
            if(DataContext is Order order)
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    if (side.Size == DinoDiner.Menu.Size.Small) SmallButton.IsChecked = true;
                    else if (side.Size == DinoDiner.Menu.Size.Medium) MediumButton.IsChecked = true;
                    else if (side.Size == DinoDiner.Menu.Size.Large) LargeButton.IsChecked = true;
                }
                else if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if(combo.Size == DinoDiner.Menu.Size.Small) SmallButton.IsChecked = true;
                    else if (combo.Size == DinoDiner.Menu.Size.Medium) MediumButton.IsChecked = true;
                    else if (combo.Size == DinoDiner.Menu.Size.Large) LargeButton.IsChecked = true;
                }
                else
                {
                    SmallButton.IsChecked = false;
                    MediumButton.IsChecked = false;
                    LargeButton.IsChecked = false;
                }
            }
        }
    }
}

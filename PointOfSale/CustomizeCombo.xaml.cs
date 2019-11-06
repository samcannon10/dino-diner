/*CustomizeCombo.xaml.cs
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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// Initializes CustomizeCombo Page
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sends user to SideSelection Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(true));
        }

        /// <summary>
        /// Sends user to DrinkSelection Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(true));
        }

        /// <summary>
        /// Sets size of combo to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetLarge(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    LargeButton.IsChecked = true;
                    combo.Size = DinoDiner.Menu.Size.Large;
                    combo.Side.Size = DinoDiner.Menu.Size.Large;
                    combo.Drink.Size = DinoDiner.Menu.Size.Large;
                }
            }
        }

        /// <summary>
        /// Sets size of combo to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetMedium(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    MediumButton.IsChecked = true;
                    combo.Size = DinoDiner.Menu.Size.Medium;
                    combo.Side.Size = DinoDiner.Menu.Size.Medium;
                    combo.Drink.Size = DinoDiner.Menu.Size.Medium;
                }
            }
        }

        /// <summary>
        /// Sets size of combo to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetSmall(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    SmallButton.IsChecked = true;
                    combo.Size = DinoDiner.Menu.Size.Small;
                    combo.Side.Size = DinoDiner.Menu.Size.Small;
                    combo.Drink.Size = DinoDiner.Menu.Size.Small;
                }
            }
        }

        /// <summary>
        /// Navigates to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ReturnToMenuSelection(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}

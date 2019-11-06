/*CustomizeBrontowurst.xaml.cs
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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        private bool isCombo;

        /// <summary>
        /// Constructor for Brontowurst customization page
        /// </summary>
        /// <param name="combo">Whether or not this is part of a combo</param>
        public CustomizeBrontowurst(bool combo)
        {
            InitializeComponent();
            isCombo = combo;
        }

        /// <summary>
        /// Holds peppers for the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldPeppers(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst bw)
                {
                    bw.HoldPeppers();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as Brontowurst).HoldPeppers();
                }
            }
        }

        /// <summary>
        /// Holds onion for the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldOnion(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst bw)
                {
                    bw.HoldOnion();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as Brontowurst).HoldOnion();
                }
            }
        }

        /// <summary>
        /// Holds bun for the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldBun(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst bw)
                {
                    bw.HoldBun();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as Brontowurst).HoldBun();
                }
            }
        }

        /// <summary>
        /// Navigates to proper page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ReturnToMenuSelection(object sender, RoutedEventArgs args)
        {
            if (isCombo == true) NavigationService.Navigate(new CustomizeCombo());
            else NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}

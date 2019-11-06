/*CustomizePrehistoricPBJ.xaml.cs
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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        private bool isCombo;

        /// <summary>
        /// Constructor for PrehistoricPBJ customization Page
        /// </summary>
        /// <param name="combo">WHether or not this is part of a combo</param>
        public CustomizePrehistoricPBJ(bool combo)
        {
            InitializeComponent();
            isCombo = combo;
        }

        /// <summary>
        /// Holds peanut butter for this entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldPeanutButter(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order) 
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PrehistoricPBJ pbj)
                {
                    pbj.HoldPeanutButter();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as PrehistoricPBJ).HoldPeanutButter();
                }
            }
        }

        /// <summary>
        /// Holds jelly for this entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldJelly(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PrehistoricPBJ pbj)
                {
                    pbj.HoldJelly();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as PrehistoricPBJ).HoldJelly();
                }
            }
        }

        /// <summary>
        /// Navigates to appropriate page
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

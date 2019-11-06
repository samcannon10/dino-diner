/*CustomizeVelociWrap.xaml.cs
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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        private bool isCombo;

        /// <summary>
        /// Constructor for Veloci-Wrap customization Page
        /// </summary>
        /// <param name="combo">Whether or not this is part of a combo</param>
        public CustomizeVelociWrap(bool combo)
        {
            InitializeComponent();
            isCombo = combo;
        }

        /// <summary>
        /// Holds lettuce for this entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldLettuce(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap vw)
                {
                    vw.HoldLettuce();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as VelociWrap).HoldLettuce();
                }
            }
        }

        /// <summary>
        /// Holds cheese for this entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap vw)
                {
                    vw.HoldCheese();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as VelociWrap).HoldCheese();
                }
            }
        }

        /// <summary>
        /// Holds dressing for this entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldDressing(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap vw)
                {
                    vw.HoldDressing();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as VelociWrap).HoldDressing();
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

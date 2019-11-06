/*CustomizeKingBurger.xaml.cs
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
    /// Interaction logic for CustomizeKingBurger.xaml
    /// </summary>
    public partial class CustomizeKingBurger : Page
    {
        private bool isCombo;

        /// <summary>
        /// Constructor for T-Rex King Burger customization page
        /// </summary>
        /// <param name="combo">Whether or not this is part of a combo</param>
        public CustomizeKingBurger(bool combo)
        {
            InitializeComponent();
            isCombo = combo;
        }

        /// <summary>
        /// Holds bun for this entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldBun(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger kb)
                {
                    kb.HoldBun();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as TRexKingBurger).HoldBun();
                }
            }
        }

        /// <summary>
        /// Holds mayo for this entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldMayo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger kb)
                {
                    kb.HoldMayo();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as TRexKingBurger).HoldMayo();
                }
            }
        }

        /// <summary>
        /// Holds ketchup for this entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldKetchup(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger kb)
                {
                    kb.HoldKetchup();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as TRexKingBurger).HoldKetchup();
                }
            }
        }

        /// <summary>
        /// Holds mustard for this entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldMustard(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger kb)
                {
                    kb.HoldMustard();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as TRexKingBurger).HoldMustard();
                }
            }
        }

        /// <summary>
        /// Holds pickle for this entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldPickle(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger kb)
                {
                    kb.HoldPickle();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as TRexKingBurger).HoldPickle();
                }
            }
        }

        /// <summary>
        /// Holds tomato for this entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldTomato(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger kb)
                {
                    kb.HoldTomato();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as TRexKingBurger).HoldTomato();
                }
            }
        }

        /// <summary>
        /// Holds onion for this entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldOnion(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger kb)
                {
                    kb.HoldOnion();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as TRexKingBurger).HoldOnion();
                }
            }
        }

        /// <summary>
        /// Holds lettuce for this entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldLettuce(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger kb)
                {
                    kb.HoldLettuce();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as TRexKingBurger).HoldLettuce();
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

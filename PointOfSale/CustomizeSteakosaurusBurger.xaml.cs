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
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        private bool isCombo;

        public CustomizeSteakosaurusBurger(bool combo)
        {
            InitializeComponent();
            isCombo = combo;
        }

        public void HoldBun(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger sb)
                {
                    sb.HoldBun();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as SteakosaurusBurger).HoldBun();
                }
            }
        }

        public void HoldKetchup(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger sb)
                {
                    sb.HoldKetchup();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as SteakosaurusBurger).HoldKetchup();
                }
            }
        }

        public void HoldMustard(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger sb)
                {
                    sb.HoldMustard();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as SteakosaurusBurger).HoldMustard();
                }
            }
        }

        public void HoldPickle(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger sb)
                {
                    sb.HoldPickle();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    (combo.Entree as SteakosaurusBurger).HoldPickle();
                }
            }
        }

        public void ReturnToMenuSelection(object sender, RoutedEventArgs args)
        {
            if (isCombo == true) NavigationService.Navigate(new CustomizeCombo());
            else NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}

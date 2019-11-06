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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private bool isCombo;

        /// <summary>
        /// Initializes DrinkSelection Page
        /// </summary>
        public DrinkSelection(bool combo)
        {
            InitializeComponent();
            LemonButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Collapsed;
            DecafButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Collapsed;
            SweetButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Collapsed;

            isCombo = combo;
        }

        /// <summary>
        /// Sends user to FlavorSelection Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ChooseFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection(isCombo));
        }

        /// <summary>
        /// Hides and shows Buttons appropriate for Water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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

            if (DataContext is Order order)
            {
                if (isCombo == false)
                {
                    order.Add(new Water());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Drink = new Water();
                    combo.Drink.Size = combo.Size;
                    UpdateButtons();
                }
            }
        }

        /// <summary>
        /// Hides and shows Buttons appropriate for Sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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

            if (DataContext is Order order)
            {
                if (isCombo == false)
                {
                    order.Add(new Sodasaurus());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Drink = new Sodasaurus();
                    combo.Drink.Size = combo.Size;
                    UpdateButtons();
                }
            }
        }

        /// <summary>
        /// Hides and shows Buttons appropriate for Jurassic Java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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

            if (DataContext is Order order)
            {
                if (isCombo == false)
                {
                    order.Add(new JurassicJava());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Drink = new JurassicJava();
                    combo.Drink.Size = combo.Size;
                    UpdateButtons();
                }
            }
        }

        /// <summary>
        /// Hides and shows Buttons appropriate for Tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void TyrannoteaClick(object sender, RoutedEventArgs args)
        {
            LemonButton.Visibility = Visibility.Visible;
            SweetButton.Visibility = Visibility.Visible;
            IceButton.Visibility = Visibility.Visible;

            DecafButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Collapsed;
            FlavorButton.Visibility = Visibility.Hidden;
            FlavorButton.Visibility = Visibility.Collapsed;

            if (DataContext is Order order)
            {
                if (isCombo == false)
                {
                    order.Add(new Tyrannotea());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Drink = new Tyrannotea();
                    combo.Drink.Size = combo.Size;
                    UpdateButtons();
                }
            }
        }

        /// <summary>
        /// Makes the selected drink decaf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddDecaf(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava java) java.Decaf = true;
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo) (combo.Drink as JurassicJava).Decaf = true;
            }
        }

        /// <summary>
        /// Makes the selected drink sweet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void MakeSweet(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea tea) tea.Sweet = true;
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo) (combo.Drink as Tyrannotea).Sweet = true;
            }
        }

        /// <summary>
        /// Adds ice to the selected drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddIce(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava java) java.AddIce();
            }
        }

        /// <summary>
        /// Hold ice on the selected drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldIce(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink) drink.HoldIce();
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo) combo.Drink.HoldIce();
            }
        }

        /// <summary>
        /// Adds lemon to the selected drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddLemon(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea tea) tea.AddLemon();
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Water water) water.AddLemon();
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo) (combo.Drink as Tyrannotea).AddLemon();
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo1) (combo1.Drink as Water).AddLemon();
            }
        }

        /// <summary>
        /// Returns user to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnToMenuSelection(object sender, RoutedEventArgs e)
        {
            if (isCombo == true) NavigationService.Navigate(new CustomizeCombo());
            else NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Sets the size of the selected drink to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetLarge(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    LargeButton.IsChecked = true;
                    drink.Size = DinoDiner.Menu.Size.Large;
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    UpdateButtons();
                }
            }
        }

        /// <summary>
        /// Sets the size of the selected drink to Medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetMedium(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    MediumButton.IsChecked = true;
                    drink.Size = DinoDiner.Menu.Size.Medium;
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    UpdateButtons();
                }
            }
        }

        /// <summary>
        /// Sets the size of the selected drink to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetSmall(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    SmallButton.IsChecked = true;
                    drink.Size = DinoDiner.Menu.Size.Small;
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    UpdateButtons();
                }
            }
        }

        /// <summary>
        /// Updates special buttons when an order item
        /// is selected in the order
        /// </summary>
        public void UpdateButtons()
        {
            if(DataContext is Order order)
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink.Size == DinoDiner.Menu.Size.Small) SmallButton.IsChecked = true;
                    else if (drink.Size == DinoDiner.Menu.Size.Medium) MediumButton.IsChecked = true;
                    else if (drink.Size == DinoDiner.Menu.Size.Large) LargeButton.IsChecked = true;

                    if(drink is Water water)
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
                    else if(drink is Tyrannotea tea)
                    {
                        LemonButton.Visibility = Visibility.Visible;
                        SweetButton.Visibility = Visibility.Visible;
                        IceButton.Visibility = Visibility.Visible;

                        DecafButton.Visibility = Visibility.Hidden;
                        DecafButton.Visibility = Visibility.Collapsed;
                        FlavorButton.Visibility = Visibility.Hidden;
                        FlavorButton.Visibility = Visibility.Collapsed;
                    }
                    else if(drink is Sodasaurus soda)
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
                    else if(drink is JurassicJava java)
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
                }
                else if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Drink.Size == DinoDiner.Menu.Size.Small) SmallButton.IsChecked = true;
                    else if (combo.Drink.Size == DinoDiner.Menu.Size.Medium) MediumButton.IsChecked = true;
                    else if (combo.Drink.Size == DinoDiner.Menu.Size.Large) LargeButton.IsChecked = true;

                    if (combo.Drink is Water water)
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
                    else if (combo.Drink is Tyrannotea tea)
                    {
                        LemonButton.Visibility = Visibility.Visible;
                        SweetButton.Visibility = Visibility.Visible;
                        IceButton.Visibility = Visibility.Visible;

                        DecafButton.Visibility = Visibility.Hidden;
                        DecafButton.Visibility = Visibility.Collapsed;
                        FlavorButton.Visibility = Visibility.Hidden;
                        FlavorButton.Visibility = Visibility.Collapsed;
                    }
                    else if (combo.Drink is Sodasaurus soda)
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
                    else if (combo.Drink is JurassicJava java)
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

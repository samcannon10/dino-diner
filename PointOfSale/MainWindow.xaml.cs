/*MainWindow.xaml.cs
 * Author: Nathan Bean
 * Modified by: Samuel Cannon
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes MainWindow Window
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Order order = DataContext as Order;
        }

        /// <summary>
        /// Passes on DataContext
        /// </summary>
        private void PassOnDataContext()
        {
            Page page = OrderUI.Content as Page;
            if(page != null)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }

        /// <summary>
        /// For when load is completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassOnDataContext();
        }

        /// <summary>
        /// For when DataContext is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassOnDataContext();
        }

        /// <summary>
        /// For when the selection of the local order
        /// control is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if(OrderUI.Content is DrinkSelection drinkSelection)
            {
                drinkSelection.UpdateButtons();
            }
            else if(OrderUI.Content is SideSelection sideSelection)
            {
                sideSelection.UpdateSize();
            }
        }
    }
}

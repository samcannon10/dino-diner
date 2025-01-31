﻿/*Order.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for Order objects
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        private ObservableCollection<IOrderItem> items;
        /*

        /// <summary>
        /// Items included in this Order
        /// </summary>
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }      
        }*/

        public ObservableCollection<IOrderItem> Items
        {
            get
            {
                return items;
            }
        }


        /// <summary>
        /// Cost of order before tax
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double total = 0;

                foreach (IOrderItem i in Items) total += i.Price;
                if (total < 0) total = 0;

                return total;
            }
        }

        /// <summary>
        /// Gets and sets sales tax rate
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// Calculates sales tax cost
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        /// <summary>
        /// Calculates total cost including tax
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SalesTaxCost + SubtotalCost;
            }
        }

        /// <summary>
        /// Constructor for Order item
        /// </summary>
        public Order()
        {
            SalesTaxRate = 0.0825;
            items = new ObservableCollection<IOrderItem>();
        }

        public void Add(IOrderItem item)
        {
            items.Add(item);
            NotifyOfPropertyChanged("Items");
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
            item.PropertyChanged += OnPropertyChanged;
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyOfPropertyChanged("Items");
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
        }

        public bool Remove(IOrderItem item)
        {
            bool remove = items.Remove(item);
            item.PropertyChanged -= OnPropertyChanged;
            NotifyOfPropertyChanged("Items");
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
            return remove;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
        {
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
        }
    }
}

/*Order.cs
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
        List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Items included in this Order
        /// </summary>
        public IOrderItem[] Items { get { return items.ToArray(); } }

        /// <summary>
        /// Cost of order before tax
        /// </summary>
        public double SubtotalCost {
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

        public Order()
        {
            SalesTaxRate = 0.0825;

            //this.items.CollectionChanged += this.OnCollectionChanged;
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnItemPropertyChanged;
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if(removed)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
            return removed;
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
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

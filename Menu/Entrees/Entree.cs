/*Entree.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        protected double price;
        protected uint calories;
        /// <summary>
        /// Property for price of entree
        /// </summary>
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                NotifyOfPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Property for calories in entree
        /// </summary>
        public uint Calories
        {
            get
            {
                return calories;
            }
            set
            {
                calories = value;
                NotifyOfPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// Property for ingredients in entree
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets description as a string
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Holds any special instructions for preparation
        /// </summary>
        public abstract string[] Special { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

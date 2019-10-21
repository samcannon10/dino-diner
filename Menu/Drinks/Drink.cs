/*Drink.cs
 * Author: Samuel Cannon
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{

    /// <summary>
    /// base Drink class
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Backing variable for drink size
        /// </summary>
        protected Size size;
        protected double price;
        protected uint calories;
        protected bool ice = true;

        /// <summary>
        /// Gets and sets price of drink
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
        /// Gets and sets calories of drink
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
        /// Property for if there is ice or not
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
                NotifyOfPropertyChanged("Ice");
            }
        }

        /// <summary>
        /// Property for ingredients in drink
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Property for size of a drink
        /// </summary>
        public abstract Size Size { get; set; }

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

        /// <summary>
        /// Sets Ice to false
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");
        }
    }
}

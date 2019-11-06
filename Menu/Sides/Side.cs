/*Side.cs
 * Author: Nathan Bean
 * Modified by: Samuel Cannon
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{

    public enum Size
    {
        Small,
        Medium, 
        Large
    }

    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        protected Size size = Size.Small;
        protected double price;
        protected uint calories;

        /// <summary>
        /// Gets and sets the price
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
        /// Gets and sets the calories
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
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
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
        public string[] Special
        {
            get
            {
                return new string[0];
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

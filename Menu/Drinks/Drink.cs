/*Drink.cs
 * Author: Samuel Cannon
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// enum for possible drinks sizes
    /// </summary>
    public enum Size
    {
        Small,
        Medium,
        Large
    }


    /// <summary>
    /// base Drink class
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Backing variable for drink size
        /// </summary>
        protected Size size;

        /// <summary>
        /// Gets and sets price of drink
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets calories of drink
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Property for if there is ice or not
        /// </summary>
        public bool Ice { get; set; }

        /// <summary>
        /// Property for ingredients in drink
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Property for size of a drink
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Sets Ice to false
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
    }
}

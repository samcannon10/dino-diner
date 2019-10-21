/*Water.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Water drink
    /// </summary>
    public class Water : Drink
    {
        protected bool lemon;

        /// <summary>
        /// Property for size enum for this drink
        /// </summary>
        public override Size Size
        { 
            get
            {
                return size;
            }
            set
            {
                size = value;
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// Property for if lemon is included
        /// or not
        /// </summary>
        public bool Lemon
        { 
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
                NotifyOfPropertyChanged("Lemon");
            }
        }

        /// <summary>
        /// Property for ingredients in this drink
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Holds any special instructions for preparation
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for Water Drink
        /// </summary>
        public Water()
        {
            price = 0.10;
            calories = 0;
            lemon = false;
        }

        /// <summary>
        /// Sets Lemon to true;
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Default ToString for water
        /// </summary>
        /// <returns>The drink and its size as a string</returns>
        public override string ToString()
        {
            return this.Size + " Water";
        }
    }
}

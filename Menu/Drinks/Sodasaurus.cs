/*Sodasaurus.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{

    /// <summary>
    /// enum for possible Sodasaurus flavors
    /// </summary>
    public enum SodasaurusFlavor
    {
        Cola,
        Orange,
        Vanilla,
        Chocolate,
        RootBeer,
        Cherry,
        Lime
    }

    /// <summary>
    /// Sodasaurus drink
    /// </summary>
    public class Sodasaurus : Drink
    {
        protected SodasaurusFlavor flavor;

        /// <summary>
        /// Property for size enum for this drink.
        /// Sets price and calories accordingly
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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
                switch(size)
                {
                    case Size.Small:
                        Price = 1.5;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.5;
                        Calories = 208;
                        break;
                }
            }
        }

        /// <summary>
        /// Property for ingredients in drink
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }

        /// <summary>
        /// Property for the flavor of this soda
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyOfPropertyChanged("Flavor");
                NotifyOfPropertyChanged("Description");
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for Sodasaurus Drink
        /// </summary>
        public Sodasaurus()
        {
            price = 1.5;
            calories = 112;
            flavor = SodasaurusFlavor.Cola;
        }


        /// <summary>
        /// Default ToString for Sodasaurus
        /// </summary>
        /// <returns>The drink, its flavor, and its size as a string</returns>
        public override string ToString()
        {
            return this.Size + " " + this.Flavor + " Sodasaurus";
        }
    }
}

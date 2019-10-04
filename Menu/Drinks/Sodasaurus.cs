/*Sodasaurus.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;

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
        public SodasaurusFlavor Flavor { get; set; }

        /// <summary>
        /// Constructor for Sodasaurus Drink
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.5;
            Calories = 112;
            Ice = true;
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

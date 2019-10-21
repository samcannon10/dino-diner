/*Fryceritops.cs
 * Author: Samuel Cannon
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Fryceritops Side
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// Property for size enum for this
        /// side. Overriden from Side class.
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
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;

                }
            }
        }

        /// <summary>
        /// Property for ingredients in side
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for Fryceritops side
        /// </summary>
        public Fryceritops()
        {
            Calories = 222;
            Price = 0.99;
        }

        /// <summary>
        /// Default ToString for Fryceritops
        /// </summary>
        /// <returns>The side and its size as a string</returns>
        public override string ToString()
        {
            return this.Size + " Fryceritops";
        }
    }
}

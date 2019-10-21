/*Triceritots.cs
 * Author: Samuel Cannon
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Triceritots side
    /// </summary>
    public class Triceritots : Side
    {
        /// <summary>
        /// Property for size enum of this
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
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
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
        /// Constructor for Triceritots side
        /// </summary>
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
        }

        /// <summary>
        /// Default ToString for Triceritots
        /// </summary>
        /// <returns>The side and its size as a stirng</returns>
        public override string ToString()
        {
            return this.Size + " Triceritots";
        }
    }
}

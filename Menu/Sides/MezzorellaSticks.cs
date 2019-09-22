/*MezzorellaSticks.cs
 * Author: Samuel Cannon
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// MezzorellaSticks Side
    /// </summary>
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// Property for Size enum for this
        /// side. Overriden from Side class
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
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;

                }
            }
        }

        /// <summary>
        /// Property for price of side
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Property for calories in side
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Property for ingredients in side
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for MezzorellaSticks side
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
        }

    }
}

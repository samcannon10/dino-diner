/*Water.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Water drink
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Property for size enum for this drink
        /// </summary>
        public override Size Size { get; set; }

        /// <summary>
        /// Property for if lemon is included
        /// or not
        /// </summary>
        public bool Lemon { get; set; }

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
        /// Constructor for Water Drink
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            Lemon = false;
            Ice = true;
        }

        /// <summary>
        /// Sets Lemon to true;
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
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

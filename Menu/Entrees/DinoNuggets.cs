/*DinoNuggets.cs
 * Author: Samuel Cannon
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Dino Nuggets entree
    /// </summary>
    public class DinoNuggets : Entree
    {
        private int nuggetCount;

        /// <summary>
        /// Property for ingredients in entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if(nuggetCount > 6)
                {
                    special.Add($"{nuggetCount - 6} Extra Nuggets");
                }
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for DinoNuggets entree
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 6 * 59;
            this.nuggetCount = 6;
        }

        /// <summary>
        /// Adds appropriate amount to Price and 
        /// Calories when an extra nugget is added
        /// </summary>
        public void AddNugget()
        {
            this.Price += 0.25;
            this.Calories += 59;
            this.nuggetCount++;
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Special");
        }


        /// <summary>
        /// Default ToString for DinoNuggets
        /// </summary>
        /// <returns>The name of the entree as a string</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}

/*Brontowurst.cs
 * Author: Samuel Cannon
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Brontowurst entree
    /// </summary>
    public class Brontowurst : Entree
    {
        /// <summary>
        /// bool for if bun is included
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// bool for if peppers are included
        /// </summary>
        private bool peppers = true;
        /// <summary>
        /// bool for if onions are included
        /// </summary>
        private bool onions = true;

        /// <summary>
        /// Property for price of entree
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Property for calories in entree
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Property for ingredients in entree
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for Brontowurst entree
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Removes bun from entree
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Removes peppers from entree
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Removes onions from entree
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}

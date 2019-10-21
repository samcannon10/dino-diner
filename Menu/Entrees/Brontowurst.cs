/*Brontowurst.cs
 * Author: Samuel Cannon
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
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
        /// Property for ingredients in entree
        /// </summary>
        public override List<string> Ingredients
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
        /// Holds any special instructions for preparation
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Bun");
                if (!peppers) special.Add("Hold Pepper");
                if (!onions) special.Add("Hold Onion");
                return special.ToArray();
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
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes peppers from entree
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes onions from entree
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Default ToString for Brontowurst
        /// </summary>
        /// <returns>The name of the entree as a string</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}

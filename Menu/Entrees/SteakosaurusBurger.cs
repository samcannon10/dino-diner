/*SteakosaursBurger.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Steakosaurus Burger entree
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// bool for if bun is included
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// bool for if pickles included
        /// </summary>
        private bool pickles = true;
        /// <summary>
        /// bool for if ketchup is included
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// bool for if mustard is included
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// Property for ingredients in entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickles) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
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
                if (!pickles) special.Add("Hold Pickles");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for SteakosaurusBurger entree
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
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
        /// Removes pickles from entree
        /// </summary>
        public void HoldPickle()
        {
            this.pickles = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes ketchup from entree
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes mustard from entree
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Default ToString for SteakosaurusBurger
        /// </summary>
        /// <returns>The name of the entree as a string</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}

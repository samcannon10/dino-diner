/*SteakosaursBurger.cs
 * Author: Samuel Cannon
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
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
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickles) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
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
        }

        /// <summary>
        /// Removes pickles from entree
        /// </summary>
        public void HoldPickle()
        {
            this.pickles = false;
        }

        /// <summary>
        /// Removes ketchup from entree
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Removes mustard from entree
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}

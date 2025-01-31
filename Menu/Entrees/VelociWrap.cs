﻿/*VelociWrap.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Veloci-Wrap entree
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// bool for if dressing is included
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// bool for if lettuce is included
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// bool for if cheese is included
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// Property for ingredients in entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
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
                if (!dressing) special.Add("Hold Dressing");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!cheese) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for Velociwrap entree
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Removes dressing from entree
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes lettuce from entree
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes cheese from entree
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Default ToString for VelociWrap
        /// </summary>
        /// <returns>The name of the entree as a string</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}

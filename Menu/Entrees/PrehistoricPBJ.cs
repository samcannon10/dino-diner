/*PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified by: Samuel Cannon
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Prehistoric PB & J entree
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// bool for if peanut butter is included
        /// </summary>
        private bool peanutButter = true;
        /// <summary>
        /// bool for if jelly is included
        /// </summary>
        private bool jelly = true;

        /// <summary>
        /// Property for ingredients in entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
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
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for PrehistoricPBJ entree
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Removes peanut butter from entree
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes jelly from entree
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChanged("Special");
        }


        /// <summary>
        /// Default ToString for PrehistoricPBJ
        /// </summary>
        /// <returns>The name of the entree as a string</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}

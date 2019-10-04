/*PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified by: Samuel Cannon
 */
using System.Collections.Generic;

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
        }

        /// <summary>
        /// Removes jelly from entree
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
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

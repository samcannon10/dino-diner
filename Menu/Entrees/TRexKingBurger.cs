/*TRexKingBurger.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// T-Rex King Burger entree
    /// </summary>
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// bool for if bun is included
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// bool for if lettuce is included
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// bool for if tomato is included
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// bool for if onion is included
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// bool for if pickle is included
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// bool for if ketchup is included
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// bool for if mustard is included
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// bool for if mayo is included
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// Property for ingredients in entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < 3; i++)
                {
                    ingredients.Add("Steakburger Pattie");
                }
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
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
                if (!lettuce) special.Add("Hold Lettuce");
                if (!tomato) special.Add("Hold Tomato");
                if (!onion) special.Add("Hold Onion");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for TRexKingBurger entree
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
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
        /// Removes lettuce from entree
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes tomato from entree
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes onion from entree
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes pickles from entree
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
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
        /// Removes mayo from entree
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Default ToString for TRexKingBurger
        /// </summary>
        /// <returns>The name of the entree as a string</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}

/*MeteorMacAndCheese.cs
 * Author: Samuel Cannon
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// MeteorMacAndCheese Side
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// Property for side enum for this
        /// class. Overriden from Side class
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;

                }
            }
        }

        /// <summary>
        /// Property for ingredients in side
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for MeteorMacAndCheese side
        /// </summary>
        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;
        }

        /// <summary>
        /// Deafult ToString for MeteorMacAndCheese
        /// </summary>
        /// <returns>The side and its size as a string</returns>
        public override string ToString()
        {
            return this.Size + " Meteor Mac and Cheese";
        }
    }
}

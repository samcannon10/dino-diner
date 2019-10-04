/*Tyrannotea.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Tyrannotea drink
    /// </summary>
    public class Tyrannotea : Drink
    {
        // backing variable for sweet tea
        private bool sweet = false;

        /// <summary>
        /// Property for size enum for this 
        /// drink. Sets price and calories accordingly.
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
                switch(size)
                {
                    case Size.Small:
                        if (Sweet) Calories = 16;
                        else Calories = 8;
                        Price = 0.99;
                        break;
                    case Size.Medium:
                        if (Sweet) Calories = 32;
                        else Calories = 16;
                        Price = 1.49;
                        break;
                    case Size.Large:
                        if (Sweet) Calories = 64;
                        else Calories = 32;
                        Price = 1.99;
                        break;
                }
            }
        }

        /// <summary>
        /// Property for ingredients in drink
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (Sweet) ingredients.Add("Cane Sugar");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Property for if the tea is sweet
        /// </summary>
        public bool Sweet {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                if (sweet)
                {
                    switch (Size)
                    {
                        case Size.Small:
                            Calories = 16;
                            break;
                        case Size.Medium:
                            Calories = 32;
                            break;
                        case Size.Large:
                            Calories = 64;
                            break;
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Small:
                            Calories = 8;
                            break;
                        case Size.Medium:
                            Calories = 16;
                            break;
                        case Size.Large:
                            Calories = 32;
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Property for if lemon is included
        /// or not
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// Constructor for Tyrannotea Drink
        /// </summary>
        public Tyrannotea()
        {
            Price = .99;
            Calories = 8;
            Ice = true;
            Lemon = false;
            Sweet = false;
        }

        /// <summary>
        /// Sets Lemon to true
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }


        /// <summary>
        /// Default ToString for Tyrannotea
        /// </summary>
        /// <returns>The drink, its size, and if it is sweet as a string</returns>
        public override string ToString()
        {
            if (Sweet) return this.Size + " Sweet Tyrannotea";
            else return this.Size + " Tyrannotea";
        }
    }
}

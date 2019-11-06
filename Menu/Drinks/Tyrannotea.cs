/*Tyrannotea.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Tyrannotea drink
    /// </summary>
    public class Tyrannotea : Drink
    {
        // backing variables
        private bool sweet;
        protected bool lemon;

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
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Special");
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

                NotifyOfPropertyChanged("Sweet");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Property for if lemon is included
        /// or not
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
                NotifyOfPropertyChanged("Lemon");
                NotifyOfPropertyChanged("Special");
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
                if (Lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for Tyrannotea Drink
        /// </summary>
        public Tyrannotea()
        {
            price = .99;
            calories = 8;
            lemon = false;
            sweet = false;
        }

        /// <summary>
        /// Sets Lemon to true
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Lemon");
            NotifyOfPropertyChanged("Special");
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

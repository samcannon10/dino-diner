/*JurassicJava.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// JurassicJava drink
    /// </summary>
    public class JurassicJava : Drink
    {
        protected bool roomForCream;
        protected bool decaf;

        /// <summary>
        /// Property for size enum for this drink.
        /// Sets price and calories accordingly
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
                switch(size)
                {
                    case Size.Small:
                        Calories = 2;
                        Price = 0.59;
                        break;
                    case Size.Medium:
                        Calories = 4;
                        Price = 0.99;
                        break;
                    case Size.Large:
                        Calories = 8;
                        Price = 1.49;
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
                return new List<string>() { "Water", "Coffee" };
            }
        }

        /// <summary>
        /// Property to leave room for cream or not
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                roomForCream = value;
                NotifyOfPropertyChanged("RoomForCream");
                NotifyOfPropertyChanged("Special");
            }
        }
        
        /// <summary>
        /// Property to make coffee decaf or not
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
                NotifyOfPropertyChanged("Decaf");
                if (decaf) NotifyOfPropertyChanged("Description");
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
                if (RoomForCream) special.Add("Room for Cream");
                if (Ice) special.Add("Add Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for JurassicJava Drink
        /// </summary>
        public JurassicJava()
        {
            calories = 2;
            price = 0.59;
            ice = false;
            roomForCream = false;
            decaf = false;
        }

        /// <summary>
        /// Sets RoomForCream to true
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Sets Ice to true
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChanged("Ice");
            NotifyOfPropertyChanged("Special");
        }


        /// <summary>
        /// Default ToString for Jurassic Java
        /// </summary>
        /// <returns>The drink, its size, and if it is decaf as a string</returns>
        public override string ToString()
        {
            if (Decaf) return this.Size + " Decaf Jurassic Java";
            else return this.Size + " Jurassic Java";
        }
    }
}

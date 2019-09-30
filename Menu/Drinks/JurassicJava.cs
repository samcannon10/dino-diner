/*JurassicJava.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// JurassicJava drink
    /// </summary>
    public class JurassicJava : Drink
    {
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
        public bool RoomForCream { get; set; }
        
        /// <summary>
        /// Property to make coffee decaf or not
        /// </summary>
        public bool Decaf { get; set; }

        /// <summary>
        /// Constructor for JurassicJava Drink
        /// </summary>
        public JurassicJava()
        {
            Calories = 2;
            Price = 0.59;
            Ice = false;
            RoomForCream = false;
            Decaf = false;
        }

        /// <summary>
        /// Sets RoomForCream to true
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        /// <summary>
        /// Sets Ice to true
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }
    }
}

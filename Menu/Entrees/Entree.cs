/*Entree.cs
 * Author: Samuel Cannon
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public abstract class Entree
    {
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
        public List<string> Ingredients { get; }
    }
}

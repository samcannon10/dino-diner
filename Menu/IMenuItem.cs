/*IMenuItem.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for all menu items
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Gets price of an item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets calories in an item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Gets list of ingredients in an item
        /// </summary>
        List<string> Ingredients { get; }
    }
}

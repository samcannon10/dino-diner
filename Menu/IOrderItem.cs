/*IOrderItem.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for Order Items
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets price of an order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets description as a string
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Holds any special instructions for preparation
        /// </summary>
        string[] Special { get; }
    }
}

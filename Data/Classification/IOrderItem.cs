/*
 * Author: Lukas Hurtig
 * Class: IOrderItem.cs
 * Purpose: Create an interface class for all order items
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Classification
{
    /// <summary>
    /// An interface class for all of the menu items
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// References the price value for all order items
        /// </summary>
        double Price { get; }

        /// <summary>
        /// References the calories value for all order items
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// References the Special Instructions for all order items
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}

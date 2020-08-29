/*
 * Author: Lukas Hurtig
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent Markarth Milk and its properties
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// provides properties describing Markarth Milk
    /// </summary>
    class MarkarthMilk
    {
        /// <summary>
        /// the size of the drink
        /// </summary>
        private Size size = Size.Small;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        /// <summary>
        /// the price of the drink
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Medium) return 1.11;
                if (size == Size.Large) return 1.22;
                else return 1.05;
            }
        }

        /// <summary>
        /// how many calories are in the drink
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Medium) return 72;
                if (size == Size.Large) return 93;
                else return 56;
            }
        }

        /// <summary>
        /// boolean representing ice or not
        /// </summary>
        private bool ice = false;
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
            }
        }

        /// <summary>
        /// lists out special instructions for the drink
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if (Ice) SpecialInstructions.Add("Add ice");
                return SpecialInstructions;
            }
        }

        /// <summary>
        /// over rides the ToString method to return the menu item name
        /// </summary>
        /// <returns>the order in plain english in a string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Markarth Milk";
        }
    }
}

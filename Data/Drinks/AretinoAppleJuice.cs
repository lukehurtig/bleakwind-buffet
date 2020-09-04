/*
 * Author: Lukas Hurtig
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent Aretino Apple Juice and its properties
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// provides properties describing Aretino Apple Juice
    /// </summary>
    public class AretinoAppleJuice
    {
        /// <summary>
        /// the size of the drink
        /// </summary>
        public Size size = Size.Small;
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
                if (size == Size.Medium) return 0.87;
                if (size == Size.Large) return 1.01;
                else return 0.62;
            }
        }

        /// <summary>
        /// how many calories are in the drink
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Medium) return 88;
                if (size == Size.Large) return 132;
                else return 44;
            }
        }

        /// <summary>
        /// boolean representing ice or not
        /// </summary>
        public bool ice = false;
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
            return Size.ToString() + " Aretino Apple Juice";
        }
    }
}

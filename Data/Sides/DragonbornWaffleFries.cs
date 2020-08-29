/*
 * Author: Lukas Hurtig
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent Dragonborn Waffle Fries and its properties
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// provides properties describing Dragonborn Waffle Fries
    /// </summary>
    class DragonbornWaffleFries
    {
        /// <summary>
        /// the size of the side
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
        /// the price of the side
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Medium) return 0.76;
                if (size == Size.Large) return 0.96;
                else return 0.42;
            }
        }

        /// <summary>
        /// how many calories are in the side
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Medium) return 89;
                if (size == Size.Large) return 100;
                else return 77;
            }
        }

        /// <summary>
        /// returns an empty list
        /// </summary>
        public List<string> SpecialInstructions = new List<string>();

        /// <summary>
        /// over rides the ToString method to return the menu item name
        /// </summary>
        /// <returns>the order in plain english in a string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Dragonborn Waffle Fries";
        }
    }
}

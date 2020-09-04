/*
 * Author: Lukas Hurtig
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent Vokun Salad and its properties
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// provides properties describing Vokun Salad
    /// </summary>
    public class VokunSalad
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
                if (size == Size.Medium) return 1.28;
                if (size == Size.Large) return 1.82;
                else return 0.93;
            }
        }

        /// <summary>
        /// how many calories are in the side
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
        /// returns an empty list
        /// </summary>
        public List<string> SpecialInstructions = new List<string>();

        /// <summary>
        /// over rides the ToString method to return the menu item name
        /// </summary>
        /// <returns>the order in plain english in a string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Vokun Salad";
        }
    }
}

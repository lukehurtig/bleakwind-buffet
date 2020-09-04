/*
 * Author: Lukas Hurtig
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent Mad Otar Grits and its properties
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// provides properties describing Mad Otar Grits
    /// </summary>
    public class MadOtarGrits
    {
        /// <summary>
        /// the size of the side
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
        /// the price of the side
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Medium) return 1.58;
                if (size == Size.Large) return 1.93;
                else return 1.22;
            }
        }

        /// <summary>
        /// how many calories are in the side
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Medium) return 142;
                if (size == Size.Large) return 179;
                else return 105;
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
            return Size.ToString() + " Mad Otar Grits";
        }
    }
}

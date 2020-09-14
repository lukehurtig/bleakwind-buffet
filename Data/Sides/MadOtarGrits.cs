/*
 * Author: Lukas Hurtig
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent Mad Otar Grits and its properties
 */

using BleakwindBuffet.Data.Classification;
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// provides properties describing Mad Otar Grits
    /// </summary>
    public class MadOtarGrits : Side, IOrderItem
    {
        /// <summary>
        /// the price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Medium) return 1.58;
                if (Size == Size.Large) return 1.93;
                else return 1.22;
            }
        }

        /// <summary>
        /// how many calories are in the side
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 142;
                if (Size == Size.Large) return 179;
                else return 105;
            }
        }

        /// <summary>
        /// returns an empty list
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

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

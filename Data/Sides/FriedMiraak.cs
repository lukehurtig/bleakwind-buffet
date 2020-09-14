/*
 * Author: Lukas Hurtig
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent Fried Miraak and its properties
 */

using BleakwindBuffet.Data.Classification;
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// provides properties describing Fried Miraak
    /// </summary>
    public class FriedMiraak : Side, IOrderItem
    {
        /// <summary>
        /// the price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Medium) return 2.01;
                if (Size == Size.Large) return 2.88;
                else return 1.78;
            }
        }

        /// <summary>
        /// how many calories are in the side
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 236;
                if (Size == Size.Large) return 306;
                else return 151;
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
            return Size.ToString() + " Fried Miraak";
        }
    }
}

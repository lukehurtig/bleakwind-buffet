/*
 * Author: Lukas Hurtig
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent Dragonborn Waffle Fries and its properties
 */

using BleakwindBuffet.Data.Classification;
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// provides properties describing Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries : Side, IOrderItem
    {
        /// <summary>
        /// the price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Medium) return 0.76;
                if (Size == Size.Large) return 0.96;
                else return 0.42;
            }
        }

        /// <summary>
        /// how many calories are in the side
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 89;
                if (Size == Size.Large) return 100;
                else return 77;
            }
        }

        /// <summary>
        /// returns an empty list
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                return new List<string> ();
            }
        }

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

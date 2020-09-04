/*
 * Author: Lukas Hurtig
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent Candlehearth Coffee and its properties
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// provides properties describing Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee
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
                if (size == Size.Medium) return 1.25;
                if (size == Size.Large) return 1.75;
                else return 0.75;
            }
        }

        /// <summary>
        /// how many calories are in the drink
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Medium) return 10;
                if (size == Size.Large) return 20;
                else return 7;
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
        /// boolean representing if they want room for cream or not
        /// </summary>
        private bool roomForCream = false;
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                roomForCream = value;
            }
        }

        /// <summary>
        /// boolean representing if they want decaf or not
        /// </summary>
        private bool decaf = false;
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
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
                if (RoomForCream) SpecialInstructions.Add("Add cream");
                return SpecialInstructions;
            }
        }

        /// <summary>
        /// over rides the ToString method to return the menu item name
        /// </summary>
        /// <returns>the order in plain english in a string</returns>
        public override string ToString()
        {
            return Size.ToString() + " CandlehearthCoffee";
        }
    }
}

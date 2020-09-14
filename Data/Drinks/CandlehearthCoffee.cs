/*
 * Author: Lukas Hurtig
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent Candlehearth Coffee and its properties
 */

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Classification;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// provides properties describing Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem
    {
        /// <summary>
        /// the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Medium) return 1.25;
                if (Size == Size.Large) return 1.75;
                else return 0.75;
            }
        }

        /// <summary>
        /// how many calories are in the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 10;
                if (Size == Size.Large) return 20;
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
        private List<string> specialInstructions = new List<string>();
        public override List<string> SpecialInstructions
        {
            get
            {
                if (Ice) specialInstructions.Add("Add ice");
                if (RoomForCream) specialInstructions.Add("Add cream");
                return specialInstructions;
            }
        }

        /// <summary>
        /// over rides the ToString method to return the menu item name
        /// </summary>
        /// <returns>the order in plain english in a string</returns>
        public override string ToString()
        {
            if (!Decaf) return Size.ToString() + " Candlehearth Coffee";
            else return Size.ToString() + " Decaf Candlehearth Coffee";
        }
    }
}

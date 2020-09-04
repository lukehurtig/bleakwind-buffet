/*
 * Author: Lukas Hurtig
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent Warrior Water and its properties
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// provides properties describing Warrior Water
    /// </summary>
    public class WarriorWater
    {
        /// <summary>
        /// the size of the water
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
        /// the price of the water
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Medium) return 0.00;
                if (size == Size.Large) return 0.00;
                else return 0.00;
            }
        }

        /// <summary>
        /// how many calories are in the water
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Medium) return 0;
                if (size == Size.Large) return 0;
                else return 0;
            }
        }

        /// <summary>
        /// boolean representing ice or not
        /// </summary>
        private bool ice = true;
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
        /// boolean representing lemon or not
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
            }
        }

        /// <summary>
        /// lists out special instructions for the drink
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if (!Ice) SpecialInstructions.Add("Hold ice");
                if (Lemon) SpecialInstructions.Add("Add lemon");
                return SpecialInstructions;
            }
        }

        /// <summary>
        /// over rides the ToString method to return the menu item name
        /// </summary>
        /// <returns>the order in plain english in a string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Warrior Water";
        }
    }
}

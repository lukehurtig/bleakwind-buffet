/*
 * Author: Lukas Hurtig
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent Sailor Soda and its properties
 */

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Classification;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// provides properties describing Sailor Soda
    /// </summary>
    public class SailorSoda : Drink, IOrderItem
    {
        /// <summary>
        /// the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Medium) return 1.74;
                if (Size == Size.Large) return 2.07;
                else return 1.42;
            }
        }

        /// <summary>
        /// how many calories are in the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 153;
                if (Size == Size.Large) return 205;
                else return 117;
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
        /// boolean representing the flavor in the drink
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
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
                if (!Ice) specialInstructions.Add("Hold ice");
                return specialInstructions;
            }
        }

        /// <summary>
        /// over rides the ToString method to return the menu item name
        /// </summary>
        /// <returns>the order in plain english in a string</returns>
        public override string ToString()
        {
            return Size.ToString() + " " + Flavor.ToString() + " Sailor Soda";
        }
    }
}

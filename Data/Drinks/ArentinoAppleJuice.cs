/*
 * Author: Lukas Hurtig
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent Aretino Apple Juice and its properties
 */

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Classification;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// provides properties describing Aretino Apple Juice
    /// </summary>
    public class ArentinoAppleJuice : Drink, IOrderItem
    {
        /// <summary>
        /// the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Medium) return 0.87;
                if (Size == Size.Large) return 1.01;
                else return 0.62;
            }
        }

        /// <summary>
        /// how many calories are in the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 88;
                if (Size == Size.Large) return 132;
                else return 44;
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
        /// lists out special instructions for the drink
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public override List<string> SpecialInstructions
        {
            get
            {
                if (Ice) specialInstructions.Add("Add ice");
                return specialInstructions;
            }
        }

        /// <summary>
        /// over rides the ToString method to return the menu item name
        /// </summary>
        /// <returns>the order in plain english in a string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Arentino Apple Juice";
        }
    }
}

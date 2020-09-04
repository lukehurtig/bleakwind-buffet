/*
 * Author: Lukas Hurtig
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent Philly Poacher and its properties
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// provides properties describing the Philly Poacher
    /// </summary>
    public class PhillyPoacher
    {
        /// <summary>
        /// the price of the breakfast philly
        /// </summary>
        public double Price
        {
            get
            {
                return 7.23;
            }
        }

        /// <summary>
        /// how many calories are in the philly
        /// </summary>
        public uint Calories
        {
            get
            {
                return 784;
            }
        }

        /// <summary>
        /// boolean representing sirloin or not
        /// </summary>
        public bool sirloin = true;
        public bool Sirloin
        {
            get
            {
                return sirloin;
                ;
            }
            set
            {
                sirloin = value;
            }
        }

        /// <summary>
        /// boolean representing onion or not
        /// </summary>
        public bool onion = true;
        public bool Onion
        {
            get
            {
                return onion;
            }
            set
            {
                onion = value;
            }
        }

        /// <summary>
        /// boolean representing roll or not
        /// </summary>
        public bool roll = true;
        public bool Roll
        {
            get
            {
                return roll;
            }
            set
            {
                roll = value;
            }
        }

        /// <summary>
        /// creates a list of what to hold on the philly
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if (!Sirloin) SpecialInstructions.Add("Hold sirloin");
                if (!Onion) SpecialInstructions.Add("Hold onions");
                if (!Roll) SpecialInstructions.Add("Hold roll");
                return SpecialInstructions;
            }
        }

        /// <summary>
        /// over rides the ToString method to return the menu item name
        /// </summary>
        /// <returns>"Philly Poacher"</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}

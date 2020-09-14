/*
 * Author: Lukas Hurtig
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent Philly Poacher and its properties
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Classification;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// provides properties describing the Philly Poacher
    /// </summary>
    public class PhillyPoacher : Entree, IOrderItem
    {
        /// <summary>
        /// the price of the breakfast philly
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.23;
            }
        }

        /// <summary>
        /// how many calories are in the philly
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 784;
            }
        }

        /// <summary>
        /// boolean representing sirloin or not
        /// </summary>
        private bool sirloin = true;
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
        private bool onion = true;
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
        private bool roll = true;
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
        private List<string> specialInstructions = new List<string>();
        public override List<string> SpecialInstructions
        {
            get
            {
                if (!Sirloin) specialInstructions.Add("Hold sirloin");
                if (!Onion) specialInstructions.Add("Hold onions");
                if (!Roll) specialInstructions.Add("Hold roll");
                return specialInstructions;
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

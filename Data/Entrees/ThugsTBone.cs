/*
 * Author: Lukas Hurtig
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Thugs T-Bone and its properties
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// provides properties describing the Thugs T-Bone
    /// </summary>
    public class ThugsTBone
    {
        /// <summary>
        /// the price of the breakfast steak
        /// </summary>
        public double Price
        {
            get
            {
                return 6.44;
            }
        }

        /// <summary>
        /// how many calories are in the steak
        /// </summary>
        public uint Calories
        {
            get
            {
                return 982;
            }
        }

        /// <summary>
        /// creates a list of what to hold on the steak
        /// </summary>
        public List<string> SpecialInstructions = new List<string>();

        /// <summary>
        /// over rides the ToString method to return the menu item name
        /// </summary>
        /// <returns>"Thugs T-Bone"</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}

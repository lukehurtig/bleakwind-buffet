/*
 * Author: Lukas Hurtig
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent Smokehouse Skeleton and its properties
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// provides properties describing the Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// the price of the breakfast platter
        /// </summary>
        public double Price
        {
            get
            {
                return 5.62;
            }
        }

        /// <summary>
        /// how many calories are in the breakfast platter
        /// </summary>
        public uint Calories
        {
            get
            {
                return 602;
            }
        }

        /// <summary>
        /// boolean representing sausage link or not
        /// </summary>
        public bool sausageLink = true;
        public bool SausageLink
        {
            get
            {
                return sausageLink;
                ;
            }
            set
            {
                sausageLink = value;
            }
        }

        /// <summary>
        /// boolean representing egg or not
        /// </summary>
        public bool egg = true;
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                egg = value;
            }
        }

        /// <summary>
        /// boolean representing hash browns or not
        /// </summary>
        public bool hashBrowns = true;
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }
            set
            {
                hashBrowns = value;
            }
        }

        /// <summary>
        /// boolean representing pancake or not
        /// </summary>
        public bool pancake = true;
        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {
                pancake = value;
            }
        }

        /// <summary>
        /// creates a list of what to hold on the breakfast platter
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if (!SausageLink) SpecialInstructions.Add("Hold sausage");
                if (!Egg) SpecialInstructions.Add("Hold eggs");
                if (!HashBrowns) SpecialInstructions.Add("Hold hash browns");
                if (!Pancake) SpecialInstructions.Add("Hold pancakes");
                return SpecialInstructions;
            }
        }

        /// <summary>
        /// over rides the ToString method to return the menu item name
        /// </summary>
        /// <returns>"Smokehouse Skeleton"</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}

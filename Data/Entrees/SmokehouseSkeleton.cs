/*
 * Author: Lukas Hurtig
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent Smokehouse Skeleton and its properties
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Classification;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// provides properties describing the Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The event handler to be invoked whenever a property is changed in this class
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// the price of the breakfast platter
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.62;
            }
        }

        /// <summary>
        /// how many calories are in the breakfast platter
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 602;
            }
        }

        /// <summary>
        /// boolean representing sausage link or not
        /// </summary>
        private bool sausageLink = true;
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// boolean representing egg or not
        /// </summary>
        private bool egg = true;
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// boolean representing hash browns or not
        /// </summary>
        private bool hashBrowns = true;
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }
            set
            {
                hashBrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// boolean representing pancake or not
        /// </summary>
        private bool pancake = true;
        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// creates a list of what to hold on the breakfast platter
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public override List<string> SpecialInstructions
        {
            get
            {
                if (!SausageLink)
                {
                    specialInstructions.Add("Hold sausage"); 
                }
                if (!Egg)
                {
                    specialInstructions.Add("Hold eggs"); 
                }
                if (!HashBrowns)
                {
                    specialInstructions.Add("Hold hash browns"); 
                }
                if (!Pancake)
                {
                    specialInstructions.Add("Hold pancakes"); 
                }
                return specialInstructions;
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

/*
 * Author: Lukas Hurtig
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent Warrior Water and its properties
 */

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Classification;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// provides properties describing Warrior Water
    /// </summary>
    public class WarriorWater : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The event handler to be invoked whenever a property is changed in this class
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The size of the water
        /// </summary>
        private Size size = Size.Small;
        public override Size Size 
        { 
            get => size;
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }

        /// <summary>
        /// the price of the water
        /// </summary>
        private double price = 0.00;
        public override double Price
        {
            get
            {
                if (Size == Size.Medium) return 0.00;
                if (Size == Size.Large) return 0.00;
                else return 0.00;
            }
        }

        /// <summary>
        /// how many calories are in the water
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 0;
                if (Size == Size.Large) return 0;
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                if (!Ice)
                {
                    specialInstructions.Add("Hold ice");
                }                     
                if (Lemon)
                {
                    specialInstructions.Add("Add lemon");
                }
                return specialInstructions;
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

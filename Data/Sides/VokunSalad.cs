﻿/*
 * Author: Lukas Hurtig
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent Vokun Salad and its properties
 */

using BleakwindBuffet.Data.Classification;
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// provides properties describing Vokun Salad
    /// </summary>
    public class VokunSalad : Side, IOrderItem, INotifyPropertyChanged
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// the price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Medium) return 1.28;
                if (Size == Size.Large) return 1.82;
                else return 0.93;
            }
        }

        /// <summary>
        /// how many calories are in the side
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 52;
                if (Size == Size.Large) return 73;
                else return 41;
            }
        }

        /// <summary>
        /// returns an empty list
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// over rides the ToString method to return the menu item name
        /// </summary>
        /// <returns>the order in plain english in a string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Vokun Salad";
        }
    }
}

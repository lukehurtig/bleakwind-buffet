﻿/*
 * Author: Lukas Hurtig
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent Briarheart Burger and its properties
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// provides properties describing the Briarheart Burger
    /// </summary>
    public class BriarheartBurger
    {
        /// <summary>
        /// the price of the burger
        /// </summary>
        public double Price
        {
            get
            {
                return 6.32;
            }
        }

        /// <summary>
        /// how many calories are in the burger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 743;
            }
        }

        /// <summary>
        /// boolean representing buns or not
        /// </summary>
        private bool bun = true;
        public bool Bun
        {
            get
            {
                return bun;
            }
            set
            {
                bun = value;
            }
        }

        /// <summary>
        /// boolean representing ketchup or not
        /// </summary>
        private bool ketchup = true;
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
            }
        }

        /// <summary>
        /// boolean representing mustard or not
        /// </summary>
        private bool mustard = true;
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                mustard = value;
            }
        }

        /// <summary>
        /// boolean representing pickles or not
        /// </summary>
        private bool pickle = true;
        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {
                pickle = value;
            }
        }

        /// <summary>
        /// boolean representing cheese or not
        /// </summary>
        private bool cheese = true;
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                cheese = value;
            }
        }

        /// <summary>
        /// creates a list of what to hold on the burger
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get
            {
                if (!Bun) specialInstructions.Add("Hold bun");
                if (!Ketchup) specialInstructions.Add("Hold ketchup");
                if (!Mustard) specialInstructions.Add("Hold mustard");
                if (!Pickle) specialInstructions.Add("Hold pickle");
                if (!Cheese) specialInstructions.Add("Hold cheese");
                return specialInstructions;
            }
        }

        /// <summary>
        /// over rides the ToString method to return the menu item name
        /// </summary>
        /// <returns>"Briarheart Burger"</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}

/*
 * Author: Lukas Hurtig
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent Thalmor Triple and its properties
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// provides properties describing the Thalmor Triple
    /// </summary>
    public class ThalmorTriple
    {
        /// <summary>
        /// the price of the burger
        /// </summary>
        public double Price
        {
            get
            {
                return 8.32;
            }
        }

        /// <summary>
        /// how many calories are in the burger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 943;
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
        /// boolean representing tomato or not
        /// </summary>
        private bool tomato = true;
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                tomato = value;
            }
        }

        /// <summary>
        /// boolean representing lettuce or not
        /// </summary>
        private bool lettuce = true;
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                lettuce = value;
            }
        }

        /// <summary>
        /// boolean representing mayo or not
        /// </summary>
        private bool mayo = true;
        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {
                mayo = value;
            }
        }

        /// <summary>
        /// boolean representing bacon or not
        /// </summary>
        private bool bacon = true;
        public bool Bacon
        {
            get
            {
                return bacon;
            }
            set
            {
                bacon = value;
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
            }
        }

        /// <summary>
        /// creates a list of what to hold on the burger
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if (!Bun) SpecialInstructions.Add("Hold bun");
                if (!Ketchup) SpecialInstructions.Add("Hold ketchup");
                if (!Mustard) SpecialInstructions.Add("Hold mustard");
                if (!Pickle) SpecialInstructions.Add("Hold pickle");
                if (!Cheese) SpecialInstructions.Add("Hold cheese");
                if (!Tomato) SpecialInstructions.Add("Hold tomato");
                if (!Lettuce) SpecialInstructions.Add("Hold lettuce");
                if (!Mayo) SpecialInstructions.Add("Hold mayo");
                if (!Bacon) SpecialInstructions.Add("Hold bacon");
                if (!Egg) SpecialInstructions.Add("Hold egg");
                return SpecialInstructions;
            }
        }

        /// <summary>
        /// over rides the ToString method to return the menu item name
        /// </summary>
        /// <returns>"Thalmor Triple"</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}

/*
 * Author: Lukas Hurtig
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent Garden Orc Omelette and its properties
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Classification;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// provides properties describing the Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The event handler to be invoked whenever a property is changed in this class
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// the price of the breakfast omelette
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.57;
            }
        }

        /// <summary>
        /// how many calories are in the omelette
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 404;
            }
        }

        /// <summary>
        /// boolean representing broccoli or not
        /// </summary>
        private bool broccoli = true;
        public bool Broccoli
        {
            get
            {
                return broccoli;
                ;
            }
            set
            {
                broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// boolean representing mushrooms or not
        /// </summary>
        private bool mushrooms = true;
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }
            set
            {
                mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// boolean representing cheddar or not
        /// </summary>
        private bool cheddar = true;
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }
            set
            {
                cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// creates a list of what to hold on the omelette
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public override List<string> SpecialInstructions
        {
            get
            {
                if (!Broccoli)
                {
                    specialInstructions.Add("Hold broccoli"); 
                }
                if (!Mushrooms)
                {
                    specialInstructions.Add("Hold mushrooms"); 
                }
                if (!Tomato)
                {
                    specialInstructions.Add("Hold tomato"); 
                }
                if (!Cheddar) 
                {
                    specialInstructions.Add("Hold cheddar"); 
                }
                return specialInstructions;
            }
        }

        /// <summary>
        /// over rides the ToString method to return the menu item name
        /// </summary>
        /// <returns>"Garden Orc Omelette"</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}

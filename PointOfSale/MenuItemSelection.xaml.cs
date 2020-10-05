/*
 * Author: Lukas Hurtig
 * Class name: MenuItemSelection.xaml.cs
 * Purpose: A partial class to MenuItemSelection.xaml that initializes
 * the UserControl and executes c# code for the application
 */

using BleakwindBuffet.Data.Sides;
using PointOfSale.DrinkInterface;
using PointOfSale.EntreeInterface;
using PointOfSale.SideInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelection.xaml
    /// </summary>
    public partial class MenuItemSelection : UserControl
    {
        /// <summary>
        /// Attempts to create an instance of the OrderControl class to switch
        /// the top level border to the desired UserControl class
        /// </summary>
        private DependencyObject parent;
        public DependencyObject Order
        {
            get
            {
                parent = this;
                do
                {
                    parent = LogicalTreeHelper.GetParent(parent);
                } while (!(parent is null || parent is OrderControl));
                return parent;
            }
        }

        /// <summary>
        /// Initializes the UserControl class
        /// </summary>
        public MenuItemSelection()
        {
            InitializeComponent();            
        }

        /// <summary>
        /// An event handler for clicking the BriarheartBurger Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void BriarheartBurger_Click(object sender, RoutedEventArgs e)
        {
            if(Order is OrderControl order)
            {
                order.SwitchScreen(Screens.Briarheart);
            }
        }

        /// <summary>
        /// An event handler for clicking the DoubleDraugr Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void DoubleDraugr_Click(object sender, RoutedEventArgs e)
        {
            if (Order is OrderControl order)
            {
                order.SwitchScreen(Screens.Double);
            }
        }

        /// <summary>
        /// An event handler for clicking the TripleThalmor Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void ThalmorTriple_Click(object sender, RoutedEventArgs e)
        {
            if (Order is OrderControl order)
            {
                order.SwitchScreen(Screens.Triple);
            }
        }

        /// <summary>
        /// An event handler for clicking the PhillyPoacher Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void PhillyPoacher_Click(object sender, RoutedEventArgs e)
        {
            if (Order is OrderControl order)
            {
                order.SwitchScreen(Screens.Philly);
            }
        }

        /// <summary>
        /// An event handler for clicking the SmokehouseSkeleton Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void SmokehouseSkeleton_Click(object sender, RoutedEventArgs e)
        {
            if (Order is OrderControl order)
            {
                order.SwitchScreen(Screens.Smokehouse);
            }
        }

        /// <summary>
        /// An event handler for clicking the GardenOrcOmelette Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void GardenOrcOmelette_Click(object sender, RoutedEventArgs e)
        {
            if (Order is OrderControl order)
            {
                order.SwitchScreen(Screens.Omelette);
            }
        }

        /// <summary>
        /// An event handler for clicking the ThugsTBone Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void ThugsTBone_Click(object sender, RoutedEventArgs e)
        {
            if (Order is OrderControl order)
            {
                order.SwitchScreen(Screens.TBone);
            }
        }

        /// <summary>
        /// An event handler for clicking the SailorSoda Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void SailorSoda_Click(object sender, RoutedEventArgs e)
        {
            if (Order is OrderControl order)
            {
                order.SwitchScreen(Screens.Soda);
            }
        }

        /// <summary>
        /// An event handler for clicking the MarkarthMilk Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void MarkarthMilk_Click(object sender, RoutedEventArgs e)
        {
            if (Order is OrderControl order)
            {
                order.SwitchScreen(Screens.Milk);
            }
        }

        /// <summary>
        /// An event handler for clicking the ArentinoAppleJuice Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void ArentinoAppleJuice_Click(object sender, RoutedEventArgs e)
        {
            if (Order is OrderControl order)
            {
                order.SwitchScreen(Screens.AppleJuice);
            }
        }

        /// <summary>
        /// An event handler for clicking the CandlehearthCoffee Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void CandlehearthCoffee_Click(object sender, RoutedEventArgs e)
        {
            if (Order is OrderControl order)
            {
                order.SwitchScreen(Screens.Coffee);
            }
        }

        /// <summary>
        /// An event handler for clicking the WarriorWater Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void WarriorWater_Click(object sender, RoutedEventArgs e)
        {
            if (Order is OrderControl order)
            {
                order.SwitchScreen(Screens.Water);
            }
        }

        /// <summary>
        /// An event handler for clicking the VokunSalad Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void VokunSalad_Click(object sender, RoutedEventArgs e)
        {
            if (Order is OrderControl order)
            {
                order.SwitchScreen(Screens.Salad);
            }
        }

        /// <summary>
        /// An event handler for clicking the FriedMiraak Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void FriedMiraak_Click(object sender, RoutedEventArgs e)
        {
            if (Order is OrderControl order)
            {
                order.SwitchScreen(Screens.Miraak);
            }
        }

        /// <summary>
        /// An event handler for clicking the MadOtarGrits Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void MadOtarGrits_Click(object sender, RoutedEventArgs e)
        {
            if (Order is OrderControl order)
            {
                order.SwitchScreen(Screens.Grits);
            }
        }

        /// <summary>
        /// An event handler for clicking the DragonbornWaffleFries Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void DragonbornWaffleFries_Click(object sender, RoutedEventArgs e)
        {
            if (Order is OrderControl order)
            {
                order.SwitchScreen(Screens.WaffleFries);
            }
        }
    }
}

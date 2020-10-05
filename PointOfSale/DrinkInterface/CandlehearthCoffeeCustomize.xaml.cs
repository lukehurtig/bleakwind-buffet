/*
 * Author: Lukas Hurtig
 * Class name: CandlehearthCoffeeCustomize.xaml.cs
 * Purpose: A partial class to MarkarthMilkCustomize.xaml that initializes
 * the UserControl and executes c# code for the application
 */

using BleakwindBuffet.Data.Drinks;
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

namespace PointOfSale.DrinkInterface
{
    /// <summary>
    /// Interaction logic for CandlehearthCoffeeCustomize.xaml
    /// </summary>
    public partial class CandlehearthCoffeeCustomize : UserControl
    {
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
        /// The object represented by this class
        /// </summary>
        private CandlehearthCoffee cc;

        /// <summary>
        /// Initializes the UserControl class
        /// </summary>
        public CandlehearthCoffeeCustomize()
        {
            InitializeComponent();

            cc = new CandlehearthCoffee();
            Sizes.DataContext = cc.Size;
            AddIce.IsChecked = cc.Ice;
            RoomforCream.IsChecked = cc.RoomForCream;
            Decaf.IsChecked = cc.Decaf;
        }

        /// <summary>
        /// An event handler for clicking the Add Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (Order is OrderControl order)
            {
                order.SwitchScreen(Screens.Top);
            }
        }

        /// <summary>
        /// An event handler for clicking the Back Button
        /// </summary>
        /// <param name="sender">the Button object that was clicked</param>
        /// <param name="e">Existing EventArgs that aren't used</param>
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (Order is OrderControl order)
            {
                order.SwitchScreen(Screens.Top);
            }
        }
    }
}

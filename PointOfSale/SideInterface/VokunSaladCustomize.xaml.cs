/*
 * Author: Lukas Hurtig
 * Class name: VokunSaladCustomize.xaml.cs
 * Purpose: A partial class to VokunSaladCustomize.xaml that initializes
 * the UserControl and executes c# code for the application
 */

using BleakwindBuffet.Data.Sides;
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

namespace PointOfSale.SideInterface
{
    /// <summary>
    /// Interaction logic for VokunSaladCustomize.xaml
    /// </summary>
    public partial class VokunSaladCustomize : UserControl
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
        /// The object represented by this class
        /// </summary>
        private VokunSalad vs;

        /// <summary>
        /// Initializes the UserControl class
        /// </summary>
        public VokunSaladCustomize()
        {
            InitializeComponent();

            vs = new VokunSalad();
            Sizes.DataContext = vs.Size;
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

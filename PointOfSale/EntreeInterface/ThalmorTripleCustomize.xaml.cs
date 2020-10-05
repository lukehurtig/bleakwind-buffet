/*
 * Author: Lukas Hurtig
 * Class name: ThalmorTripleCustomize.xaml.cs
 * Purpose: A partial class to ThalmorTripleCustomize.xaml that initializes
 * the UserControl and executes c# code for the application
 */

using BleakwindBuffet.Data.Entrees;
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

namespace PointOfSale.EntreeInterface
{
    /// <summary>
    /// Interaction logic for ThalmorTripleCustomize.xaml
    /// </summary>
    public partial class ThalmorTripleCustomize : UserControl
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
        private ThalmorTriple tt;

        /// <summary>
        /// Initializes the UserControl class
        /// </summary>
        public ThalmorTripleCustomize()
        {
            InitializeComponent();

            tt = new ThalmorTriple();
            Bun.IsChecked = tt.Bun;
            Ketchup.IsChecked = tt.Ketchup;
            Mustard.IsChecked = tt.Mustard;
            Pickle.IsChecked = tt.Pickle;
            Cheese.IsChecked = tt.Cheese;
            Tomato.IsChecked = tt.Tomato;
            Mayo.IsChecked = tt.Mayo;
            Lettuce.IsChecked = tt.Lettuce;
            Egg.IsChecked = tt.Egg;
            Bacon.IsChecked = tt.Bacon;

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

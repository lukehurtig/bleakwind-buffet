﻿/*
 * Author: Lukas Hurtig
 * Class name: SmokehouseSkeletonCustomize.xaml.cs
 * Purpose: A partial class to SmokehouseSkeletonCustomize.xaml that initializes
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
    /// Interaction logic for SmokehouseSkeletonCustomize.xaml
    /// </summary>
    public partial class SmokehouseSkeletonCustomize : UserControl
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
        private SmokehouseSkeleton ss;

        /// <summary>
        /// Initializes the UserControl class
        /// </summary>
        public SmokehouseSkeletonCustomize()
        {
            InitializeComponent();

            ss = new SmokehouseSkeleton();
            Sausage.IsChecked = ss.SausageLink;
            Eggs.IsChecked = ss.Egg;
            Hash.IsChecked = ss.HashBrowns;
            Pancakes.IsChecked = ss.Pancake;
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

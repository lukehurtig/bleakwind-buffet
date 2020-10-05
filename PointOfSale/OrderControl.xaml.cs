/*
 * Author: Lukas Hurtig
 * Class name: OrderControl.xaml.cs
 * Purpose: A partial class to OrderControl.xaml that initializes
 * the UserControl and executes c# code for the application
 */

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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        Dictionary<Screens, UserControl> screen = new Dictionary<Screens, UserControl>();

        public OrderControl()
        {
            InitializeComponent();

            screen.Add(Screens.Top, new MenuItemSelection());
            screen.Add(Screens.Briarheart, new BriarheartBurgerCustomize());
            screen.Add(Screens.Double, new DoubleDraugrCustomize());
            screen.Add(Screens.Triple, new ThalmorTripleCustomize());
            screen.Add(Screens.Smokehouse, new SmokehouseSkeletonCustomize());
            screen.Add(Screens.Omelette, new GardenOrcOmletteCustomize());
            screen.Add(Screens.Philly, new PhillyPoacherCustomize());
            screen.Add(Screens.TBone, new ThugsTBoneCustomize());
            screen.Add(Screens.Soda, new SailorSodaCustomize());
            screen.Add(Screens.Milk, new MarkarthMilkCustomize());
            screen.Add(Screens.AppleJuice, new ArentinoAppleJuiceCustomize());
            screen.Add(Screens.Coffee, new CandlehearthCoffeeCustomize());
            screen.Add(Screens.Water, new WarriorWaterCustomize());
            screen.Add(Screens.Salad, new VokunSaladCustomize());
            screen.Add(Screens.Miraak, new FriedMiraakCustomize());
            screen.Add(Screens.Grits, new MadOtarGritsCustomize());
            screen.Add(Screens.WaffleFries, new DragonbornWaffleFriesCustomize());
        }

        public void SwitchScreen(Screens newScreen)
        {
            MenuSelectionBorder.Child = screen[newScreen];
        }
    }
}

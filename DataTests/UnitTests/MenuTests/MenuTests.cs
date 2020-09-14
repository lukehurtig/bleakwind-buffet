/*
 * Author: Lukas Hurtig
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */

using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.Collections.Generic;
using BleakwindBuffet.Data.Classification;
using System;

namespace BleakwindBuffet.DataTests.UnitTests.MenuTests
{
    public class MenuTests
    {
        [Fact]
        public void MenuReturnsAllEntrees()
        {
            Assert.Contains(Menu.Entrees(), (item) => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(Menu.Entrees(), (item) => { return item.ToString().Equals("Double Draugr"); });
            Assert.Contains(Menu.Entrees(), (item) => { return item.ToString().Equals("Garden Orc Omelette"); });
            Assert.Contains(Menu.Entrees(), (item) => { return item.ToString().Equals("Philly Poacher"); });
            Assert.Contains(Menu.Entrees(), (item) => { return item.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(Menu.Entrees(), (item) => { return item.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(Menu.Entrees(), (item) => { return item.ToString().Equals("Thugs T-Bone"); });
        }

        [Fact]
        public void MenuReturnsAllSides()
        {
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });

            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Fried Miraak"); });

            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Mad Otar Grits"); });

            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Vokun Salad"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Vokun Salad"); });
        }

        [Fact]
        public void MenuReturnsAllDrinks()
        {
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Arentino Apple Juice"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Arentino Apple Juice"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Arentino Apple Juice"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Markarth Milk"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Cherry Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Warrior Water"); });
        }

        [Fact]
        public void MenuReturnsAllItems()
        {
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Double Draugr"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Garden Orc Omelette"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Philly Poacher"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Thugs T-Bone"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Fried Miraak"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Mad Otar Grits"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Vokun Salad"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Vokun Salad"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Arentino Apple Juice"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Arentino Apple Juice"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Arentino Apple Juice"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Markarth Milk"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Cherry Sailor Soda"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Warrior Water"); });
        }
    }
}

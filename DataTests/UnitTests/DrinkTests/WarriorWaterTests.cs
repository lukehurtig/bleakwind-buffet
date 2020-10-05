/*
 * Author: Zachery Brunner
 * Modified By: Lukas Hurtig
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Classification;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(ww);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ww);
        }

        [Fact]
        public void IceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void SmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void NoLemonByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void BeAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = true;
            Assert.True(ww.Ice);
            ww.Ice = false;
            Assert.False(ww.Ice);
        }

        [Fact]
        public void BeAbleToSetSize()
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void BeAbleToSetLemon()
        {
            WarriorWater ww = new WarriorWater();
            ww.Lemon = true;
            Assert.True(ww.Lemon);
            ww.Lemon = false;
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldNotifySizeChange()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Size", () => { ww.Size = Size.Large; });
            Assert.PropertyChanged(ww, "Size", () => { ww.Size = Size.Medium; });
            Assert.PropertyChanged(ww, "Size", () => { ww.Size = Size.Small; });
        }

        [Fact]
        public void ShouldNotifyIceChange()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Ice", () => { ww.Ice = false; });
            Assert.PropertyChanged(ww, "Ice", () => { ww.Ice = true; });
        }

        [Fact]
        public void ShouldNotifyLemonChange()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Lemon", () => { ww.Lemon = true; });
            Assert.PropertyChanged(ww, "Lemon", () => { ww.Lemon = false; });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChange()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "SpecialInstructions", () => { ww.Ice = false; });
            Assert.PropertyChanged(ww, "SpecialInstructions", () => { ww.Lemon = true; });
        }

        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void HaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(price, ww.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void CorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(cal, ww.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void CorrectSpecialInstructions(bool ice, bool lemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = ice;
            ww.Lemon = lemon;
            if (!ice)
            {
                Assert.Contains("Hold ice", ww.SpecialInstructions);
                if (lemon) Assert.Contains("Add lemon", ww.SpecialInstructions);
            }
            else if (lemon) Assert.Contains("Add lemon", ww.SpecialInstructions);
            else Assert.Empty(ww.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }
    }
}

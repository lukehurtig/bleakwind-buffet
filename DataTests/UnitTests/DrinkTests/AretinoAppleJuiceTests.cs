/*
 * Author: Zachery Brunner
 * Modified By: Lukas Hurtig
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Classification;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aj);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(aj);
        }

        [Fact]
        public void NoIceByDefault()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.False(aj.Ice);
        }

        [Fact]
        public void SmallByDefault()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.Equal(Size.Small, aj.Size);
        }

        [Fact]
        public void BeAbleToSetIce()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Ice = true;
            Assert.True(aj.Ice);
            aj.Ice = false;
            Assert.False(aj.Ice);
        }

        [Fact]
        public void BeAbleToSetSize()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Size = Size.Large;
            Assert.Equal(Size.Large, aj.Size);
            aj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aj.Size);
            aj.Size = Size.Small;
            Assert.Equal(Size.Small, aj.Size);
        }

        [Fact]
        public void ShouldNotifySizeChange()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.PropertyChanged(aj, "Size", () => { aj.Size = Size.Large; });
            Assert.PropertyChanged(aj, "Size", () => { aj.Size = Size.Medium; });
            Assert.PropertyChanged(aj, "Size", () => { aj.Size = Size.Small; });
        }

        [Fact]
        public void ShouldNotifyPriceChange()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.PropertyChanged(aj, "Price", () => { aj.Size = Size.Large; });
            Assert.PropertyChanged(aj, "Price", () => { aj.Size = Size.Medium; });
            Assert.PropertyChanged(aj, "Price", () => { aj.Size = Size.Small; });
        }

        [Fact]
        public void ShouldNotifyCaloriesChange()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.PropertyChanged(aj, "Calories", () => { aj.Size = Size.Large; });
            Assert.PropertyChanged(aj, "Calories", () => { aj.Size = Size.Medium; });
            Assert.PropertyChanged(aj, "Calories", () => { aj.Size = Size.Small; });
        }

        [Fact]
        public void ShouldNotifyIceChange()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.PropertyChanged(aj, "Ice", () => { aj.Ice = true; });
            Assert.PropertyChanged(aj, "Ice", () => { aj.Ice = false; });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChange()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.PropertyChanged(aj, "SpecialInstructions", () => { aj.Ice = true; });
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void HaveCorrectPriceForSize(Size size, double price)
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Size = size;
            Assert.Equal(price, aj.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void CorrectCaloriesForSize(Size size, uint cal)
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Size = size;
            Assert.Equal(cal, aj.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void CorrectSpecialInstructions(bool ice)
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Ice = ice;
            if (ice) Assert.Contains("Add ice", aj.SpecialInstructions);
            else Assert.Empty(aj.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Arentino Apple Juice")]
        [InlineData(Size.Medium, "Medium Arentino Apple Juice")]
        [InlineData(Size.Large, "Large Arentino Apple Juice")]
        public void ReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Size = size;
            Assert.Equal(name, aj.ToString());
        }
    }
}
/*
 * Author: Zachery Brunner
 * Modified By: Lukas Hurtig
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
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
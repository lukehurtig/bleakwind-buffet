﻿/*
 * Author: Zachery Brunner
 * Modified By: Lukas Hurtig
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Classification;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(mm);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(mm);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mm);
        }

        [Fact]
        public void NoIceByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.False(mm.Ice);
        }

        [Fact]
        public void SmallByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.Equal(Size.Small, mm.Size);
        }

        [Fact]
        public void BeAbleToSetIce()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = true;
            Assert.True(mm.Ice);
            mm.Ice = false;
            Assert.False(mm.Ice);
        }

        [Fact]
        public void BeAbleToSetSize()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = Size.Large;
            Assert.Equal(Size.Large, mm.Size);
            mm.Size = Size.Medium;
            Assert.Equal(Size.Medium, mm.Size);
            mm.Size = Size.Small;
            Assert.Equal(Size.Small, mm.Size);
        }

        [Fact]
        public void ShouldNotifySizeChange()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Size", () => { mm.Size = Size.Large; });
            Assert.PropertyChanged(mm, "Size", () => { mm.Size = Size.Medium; });
            Assert.PropertyChanged(mm, "Size", () => { mm.Size = Size.Small; });
        }

        [Fact]
        public void ShouldNotifyPriceChange()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Price", () => { mm.Size = Size.Large; });
            Assert.PropertyChanged(mm, "Price", () => { mm.Size = Size.Medium; });
            Assert.PropertyChanged(mm, "Price", () => { mm.Size = Size.Small; });
        }

        [Fact]
        public void ShouldNotifyCaloriesChange()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Calories", () => { mm.Size = Size.Large; });
            Assert.PropertyChanged(mm, "Calories", () => { mm.Size = Size.Medium; });
            Assert.PropertyChanged(mm, "Calories", () => { mm.Size = Size.Small; });
        }

        [Fact]
        public void ShouldNotifyIceChange()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Ice", () => { mm.Ice = true; });
            Assert.PropertyChanged(mm, "Ice", () => { mm.Ice = false; });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChange()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "SpecialInstructions", () => { mm.Ice = true; });
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void HaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(price, mm.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void CorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(cal, mm.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void CorrectSpecialInstructions(bool ice)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = ice;
            if (ice) Assert.Contains("Add ice", mm.SpecialInstructions);
            else Assert.Empty(mm.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(name, mm.ToString());
        }
    }
}
/*
 * Author: Zachery Brunner
 * Modified By: Lukas Hurtig
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Classification;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(ss);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ss);
        }

        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Egg = true;
            Assert.True(ss.Egg);
            ss.Egg = false;
            Assert.False(ss.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.HashBrowns = true;
            Assert.True(ss.HashBrowns);
            ss.HashBrowns = false;
            Assert.False(ss.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Pancake = true;
            Assert.True(ss.Pancake);
            ss.Pancake = false;
            Assert.False(ss.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(5.62, ss.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal((uint)602, ss.Calories);
        }

        [Fact]
        public void ShouldNotifySausageChange()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, "SausageLink", () => { ss.SausageLink = false; });
            Assert.PropertyChanged(ss, "SausageLink", () => { ss.SausageLink = true; });
        }

        [Fact]
        public void ShouldNotifyEggChange()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, "Egg", () => { ss.Egg = false; });
            Assert.PropertyChanged(ss, "Egg", () => { ss.Egg = true; });
        }

        [Fact]
        public void ShouldNotifyHashBrownsChange()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, "HashBrowns", () => { ss.HashBrowns = false; });
            Assert.PropertyChanged(ss, "HashBrowns", () => { ss.HashBrowns = true; });
        }

        [Fact]
        public void ShouldNotifyPancakeChange()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, "Pancake", () => { ss.Pancake = false; });
            Assert.PropertyChanged(ss, "Pancake", () => { ss.Pancake = true; });
        }

        [Fact]
        public void ShouldNotifySpecialIncstructionsChange()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, "SpecialInstructions", () => { ss.SausageLink = false; });
            Assert.PropertyChanged(ss, "SpecialInstructions", () => { ss.Egg = false; });
            Assert.PropertyChanged(ss, "SpecialInstructions", () => { ss.HashBrowns = false; });
            Assert.PropertyChanged(ss, "SpecialInstructions", () => { ss.Pancake = false; });
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = includeSausage;
            ss.Egg = includeEgg;
            ss.HashBrowns = includeHashbrowns;
            ss.Pancake = includePancake;
            if (!includeSausage) Assert.Contains("Hold sausage", ss.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold eggs", ss.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", ss.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancakes", ss.SpecialInstructions);
            else Assert.Empty(ss.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", ss.ToString());
        }
    }
}
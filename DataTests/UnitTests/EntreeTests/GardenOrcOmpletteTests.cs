/*
 * Author: Zachery Brunner
 * Modified By: Lukas Hurtig
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Classification;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(go);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(go);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(go);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Broccoli = true;
            Assert.True(go.Broccoli);
            go.Broccoli = false;
            Assert.False(go.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Mushrooms = true;
            Assert.True(go.Mushrooms);
            go.Mushrooms = false;
            Assert.False(go.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Tomato = true;
            Assert.True(go.Tomato);
            go.Tomato = false;
            Assert.False(go.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Cheddar = true;
            Assert.True(go.Cheddar);
            go.Cheddar = false;
            Assert.False(go.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal(4.57, go.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal((uint)404, go.Calories);
        }

        [Fact]
        public void ShouldNotifyBroccoliChange()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "Broccoli", () => { go.Broccoli = false; });
            Assert.PropertyChanged(go, "Broccoli", () => { go.Broccoli = true; });
        }

        [Fact]
        public void ShouldNotifyTomatoChange()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "Tomato", () => { go.Tomato = false; });
            Assert.PropertyChanged(go, "Tomato", () => { go.Tomato = true; });
        }

        [Fact]
        public void ShouldNotifyMushroomsChange()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "Mushrooms", () => { go.Mushrooms = false; });
            Assert.PropertyChanged(go, "Mushrooms", () => { go.Mushrooms = true; });
        }

        [Fact]
        public void ShouldNotifyCheddarChange()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "Cheddar", () => { go.Cheddar = false; });
            Assert.PropertyChanged(go, "Cheddar", () => { go.Cheddar = true; });
        }

        [Fact]
        public void ShouldNotifySpecialIncstructionsChange()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "SpecialInstructions", () => { go.Broccoli = false; });
            Assert.PropertyChanged(go, "SpecialInstructions", () => { go.Tomato = false; });
            Assert.PropertyChanged(go, "SpecialInstructions", () => { go.Mushrooms = false; });
            Assert.PropertyChanged(go, "SpecialInstructions", () => { go.Cheddar = false; });
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Broccoli = includeBroccoli;
            go.Mushrooms = includeMushrooms;
            go.Tomato = includeTomato;
            go.Cheddar = includeCheddar;
            if (!includeBroccoli) Assert.Contains("Hold broccoli", go.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", go.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", go.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", go.SpecialInstructions);
            else Assert.Empty(go.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", go.ToString());
        }
    }
}
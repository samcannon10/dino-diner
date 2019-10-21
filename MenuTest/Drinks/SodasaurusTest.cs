/*Sodasaurus.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.5, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains<string>("Water", soda.Ingredients);
            Assert.Contains<string>("Natural Flavors", soda.Ingredients);
            Assert.Contains<string>("Cane Sugar", soda.Ingredients);
            Assert.Equal<int>(3, soda.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.5, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.5, soda.Price);
        }

        [Fact]
        public void ShouldSetToCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
        }

        [Fact]
        public void ShouldSetToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
        }

        [Fact]
        public void ShouldSetToVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);
        }

        [Fact]
        public void ShouldSetToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
        }

        [Fact]
        public void ShouldSetToRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
        }

        [Fact]
        public void ShouldSetToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
        }

        [Fact]
        public void ShouldSetToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
        }

        [Fact] public void ShouldHoldIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Empty(soda.Special);
        }

        [Fact]
        public void HoldIceShouldAppearInSpecial()
        {
            Sodasaurus s = new Sodasaurus();
            s.HoldIce();

            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Theory]
        [InlineData("Size")]
        [InlineData("Calories")]
        [InlineData("Price")]
        [InlineData("Description")]
        public void SizeShouldNotifyOfPropertyChange(string propertyName)
        {
            Sodasaurus s = new Sodasaurus();

            Assert.PropertyChanged(s, propertyName, () =>
            {
                s.Size = Size.Large;
            });
        }

        [Theory]
        [InlineData("Ice")]
        [InlineData("Special")]
        public void HoldIceShouldNotifyOfPropertyChange(string propertyName)
        {
            Sodasaurus s = new Sodasaurus();

            Assert.PropertyChanged(s, propertyName, () =>
            {
                s.HoldIce();
            });
        }

        [Theory]
        [InlineData("Flavor")]
        [InlineData("Description")]
        public void FlavorShouldNotifyOfPropertyChange(string propertyName)
        {
            Sodasaurus s = new Sodasaurus();

            Assert.PropertyChanged(s, propertyName, () =>
            {
                s.Flavor = SodasaurusFlavor.Cherry;
            });
        }

        [Fact]
        public void PriceShouldNotifyOfPropertyChange()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.PropertyChanged(s, "Price", () =>
            {
                s.Price = 0.1;
            });
        }

        [Fact]
        public void CaloriesShouldNotifyOfPropertyChange()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.PropertyChanged(s, "Calories", () =>
            {
                s.Calories = 0;
            });
        }
    }
}

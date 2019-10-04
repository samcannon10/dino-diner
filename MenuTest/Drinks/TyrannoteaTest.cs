/*TyrannoteaTest.cs
 * Author: Sam Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace DinoDiner.MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Equal<uint>(8, t.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Equal<double>(0.99, t.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, t.Size);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddLemon();
            t.Sweet = true;
            Assert.Contains("Water", t.Ingredients);
            Assert.Contains("Tea", t.Ingredients);
            if (t.Sweet) Assert.Contains("Cane Sugar", t.Ingredients);
            if (t.Lemon) Assert.Contains("Lemon", t.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.True(t.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.False(t.Lemon);
        }

        [Fact]
        public void ShouldNotBeSweet()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.False(t.Sweet);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            t.Size = Size.Small;
            Assert.Equal<uint>(8, t.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            t.Size = Size.Small;
            Assert.Equal<double>(0.99, t.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            Assert.Equal<uint>(16, t.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            Assert.Equal<double>(1.49, t.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            Assert.Equal<uint>(32, t.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            Assert.Equal<double>(1.99, t.Price);
        }

        [Fact]
        public void ShouldHoldIce()
        {
            Tyrannotea t = new Tyrannotea();
            t.HoldIce();
            Assert.False(t.Ice);
        }

        [Fact]
        public void ShouldAddLemon()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddLemon();
            Assert.True(t.Lemon);
            Assert.Contains("Lemon", t.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSweet()
        {
            Tyrannotea t = new Tyrannotea();
            t.Sweet = true;
            Assert.Contains("Cane Sugar", t.Ingredients);
            Assert.Equal<uint>(16, t.Calories);
            t.Size = Size.Medium;
            Assert.Equal<uint>(32, t.Calories);
            t.Size = Size.Large;
            Assert.Equal<uint>(64, t.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForUnsweet()
        {
            Tyrannotea t = new Tyrannotea();
            t.Sweet = true;
            t.Sweet = false;
            Assert.Equal<uint>(8, t.Calories);
            t.Size = Size.Medium;
            Assert.Equal<uint>(16, t.Calories);
            t.Size = Size.Large;
            Assert.Equal<uint>(32, t.Calories);
        }
    }
}

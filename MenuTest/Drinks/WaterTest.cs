/*WaterTest.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

namespace DinoDiner.MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Water w = new Water();
            Assert.Contains("Water", w.Ingredients);
            Assert.Single(w.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water w = new Water();
            Assert.Equal<double>(0.1, w.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water w = new Water();
            Assert.Equal<Size>(Size.Small, w.Size);
        }

        [Fact]
        public void ShouldHoldIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }

        [Fact]
        public void ShouldAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.Contains("Lemon", w.Ingredients);
            Assert.True(w.Lemon);
        }

        [Fact]
        public void ShouldSetSizeToMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, w.Size);
            Assert.Equal<uint>(0, w.Calories);
            Assert.Equal<double>(0.1, w.Price);
        }

        [Fact]
        public void ShouldSetSizeToLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, w.Size);
            Assert.Equal<uint>(0, w.Calories);
            Assert.Equal<double>(0.1, w.Price);
        }

        [Fact]
        public void ShouldSetSizeToSmall()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            w.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, w.Size);
            Assert.Equal<uint>(0, w.Calories);
            Assert.Equal<double>(0.1, w.Price);
        }
    }
}

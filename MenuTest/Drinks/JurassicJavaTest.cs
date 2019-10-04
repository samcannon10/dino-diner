/*JurassicJavaTest.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace DinoDiner.MenuTest.Drinks
{
    public class JurassicJavaTest
    {

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava j = new JurassicJava();
            Assert.Contains("Water", j.Ingredients);
            Assert.Contains("Coffee", j.Ingredients);
            Assert.Equal<int>(2, j.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava j = new JurassicJava();
            Assert.Equal<uint>(2, j.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava j = new JurassicJava();
            Assert.Equal<double>(0.59, j.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurassicJava j = new JurassicJava();
            Assert.False(j.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava j = new JurassicJava();
            Assert.Equal<Size>(Size.Small, j.Size);
        }

        [Fact]
        public void ShouldHaveCorrectRoomForCream()
        {
            JurassicJava j = new JurassicJava();
            Assert.False(j.RoomForCream);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            j.Size = Size.Small;
            Assert.Equal<uint>(2, j.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            j.Size = Size.Small;
            Assert.Equal<double>(0.59, j.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            Assert.Equal<uint>(4, j.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            Assert.Equal<double>(0.99, j.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            Assert.Equal<uint>(8, j.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            Assert.Equal<double>(1.49, j.Price);
        }

        [Fact]
        public void ShouldAddIce()
        {
            JurassicJava j = new JurassicJava();
            j.AddIce();
            Assert.True(j.Ice);
        }

        [Fact]
        public void ShouldLeaveRoomForCream()
        {
            JurassicJava j = new JurassicJava();
            j.LeaveRoomForCream();
            Assert.True(j.RoomForCream);
        }
    }
}

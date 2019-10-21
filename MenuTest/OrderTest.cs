/*OrderTest.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void ShouldHaveCorrectItemsAndCosts()
        {
            Order o = new Order();
            Brontowurst b = new Brontowurst();
            MezzorellaSticks ms = new MezzorellaSticks();
            b.Price = 3;
            ms.Price = 2;
            o.Items.Add(b);
            o.Items.Add(ms);

            Assert.Contains<IOrderItem>(b, o.Items);
            Assert.Contains<IOrderItem>(ms, o.Items);
            Assert.Equal(5, o.SubtotalCost);
            Assert.Equal(0.0825, o.SalesTaxRate);
            Assert.Equal((5 * 0.0825), o.SalesTaxCost);
            Assert.Equal((5 + 5 * 0.0825), o.TotalCost);
        }

        [Fact]
        public void SubtotalShouldBePositive()
        {
            Order o = new Order();
            JurassicJava j = new JurassicJava();
            o.Items.Add(j);
            j.Price = -2;
            Assert.Equal(0, o.SubtotalCost);
        }
    }
}

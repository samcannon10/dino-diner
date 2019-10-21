/*CretaceousComboText.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class CretaceousComboTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            CretaceousCombo cc = new CretaceousCombo(new Brontowurst());
            Assert.Equal<Size>(Size.Small, cc.Size);
        }

        [Fact]
        public void ShouldChangeToLarge()
        {
            CretaceousCombo cc = new CretaceousCombo(new Brontowurst());
            cc.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, cc.Size);
        }

        [Fact]
        public void ShouldChangeToMedium()
        {
            CretaceousCombo cc = new CretaceousCombo(new Brontowurst());
            cc.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, cc.Size);
        }

        [Fact]
        public void ShouldChangeToSmall()
        {
            CretaceousCombo cc = new CretaceousCombo(new Brontowurst());
            cc.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, cc.Size);
        }
    }
}

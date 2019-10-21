using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class PrehistoricPBJUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal(6.52, pbj.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal<uint>(483, pbj.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            List<string> ingredients = pbj.Ingredients;
            Assert.Contains<string>("Bread", ingredients);
            Assert.Contains<string>("Peanut Butter", ingredients);
            Assert.Contains<string>("Jelly", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        [Fact]
        public void HoldPeanutButterShouldRemovePeanutButter()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            Assert.DoesNotContain<string>("Peanut Butter", pbj.Ingredients);
        }

        [Fact]
        public void HoldJellyShouldRemoveJelly()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.DoesNotContain<string>("Jelly", pbj.Ingredients);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Empty(pbj.Special);
        }

        [Fact]
        public void HoldPeanutButterShouldAppearInSpecial()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();


            Assert.Collection<string>(pbj.Special, item =>
            {
                Assert.Equal("Hold Peanut Butter", item);
            });
        }

        [Fact]
        public void HoldJellyShouldAppearInSpecial()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();


            Assert.Collection<string>(pbj.Special, item =>
            {
                Assert.Equal("Hold Jelly", item);
            });
        }

        [Fact]
        public void HoldPeanutButterShouldNotifyOfPropertyChange()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();

            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.HoldPeanutButter();
            });
        }

        [Fact]
        public void HoldJellyShouldNotifyOfPropertyChange()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.HoldJelly();
            });
        }

        [Fact]
        public void PriceShouldNotifyOfPropertyChange()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Price", () =>
            {
                pbj.Price = 0.1;
            });
        }

        [Fact]
        public void CaloriesShouldNotifyOfPropertyChange()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Calories", () =>
            {
                pbj.Calories = 0;
            });
        }
    }

}

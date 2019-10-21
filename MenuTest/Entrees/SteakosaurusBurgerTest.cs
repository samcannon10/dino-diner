using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Empty(sb.Special);
        }

        [Fact]
        public void HoldBunShouldAppearInSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();

            Assert.Collection<string>(sb.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }

        [Fact]
        public void HoldKetchupShouldAppearInSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();

            Assert.Collection<string>(sb.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            });
        }

        [Fact]
        public void HoldMustardShouldAppearInSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();

            Assert.Collection<string>(sb.Special, item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
        }

        [Fact]
        public void HoldPickleShouldAppearInSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();

            Assert.Collection<string>(sb.Special, item =>
            {
                Assert.Equal("Hold Pickles", item);
            });
        }

        [Fact]
        public void HoldBunNotifyOfPropertyChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();

            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldBun();
            });
        }

        [Fact]
        public void HoldKetchupNotifyOfPropertyChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();

            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldKetchup();
            });
        }

        [Fact]
        public void HoldMustardNotifyOfPropertyChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();

            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldMustard();
            });
        }

        [Fact]
        public void HoldPickleNotifyOfPropertyChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();

            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldPickle();
            });
        }

        [Fact]
        public void PriceShouldNotifyOfPropertyChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Price", () =>
            {
                sb.Price = 0.1;
            });
        }

        [Fact]
        public void CaloriesShouldNotifyOfPropertyChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Calories", () =>
            {
                sb.Calories = 0;
            });
        }
    }

}

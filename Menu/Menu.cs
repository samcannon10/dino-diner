/*Menu.cs
 * Author: Samuel Cannon
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu class
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Gets a list of all available menu items
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.AddRange(AvailableEntrees);
                items.AddRange(AvailableSides);
                items.AddRange(AvailableDrinks);
                return items;
            }
        }

        /// <summary>
        /// Gets a list of all available entrees
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> entrees = new List<Entree>();
                entrees.Add(new DinoNuggets());
                entrees.Add(new VelociWrap());
                entrees.Add(new PrehistoricPBJ());
                entrees.Add(new PterodactylWings());
                entrees.Add(new TRexKingBurger());
                entrees.Add(new SteakosaurusBurger());
                entrees.Add(new Brontowurst());
                return entrees;
            }
        }

        /// <summary>
        /// Gets a list of all available sides
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> sides = new List<Side>();
                sides.Add(new Triceritots());
                sides.Add(new Fryceritops());
                sides.Add(new MeteorMacAndCheese());
                sides.Add(new MezzorellaSticks());
                return sides;
            }
        }

        /// <summary>
        /// Gets a list of all available drinks
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> drinks = new List<Drink>();
                drinks.Add(new Water());
                drinks.Add(new Sodasaurus());
                drinks.Add(new JurassicJava());
                drinks.Add(new Tyrannotea());
                return drinks;
            }
        }

        /// <summary>
        /// Gets a list of all available combos
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> combos = new List<CretaceousCombo>();
                List<Entree> entrees = AvailableEntrees;
                foreach (Entree e in entrees) combos.Add(new CretaceousCombo(e));
                return combos;
            }
        }

        /// <summary>
        /// Default ToString for Menu class
        /// </summary>
        /// <returns>All available menu items as a string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IMenuItem m in AvailableMenuItems) sb.Append($"{m.ToString()}\n");
            return sb.ToString();
        }
    }
}

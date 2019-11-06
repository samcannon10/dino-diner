/*CretaceousCombo.cs
 * Author: Nathan Bean
 * Modified by: Samuel Cannon
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        // Backing Variable
        private Size size;
        private Entree entree;
        private Side side;
        private Drink drink;

        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree
        { 
            get
            {
                return entree;
            }
            set
            {
                entree = value;
                entree.PropertyChanged += ItemUpdated;
                NotifyOfPropertyChanged("Entree");
            }
        }

        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
                side.PropertyChanged += ItemUpdated;
                NotifyOfPropertyChanged("Side");
            }
        }

        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
                drink.PropertyChanged += ItemUpdated;
                NotifyOfPropertyChanged("Drink");
            }
        }

        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets or sets the size of the combo
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// Gets the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// Gets description as a string
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Holds any special instructions for preparation
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Notifies of changes to items in this combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ItemUpdated(object sender, PropertyChangedEventArgs args)
        {
            NotifyOfPropertyChanged("Description");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Calories");
        }

        /// <summary>
        /// Constructs a new combo with the specified entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree e)
        {
            entree = e;
            entree.PropertyChanged += ItemUpdated;
            side = new Fryceritops();
            side.PropertyChanged += ItemUpdated;
            drink = new Sodasaurus();
            drink.PropertyChanged += ItemUpdated;
        }

        /// <summary>
        /// Default ToString for CretaceousCombo
        /// </summary>
        /// <returns>The combo as a string</returns>
        public override string ToString()
        {
            return this.Entree.ToString() + " Combo";
        }
    }
}

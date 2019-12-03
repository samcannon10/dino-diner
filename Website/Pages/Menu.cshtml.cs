using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu menu { get; } = new Menu();

        public List<IMenuItem> items;

        public List<string> ingredients;

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public List<string> excludeIngredients { get; set; } = new List<string>();

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public double? minimumPrice { get; set; } = 0;

        [BindProperty]
        public double? maximumPrice { get; set; } = 0;

        public void OnGet()
        {
            items = menu.AvailableMenuItems;
            ingredients = menu.PossibleIngredients;
        }

        public void OnPost()
        {
            items = menu.AvailableMenuItems;
            ingredients = menu.PossibleIngredients;
            items = Search(search);
        }

        private List<IMenuItem> Search(string term)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            List<IMenuItem> temp = new List<IMenuItem>();
            temp.AddRange(FilterByCategory());
            temp = FilterByPrice(temp);
            temp = FilterByIngredient(temp);

            foreach(IMenuItem item in temp)
            {
                if (search != null && item.ToString().Contains(term, StringComparison.OrdinalIgnoreCase)) results.Add(item);
                else if (search == null) results.Add(item);
            }

            return results;
        }

        private List<IMenuItem> FilterByCategory()
        {
            List<IMenuItem> results = new List<IMenuItem>();

            if(menuCategory.Count > 0)
            {
                foreach(IMenuItem item in menu.AvailableMenuItems)
                {
                    if(item is CretaceousCombo c && menuCategory.Contains("Combo"))
                    {
                        results.Add(c);
                    }
                    if(item is Entree e && menuCategory.Contains("Entree"))
                    {
                        results.Add(e);
                    }
                    if(item is Side s && menuCategory.Contains("Side"))
                    {
                        results.Add(s);
                    }
                    if(item is Drink d && menuCategory.Contains("Drink"))
                    {
                        results.Add(d);
                    }
                }
            }
            else return menu.AvailableMenuItems;

            return results;
        }

        private List<IMenuItem> FilterByPrice(List<IMenuItem> items)
        {
            List<IMenuItem> temp = new List<IMenuItem>();
            if (maximumPrice != null && minimumPrice != null)
            {
                foreach (IMenuItem item in items)
                {
                    if (item.Price >= minimumPrice && item.Price <= maximumPrice) temp.Add(item);
                }
            }
            else if(maximumPrice != null)
            {
                foreach(IMenuItem item in items)
                {
                    if (item.Price <= maximumPrice) temp.Add(item);
                }
            }
            else if(minimumPrice != null)
            {
                foreach(IMenuItem item in items)
                {
                    if (item.Price >= minimumPrice) temp.Add(item);
                }
            }
            else return items;

            return temp;
        }

        private List<IMenuItem> FilterByIngredient(List<IMenuItem> items)
        {
            List<IMenuItem> temp = new List<IMenuItem>();

            if (excludeIngredients.Count > 0)
            {
                foreach (IMenuItem item in items)
                {
                    bool hasIngredient = false;
                    foreach(string i in item.Ingredients)
                    {
                        if (excludeIngredients.Contains(i)) hasIngredient = true;
                    }
                    if (hasIngredient == false) temp.Add(item);
                }
            }
            else return items;

            return temp;
        }
    }
}
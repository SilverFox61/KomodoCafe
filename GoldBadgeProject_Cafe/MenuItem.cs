using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeChallengeProject
{
    public class MenuItem
    {
        // Class methods

        public int MenuNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public Decimal Price { get; set; }

        // Constructors -- set the initial state

        public MenuItem(int menuNumber, string mealName, string description, 
                        string ingredients, Decimal price)
        {
            MenuNumber = menuNumber;
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }    
    }
}
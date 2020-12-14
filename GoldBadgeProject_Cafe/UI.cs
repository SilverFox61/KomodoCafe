using Komodo_Cafe_Repo;
using System;
using System.Collections.Generic;

namespace Komodo_Cafe
{
    class UI
    {
        public static string BuildMenuTitle()
        {
            string title = "\n============================================\n" +
                           "          Creating Komodo Cafe Menu\n" +
                           "============================================\n";

            return title;
        }
        public static string BuildMenuOptions()
        {
            string menuItemOptions = "Select a menu option to build a menu:\n" +
                                     "   1. Create a new menu item.\n" +
                                     "   2. View a menu item.\n" +
                                     "   3. Delete a menu item.\n" +
                                     "   4. Update the menu item.\n" +
                                     "   5. View all items on the cafe's menu.\n" +
                                     "   6. Display build menu options.\n" +
                                     "   7. Exit.";
            return menuItemOptions;

        }
        public static int RequestIntegerFromUser(string prompt)
        {
            // Local Variables

            int userInput;

            Console.WriteLine(prompt);
            userInput = Convert.ToInt32(Console.ReadLine());

            return userInput;
        }
        public static string RequestStringFromUser(string prompt)
        {
            // Local Variables

            string userInput = null;

            Console.Write(prompt);
            userInput = Console.ReadLine();

            return userInput;
        }
        public static Decimal RequestDecimalFromUser(string prompt)
        {
            // Local Variables

            Decimal userInput = 0m;

            Console.WriteLine(prompt);
            userInput = Convert.ToDecimal(Console.ReadLine());

            return userInput;
        }

        public static void DeleteMenuItem(MenuRepository menu, int menuNumber)
        {
            // Local Variables
            
            List<MenuItem> list = menu.MenuItemsList();

            // Display the menu

            Console.WriteLine();
            
            foreach ( MenuItem menuItem in list )
            { 
                if ( menuItem.MenuNumber == menuNumber )
                {
                    list.Remove(menuItem);
                    return;
                }
            }
        }
        public static MenuItem CreateMenuItem()
        {
            // Local Variables

            MenuItem menuItem = null;

            int menuNumber = 0;
            string menuName = null;
            string menuDescription = null;
            string menuIngredients = null;
            Decimal menuPrice = 0m;

            Console.WriteLine();
            menuNumber = RequestIntegerFromUser("Enter menu #: ");
            menuName = RequestStringFromUser("Enter menu name: ");
            menuDescription = RequestStringFromUser("Enter menu description: ");
            menuIngredients = RequestStringFromUser("Enter menu ingredients: ");
            menuPrice = RequestDecimalFromUser("Enter menu price: ");

            menuItem = new MenuItem(menuNumber, menuName, menuDescription,
                                     menuIngredients, menuPrice);
            return menuItem;
        }

        public static void DisplayMenuItem(MenuItem menuItem )
        {
            // Local Variables

            int menuNumber = 0;
            string menuName = null;
            string menuDescription = null;
            string menuIngredients = null;
            Decimal menuPrice = 0m;

            // Extract menu info

            menuNumber = menuItem.MenuNumber;
            menuName = menuItem.MealName;
            menuDescription = menuItem.Description;
            menuIngredients = menuItem.Ingredients;
            menuPrice = menuItem.Price;

            Console.WriteLine("\n[" + menuNumber + "] ");
            Console.WriteLine(menuName + " ");
            Console.WriteLine(menuPrice.ToString("C") + "\n");

            Console.WriteLine("   Description: " + menuDescription);
            Console.WriteLine("   Ingredients: " + menuIngredients);
        }

        public static void DisplayMenuItem(MenuRepository menu, int menuNumber)
        {
            // Local Variables

            MenuItem menuItem = null;

            // Extract menu option from menu

            menuItem = menu.GetMenuItemsBy(menuNumber);

            UI.DisplayMenuItem( menuItem);
        }

        public static void DisplayAllMenuItems(MenuRepository menu)
        { 
            // Local Variables

            List<MenuItem> menuItems = null;

            // Retrieve Actual Menu

            menuItems = menu.MenuItemsList();

            // Display the menu

            Console.WriteLine();
            foreach (MenuItem menuItem in menuItems)
            {
                UI.DisplayMenuItem(menuItem);
            }
        }
    }
}
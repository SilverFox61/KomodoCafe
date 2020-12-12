//using GoldBadgeCafeProject_Repo

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeChallengeProject
{
    class KomodoCafe
    {
        static int RequestIntegerFromUser( string prompt )
        {
            // Local Variables

            int userInput;

            Console.Write( prompt );
            userInput = Convert.ToInt32(Console.ReadLine());

            return userInput;
        }
        static string RequestStringFromUser(string prompt)
        {
            // Local Variables

            string userInput = null;

            Console.Write(prompt);
            userInput = Console.ReadLine();

            return userInput;
        }
        static Decimal RequestDecimalFromUser(string prompt)
        {
            // Local Variables

            Decimal userInput = 0m;

            Console.Write(prompt);
            userInput = Convert.ToDecimal(Console.ReadLine());

            return userInput;
        }
        static MenuItem CreateMenuItem()
        {
            // Local Variables

            MenuItem menuItem = null;

            int menuNumber = 0;
            string menuName = null;
            string menuDescription = null;
            string menuIngredients = null;
            Decimal menuPrice = 0m;

            menuNumber = RequestIntegerFromUser("Enter menu #: ");
            menuName = RequestStringFromUser("Enter menu name: ");
            menuDescription = RequestStringFromUser("Enter menu description: ");
            menuIngredients = RequestStringFromUser("Enter menu ingredients: ");
            menuPrice = RequestDecimalFromUser("Enter menu price: ");

            menuItem = new MenuItem(menuNumber, menuName, menuDescription,
                                     menuIngredients, menuPrice);
            return menuItem;
        }

        static void DisplayMenuItem( MenuItem menuItem )
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

            Console.Write("[" + menuNumber + "] ");
            Console.Write( menuName + " " );
            Console.Write( menuPrice.ToString("C") + "\n" );

            Console.WriteLine( "   Description: " + menuDescription );
            Console.WriteLine( "   Ingredients: " + menuIngredients );
        }

        static void Main( String [] args )
        {
            // Local Variables

            MenuRepository menu = null;
            List<MenuItem> menuItems = null;

            // Instantiate the menu

            menu = new MenuRepository();

            Console.WriteLine("============================================");
            Console.WriteLine("          Creating Komodo Cafe Menu");
            Console.WriteLine("============================================");

            // Create a 3 item menu

            for ( int i = 0; i <= 3; i++ )
            {
                Console.WriteLine("\n");
                menu.AddMenuItemsToList(CreateMenuItem());

            }

            // Retrieve Actual Menu

            menuItems = menu.MenuItemsList();

            // Display the menu

            foreach ( MenuItem menuItem in menuItems )
            {
                DisplayMenuItem(menuItem);
            }
        }
    }
}
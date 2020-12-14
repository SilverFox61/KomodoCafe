using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komodo_Cafe_Repo;

namespace Komodo_Cafe
{
    class KomodoCafe
    {
        static void Main( String [] args )
        {
            // Local Variables

            MenuRepository menu = null;
            string prompt = null;
            string strBuildMenuOptions = null;
            int buildMenuOption = 0;
            int menuNumber = 0;

            // Instantiate the menu

            menu = new MenuRepository();

            // Display build menu options

            Console.WriteLine(UI.BuildMenuTitle());
            strBuildMenuOptions = UI.BuildMenuOptions();
            Console.WriteLine(strBuildMenuOptions);

            do
            {
                buildMenuOption = UI.RequestIntegerFromUser("\nEnter build menu option: ");

                switch ( buildMenuOption )
                {
                    case 1:     // Create menu option
                        menu.AddMenuItemsToList(UI.CreateMenuItem());
                        break;

                    case 2:     // View a menu option
                        menuNumber = UI.RequestIntegerFromUser("\nEnter menu #: ");
                        UI.DisplayMenuItem(menu, menuNumber);
                        break;

                    case 3:     // Delete menu option
                        menuNumber = UI.RequestIntegerFromUser("\nEnter menu #: ");
                        UI.DeleteMenuItem(menu, menuNumber);
                        break;

                    case 4:     // Update menu option
                        Console.WriteLine("\nBuild menu option not implemented!");
                        break;

                    case 5:     // View all menu options on cafe's menu.
                        UI.DisplayAllMenuItems(menu);
                        break;

                    case 6:     // View build menu options
                        Console.WriteLine(UI.BuildMenuTitle());
                        Console.WriteLine(strBuildMenuOptions);
                        break;
                }

            } while (buildMenuOption != 7);
        }
    }
}
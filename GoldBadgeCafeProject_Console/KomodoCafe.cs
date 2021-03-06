﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komodo_Cafe_Repo;

namespace Komodo_Cafe
{
    class KomodoCafe
    {
        static void Main()
        {
            // Local Variables

            MenuRepository menu;
            string strBuildMenuOptions;
            int buildMenuOption;
            int menuNumber;

            // Instantiate the menu

            menu = new MenuRepository();

            // Display build menu options

            Console.WriteLine(UI.BuildMenuTitle());
            string BuildMenuOptions = UI.BuildMenuOptions();
            Console.WriteLine(BuildMenuOptions);

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
                        Console.WriteLine(BuildMenuOptions);
                        break;
                }

            } while (buildMenuOption != 7);
        }
    }
}
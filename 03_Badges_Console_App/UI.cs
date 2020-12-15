using Komodo_Insurance_Repo;
using System;
using System.Collections.Generic;

namespace Komodo_Insurance_App
{
    class UI
    {
        public BadgesRepository _badgesRepo = new BadgesRepository();
        public Badge badge = null;

        public static string CreateMenuTitle()
        {
            string title = "\n============================================\n" +
                           "          Komodo Insurance Menu\n" +
                           "============================================\n";

            return title;
        }
        public static string CreateMenuOptions()
        {
            string menuItemOptions = "Select a menu option to build a menu:\n" +
                                     "   1. Add a badge.\n" +
                                     "   2. Edit a badge.\n" +
                                     "   3. List all badges.\n" +
                                     "   4. Display menu.\n" +
                                     "   5. Exit.";
            return menuItemOptions;
        }

        public static void DisplayConsoleMessage(string message)
        {
            Console.WriteLine(message);
        }

        public Badge CreateNewBadge()
        {
            // Local Variables

            List<string> listOfDoors = new List<string>();
            Badge newBadge;
            int id;
            string door;

            id = RequestIntegerFromUser("What is the number on the badge: ");

            do
            {
                door = UI.RequestStringFromUser( "\nList a door that it needs access to: " );

                listOfDoors.Add(door);

            } while (UI.RequestYesNoFromUser( "\nAny other doors (y/n): ") == "Y");

            newBadge = new Badge(id, listOfDoors);

            return newBadge;
        }
        public static int RequestIntegerFromUser(string prompt)
        {
            // Local Variables

            int userInput;

            Console.WriteLine(prompt);
            userInput = Convert.ToInt32(Console.ReadLine());

            return userInput;
        }

        public static string RequestYesNoFromUser( string prompt)
        {
            // Local Variables

            string userResponse;

            userResponse = UI.RequestStringFromUser(prompt);

            userResponse = userResponse.ToUpper().Substring(0, 1);

            return userResponse;
        }
        public static string RequestStringFromUser(string prompt)
        {
            // Local Variables

            string userInput;

            Console.WriteLine(prompt);
            userInput = Console.ReadLine();

            return userInput;
        }
        public static decimal RequestDecimalFromUser(string prompt)
        {
            // Local Variables

            decimal userInput;

            Console.WriteLine(prompt);
            userInput = Convert.ToDecimal(Console.ReadLine());

            return userInput;
        }
    }
}

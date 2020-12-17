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

        public static Badge CreateNewBadge()
        {
            // Local Variables

            List<string> listOfDoors = new List<string>();
            Badge newBadge;
            int id;
            string door;

            id = RequestIntegerFromUser("\nWhat is the number on the badge: ");

            do
            {
                door = UI.RequestDoorFromUser( "\nList a door that it needs access to: " );

                door = door.Trim().ToUpper();

                listOfDoors.Add(door);

            } while (UI.RequestYesNoFromUser( "\nAny other doors (y/n): ") == "Y");

            newBadge = new Badge(id, listOfDoors);

            return newBadge;
        }

        private static void AddDoor( Badge existingBadge )
        {
            // Local Variables

            string doorToAdd;

            // Get user input

            doorToAdd = UI.RequestDoorFromUser("\nWhich door would you like to add? ");

            // Trim spaces if exist and make lowercase

            doorToAdd = doorToAdd.Trim().ToUpper();

            // Add door from the list

            if ( existingBadge.AddDoor(doorToAdd) )
                UI.DisplayConsoleMessage("Door added.\n");
        }
        private static void RemoveDoor(Badge existingBadge)
        {
            // Local Variables

            string doorToRemove;

            // Get user input

            doorToRemove = UI.RequestDoorFromUser("\nWhich door would you like to remove? ");

            // Remove door from the list

            if ( existingBadge.RemoveDoor(doorToRemove) )
               UI.DisplayConsoleMessage("Door removed.\n");
        }

        public static void RequestDoorChangeFromUser( Badge existingBadge )
        {
            // Local Variables

            int menuOption;

            bool validOption = false;         // Assume invalid option

            string prompt = "What would you like to do?" +
                            "\n   1. Remove a door" +
                            "\n   2. Add a door" +
                            "\n> ";
            do
            {
                // Request type of change to existing doors

                menuOption = UI.RequestIntegerFromUser(prompt);

                switch (menuOption)
                {
                    case 1:
                        UI.RemoveDoor(existingBadge);
                        validOption = true;
                        break;

                    case 2:
                        UI.AddDoor(existingBadge);
                        validOption = true;
                        break;

                    default:
                        UI.DisplayConsoleMessage("\nInvalid menu option!");
                        break;
                }

            } while (!validOption);

            UI.DisplayConsoleMessage(existingBadge.ID + " has acccess to " + existingBadge.ListDoorsForBadge());
        }

        public static void UpdateBadge( BadgesRepository listOfBadges )
        {
            // Local Variables

            Badge existingBadge;
            int id;

            // Get user badge #

            id = RequestIntegerFromUser("\nWhat is the badge number to update? ");

            // Get badge from dictionary

            existingBadge = listOfBadges.GetBadgeBy(id);

            // Display current list of doors for access

            UI.DisplayConsoleMessage( BadgesRepository.DisplayAllValidDoors());

            // Request from user to either remove or add badge

            UI.RequestDoorChangeFromUser( existingBadge );
        }

        public static string RequestDoorFromUser(string prompt)
        {
            // Local Variables

            string userInput;
            bool validInput = false;  //Assume INVALID input

            do
            {
                UI.DisplayConsoleMessage(prompt);
                userInput = Console.ReadLine();

                userInput = userInput.Trim().ToUpper();

                if (BadgesRepository.VALID_DOORS.Contains(userInput))
                    validInput = true;
                else
                    UI.DisplayConsoleMessage("\nInvalid door! Not in list of valid doors.");

            } while (!validInput);

            return userInput;
        }

        public static int RequestIntegerFromUser(string prompt)
        {
            // Local Variables

            string strUserInput;
            int userInput = 0;
            bool validInput = false;    // Assume invalid input

            do
            {
                Console.Write(prompt);

                strUserInput = Console.ReadLine().Trim();

                if (strUserInput.Length >= 1)
                {
                    if (Int32.TryParse(strUserInput, out userInput ))
                        validInput = true;

                    else
                        UI.DisplayConsoleMessage("\nInvalid input: Cannot be converted to integer!");
                }
                else
                    UI.DisplayConsoleMessage("\nInvalid input: No characters were entered!");

            } while (!validInput);

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

            Console.Write(prompt);
            userInput = Console.ReadLine();

            return userInput;
        }
        public static decimal RequestDecimalFromUser(string prompt)
        {
            // Local Variables

            decimal userInput;

            Console.Write(prompt);
            userInput = Convert.ToDecimal(Console.ReadLine());

            return userInput;
        }
    }
}
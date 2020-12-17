using Komodo_Insurance_Repo;
using System;

namespace Komodo_Insurance_App
{
    class KomodoInsurance
    {
        static void Main()
        {
            // Local Variables

            BadgesRepository listOfBadges = new BadgesRepository();
            int menuOption;
            Badge newBadge;

            // Display menu title

            UI.DisplayConsoleMessage(UI.CreateMenuTitle());

            // Display menu options

            UI.DisplayConsoleMessage(UI.CreateMenuOptions());

            // Get menu response from user

            do
            {
                menuOption = UI.RequestIntegerFromUser("\nEnter badges menu option: ");

                switch (menuOption)
                {
                    case 1:     // Add a Badge
                        newBadge = UI.CreateNewBadge();
                        Console.WriteLine("ID: " + newBadge.ID);
                        listOfBadges.AddBadge(newBadge.ID, newBadge);
                        break;

                    case 2:     // Edit a Badge
                        UI.UpdateBadge(listOfBadges);
                        break;

                    case 3:     // List all Badges
                        UI.DisplayConsoleMessage(listOfBadges.DisplayAllBadges());
                        break;

                    case 4:     // Display menu options
                        UI.DisplayConsoleMessage("");
                        UI.DisplayConsoleMessage(UI.CreateMenuOptions());
                        break;
                }

            } while (menuOption != 5);
        }
    }
}

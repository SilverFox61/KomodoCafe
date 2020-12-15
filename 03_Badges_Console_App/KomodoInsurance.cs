using Komodo_Insurance_Repo;
using System.Linq;

namespace Komodo_Insurance_App
{
    class KomodoInsurance
    {
        private static string stringFormat;

        static void Main()
        {
            // Local Variables

            BadgesRepository listOfBadges = new BadgesRepository();
            string userResponse;
            int menuOption;

            // Display menu title

            UI.DisplayConsoleMessage(UI.CreateMenuTitle());

            // Display menu options

            UI.DisplayConsoleMessage(UI.CreateMenuOptions());

            do
            {
                menuOption = UI.RequestIntegerFromUser("\nEnter badges menu option: ");

                switch (menuOption)
                {
                    case 1:     // Add a Badge
                        
                        break;

                    case 2:     // Edit a Badge
                        break;

                    case 3:     // List all Badges
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

using Komodo_Claims_Repo;
using System;
using System.Linq;

namespace Komodo_Claims_App
{
    class KomodoClaims
    {
       private static string stringFormat;

        static void Main()
        { 
            // Local Variables

            Komodo_Claims_Repo.ClaimsRepository listOfClaims = new Komodo_Claims_Repo.ClaimsRepository();
            Claims newClaim;
            string userResponse;
            int menuOption;

            // Display menu title

            UI.DisplayConsoleMessage(UI.CreateMenuTitle());
 
            // Display menu options

            UI.DisplayConsoleMessage(UI.CreateMenuOptions());

            do
            {
                menuOption = UI.RequestIntegerFromUser("\nEnter claims menu option: ");

                switch (menuOption)
                {
                    case 1:     // See all claims
                        listOfClaims.DisplayClaims();
                        break;

                    case 2:     // Take care of next claim
                        string strFormat = listOfClaims.CreateFormattedNextClaim();

                        if (strFormat.Length > 30)
                        {
                            UI.DisplayConsoleMessage(stringFormat);

                            userResponse = UI.RequestStringFromUser("\nDo you want to deal with this claim now (y/n)? ");

                            if (userResponse.Trim().ToLower().ElementAt(0) == 'y')
                                listOfClaims.RemoveNextClaim();
                        }
                        else
                            UI.DisplayConsoleMessage(stringFormat);

                        break;

                    case 3:     // Enter new claim
                        UI newUI = new UI();
                        newClaim = newUI.CreateNewClaim();
                        if (newClaim.IsValid)
                        {
                            listOfClaims.AddClaimsToList(newClaim);

                            UI.DisplayConsoleMessage("\nClaim is valid and added!");
                        }
                        else
                            UI.DisplayConsoleMessage("\nClaim is NOT valid so was NOT added!");
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
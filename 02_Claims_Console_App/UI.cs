using Komodo_Claims_Repo;
using System;
using System.Security.Claims;

namespace Komodo_Claims_App
{
    class UI
    {
        public ClaimsRepository _claimsRepo = new ClaimsRepository();
        public Claims claim = new Claims(); 
           
        public static string CreateMenuTitle()
        {
            string title = "\n============================================\n" +
                           "          Komodo Claims Menu\n" +
                           "============================================\n";

            return title;
        }
        public static string CreateMenuOptions()
        {
            string menuItemOptions = "Select a menu option to build a menu:\n" +
                                     "   1. See all claims.\n" +
                                     "   2. Take care of next claim.\n" +
                                     "   3. Enter a new claim.\n" +
                                     "   4. Display menu.\n" +
                                     "   5. Exit.";
            return menuItemOptions;

        }

        public static void DisplayConsoleMessage( string message )
        {
            Console.WriteLine(message);
        }

        public Claims CreateNewClaim()
        {
            // Local Variables

            Claims newClaim;
            
            int id = RequestIntegerFromUser("Enter claim ID: ");

            string type;

            int typeNumber = RequestIntegerFromUser("Enter claim type (1-Car,2-Home,3-Theft): ");
            if (typeNumber == 1)
                type = "Car";
            else if (typeNumber == 2)
                type = "Home";
            else //Default to Theft
                type = "Theft";

            string description = RequestStringFromUser("Enter claim description: ");
            decimal amount = RequestDecimalFromUser("Enter claim amount: ");

            string dateOfIncident = RequestStringFromUser("Enter date of incident (exp: 12/1/2020): ");
            DateTime incidentDate = DateTime.Parse(dateOfIncident);
            string dateOfClaim = RequestStringFromUser("Enter date of claim (exp: Wed 12/2/2020): ");
            DateTime claimDate = DateTime.Parse(dateOfClaim);

            newClaim = new Claims(id, type, description, amount, incidentDate, claimDate);

            return newClaim;
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
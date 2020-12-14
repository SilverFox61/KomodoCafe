using Komodo_Claims_Repo;
using System;

namespace Komodo_Claims_App
{
    class UI
    {
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

        public static Claim CreateNewClaim()
        {
            // Local Variables

            Claim newClaim;

            int id;
            int typeNumber;
            string type;
            string description;
            Decimal amount;
            DateTime dateOfIncident;
            string strDOI;
            DateTime dateOfClaim;
            string strDOC;

            Console.WriteLine();
            id = RequestIntegerFromUser("Enter claim ID: ");
            
            typeNumber = RequestIntegerFromUser("Enter claim type (1-Car,2-Home,3-Theft): ");
            if (typeNumber == 1)
                type = "Car";
            else if (typeNumber == 2)
                type = "Home";
            else //Default to Theft
                type = "Theft";

            description = RequestStringFromUser("Enter claim description: ");
            amount = RequestDecimalFromUser("Enter claim amount: ");

            strDOI = RequestStringFromUser("Enter date of incident (exp: 12/1/2020): ");
            strDOC = RequestStringFromUser("Enter date of claim (exp: Wed 12/2/2020): ");

            dateOfIncident = DateTime.Parse(strDOI);
            dateOfClaim = DateTime.Parse(strDOC);

            newClaim = new Claim(id, type, description, amount, dateOfIncident, dateOfClaim );

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
        public static Decimal RequestDecimalFromUser(string prompt)
        {
            // Local Variables

            Decimal userInput;

            Console.WriteLine(prompt);
            userInput = Convert.ToDecimal(Console.ReadLine());

            return userInput;
        }
    }
}
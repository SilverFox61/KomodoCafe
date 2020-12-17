using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance_Repo
{
    public class BadgesRepository
    {
        // Class Constants

        public static List<string> VALID_DOORS = new List<string>()
             { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9" };

        // Class Variables

        private Dictionary<int, Badge> listOfBadges;
        public Dictionary<int, Badge> BadgeList() => listOfBadges;

        public int ID { get; set; }

        // Constructor

        public BadgesRepository()
        {
            listOfBadges = new Dictionary<int, Badge>();
        }

        // Class Methods

        public void AddBadge( int id, Badge badge )
        {
            listOfBadges.Add( id, badge );
        }

        public Badge GetBadgeBy(int id)
        {
            foreach (KeyValuePair<int,Badge> keyValue in listOfBadges)
            {
                if (keyValue.Key == id)
                {
                    return keyValue.Value;
                }
            }

            return null;
        }

        public static string DisplayAllValidDoors()
        {
            // Local Variables

            string formattedString;

            // Add in titles

            formattedString = "\nValid doors: ";

            foreach ( string door in VALID_DOORS )
            {
                formattedString += door + ", ";
            }

            formattedString = formattedString.Substring(0, formattedString.Length - 2);

            formattedString += "\n";

            return formattedString;
        }

        public string DisplayAllBadges()
        {
            // Local Variables

            string formattedString;

            // Add in titles

            formattedString = "\nBadge # Door Access\n\n";

            foreach (KeyValuePair<int, Badge> keyValue in listOfBadges)
            {
                formattedString += keyValue.Key + "   ";

                formattedString += keyValue.Value.ListDoorsForBadge(); 
            }

            return formattedString;
        }
    }
}
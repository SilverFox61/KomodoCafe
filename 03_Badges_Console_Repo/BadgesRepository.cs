using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance_Repo
{
    public class BadgesRepository
    {
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

        //public void DeleteBadge( int id )
        //{

        //}

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

        public string DisplayAllBadges()
        {
            // Local Variables

            string formattedString;

            // Add in titles

            formattedString = "Badge #  Door Access\n";

            foreach (KeyValuePair<int, Badge> keyValue in listOfBadges)
            {
                formattedString += keyValue.Key + "   ";

                formattedString += keyValue.Value.ListDoorsForBadge(); 
            }

            return formattedString;
        }
    }
}
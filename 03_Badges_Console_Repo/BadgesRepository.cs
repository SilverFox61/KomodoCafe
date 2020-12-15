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

        private Dictionary<int, Badge> listOfDoors;
        
        public string Badge { get; set; }

        // Constructor

        public BadgesRepository()
        {
            listOfDoors = new Dictionary<int, Badge>();
        }

        // Class Methods

        public void AddMenuItemsToList( int id, Badge badge )
        {
            listOfDoors.Add( id, badge );
        }

        public Dictionary<int,Badge> badgeList() => listOfDoors;

        public Badge GetMenuItemsBy(int id)
        {
            foreach (KeyValuePair<int,Badge> keyValue in listOfDoors )
            {
                if (keyValue.Key == id)
                {
                    return keyValue.Value;
                }
            }

            return null;
        }
    }
}
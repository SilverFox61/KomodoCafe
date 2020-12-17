using System.Collections.Generic;

namespace Komodo_Insurance_Repo
{
    public class Badge
    {
        // Class Variables

        private int id;
        private List<string> listOfDoors;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public List<string> LIST
        {
            get { return listOfDoors; }
            set { listOfDoors = value; }
        }

        public Badge() {}

        public Badge( int id )
        {
            this.id = id;
            listOfDoors = new List<string>();
        }
        public Badge( int id, List<string> doors )
        {
            this.id = id;
            listOfDoors = doors;
        }
        public bool AddDoor( string door )
        {
            bool added = false;

            if (!listOfDoors.Contains(door))
            {
                added = true;
                listOfDoors.Add(door);
            }

            return added;
        }

        public bool Contains( string door )
        {
            return listOfDoors.Contains(door);
        }

        public bool RemoveDoor( string door )
        {
            bool removed = false;

            if (listOfDoors.Contains(door))
            {
                removed = listOfDoors.Remove( door );
            }

            return removed;
        }

        public string ListDoorsForBadge()
        {
            // Local Variables

            string formattedString = "";

            foreach (string door in listOfDoors)
            {
               formattedString += (door + ", ");
            }

            formattedString = formattedString.Substring(0, formattedString.Length - 2);

            formattedString += "\n";

            return formattedString;
        }
    }
}
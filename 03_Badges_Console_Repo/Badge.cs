using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance_Repo
{
    public class Badge
    {
        private int Id;
        private List<string> listOfDoors;

        public string ID { get; set; }
        public List<string> LIST { get; set; }

        public Badge() {}
        public Badge( int id, List<string> doors )
        {
            Id = id;
            listOfDoors = doors;
        }

        public void addBadge( string door )
        {
            listOfDoors.Add(door);
        }

        public void deleteBadge( string door )
        {

        }
    }
}
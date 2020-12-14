using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Cafe_Repo
{
    public class MenuRepository
    {
        // Class Variables

        private List<MenuItem> _listOfMenuItems = new List<MenuItem>();

        // Class Methods

        public void AddMenuItemsToList(MenuItem item)
        {
            _listOfMenuItems.Add(item);
        }

        //Read
        public List<MenuItem> MenuItemsList() => _listOfMenuItems;

        public MenuItem GetMenuItemsBy(int MenuNumber)
        {
            foreach (MenuItem item in _listOfMenuItems)
            {
                if (item.MenuNumber == MenuNumber)
                {
                    return item;
                }
            }

            return null;
        }

        public void DeleteMenuItemsBy(int MenuNumber)
        {
            foreach (MenuItem item in _listOfMenuItems)
            {
                if (item.MenuNumber == MenuNumber)
                {
                    _listOfMenuItems.Remove(item);

                    return;
                }
            }
        }
    }
}
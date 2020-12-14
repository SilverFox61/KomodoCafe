using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Komodo_Cafe_Repo;

namespace Komodo_Console_App_Test
{
    [TestClass]
    public class MenuRepository_Test
    {
        [TestMethod]
        public void TestMenuRepositoryConstructor()
        {
            MenuRepository MenuRepository = new MenuRepository();
            List<MenuItem> list = MenuRepository.MenuItemsList();

            Assert.AreEqual(0, list.Count, 0, "After constructor size was NOT zero!");
        }

        public void TestAddingMenuItem()
        { 
            MenuItem newMenuItem = new MenuItem(1, "Hamburger Meal", "Great!", "Pig part", 5);

            MenuRepository MenuItemsList = new MenuRepository();

            int menuNumber = newMenuItem.MenuNumber;
            string menuName = newMenuItem.MealName;
            string description = newMenuItem.Description;
            string ingredients = newMenuItem.Ingredients;
            Decimal price = newMenuItem.Price;

            MenuRepository MenuRepository = new MenuRepository();

            MenuRepository.AddMenuItemsToList(newMenuItem);

            List<MenuItem> list = MenuRepository.MenuItemsList();

            Assert.AreEqual(1, list.Count, 0, "After adding 1 menu item, size was NOT 1!");
        }
    }
}

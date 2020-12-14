using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Komodo_Cafe_Repo;

namespace Komodo_Console_App_Test
{
    [TestClass]
    public class MenuItem_Test
    {
        [TestMethod]
        public void TestMenuItemGetters()
        {
            MenuItem newMenuItem = new MenuItem(1, "Hamburger Meal", "Great!", "Pig part", 5);

            int menuNumber = newMenuItem.MenuNumber;
            string menuName = newMenuItem.MealName;
            string description = newMenuItem.Description;
            string ingredients = newMenuItem.Ingredients;
            Decimal price = newMenuItem.Price;

            Assert.AreEqual(1, menuNumber, 0, "Menu number not set correctly!");
            Assert.AreEqual("Hamburger Meal", menuName, "", "Menu name not set correctly!");
            Assert.AreEqual("Great!", description, "", "Menu description not set correctly!");
            Assert.AreEqual("Pig part", ingredients, "", "Menu ingredients not set correctly!");
            Assert.AreEqual(new Decimal(5), price, "", "Menu price not set correctly!");

            Assert.AreEqual(1, menuNumber, 0, "Menu number not correct!");
        }
    }
}

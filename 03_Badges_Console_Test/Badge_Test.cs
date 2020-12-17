using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Komodo_Insurance_Repo;

namespace Komodo_Insurance_Test
{
    [TestClass]
    public class Badge_Test
    {
        [TestMethod]
        public void TestBadge()
        {
            int id = 12345;
            List<string> list = new List<string>()
            {
                "A1", "A2"
            };
            string door = "A3";

            Badge newBadge = new Badge( id, list );

            Assert.AreEqual(id, newBadge.ID, 0, "Badge ID was set incorrectly!");

            newBadge.AddDoor(door);

            Assert.AreEqual( true, newBadge.Contains( door ), "", "Door not added correctly!" );

            Assert.AreEqual( false, newBadge.Contains( "A5" ), "", "Door should not exist for badge!");

            newBadge.RemoveDoor(door);

            Assert.AreEqual(false, newBadge.Contains(door), "", "Door not removed correctly!");

            newBadge.AddDoor("A3");
            newBadge.AddDoor("A4");

            string expectedList = "A1, A2, A3, A4\n";
            string actualList = newBadge.ListDoorsForBadge();

            Console.WriteLine("E Length: " + expectedList.Length);
            Console.WriteLine("A Length: " + actualList.Length);

            Assert.AreEqual(expectedList.Length, actualList.Length, 0, "Length of List of doors not correct!");

            Assert.AreEqual(expectedList, actualList, " ", "List of doors not correct!");
        }
    }
}
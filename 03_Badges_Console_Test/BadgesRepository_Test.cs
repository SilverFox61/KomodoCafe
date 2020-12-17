using System;
using System.Collections.Generic;
using Komodo_Insurance_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Komodo_Insurance_Test
{
    [TestClass]
    public class Test_BadgesRepository
    {
        [TestMethod]
        public void TestBadgesRepository()
        {
           List<string> listValidDoors = new List<string>()
             { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9" };
        
            int id1 = 12345;
            List<string> list1 = new List<string>()
            {
                "A1", "A2"
            };

            Badge badge1 = new Badge(id1, list1);

            int id2 = 54321;
            List<string> list2 = new List<string>()
            {
                "A3", "A4"
            };

            Badge badge2 = new Badge(id2, list2);

            BadgesRepository br = new BadgesRepository();

            Assert.AreEqual(null, br.GetBadgeBy(id1), "", "null not returned since no badges exit!");

            br.AddBadge(id1,badge1);

            Assert.AreEqual(badge1, br.GetBadgeBy(id1), "", "Did not find badge that was added!");

            br.AddBadge(id2, badge2);

            Assert.AreEqual(badge2, br.GetBadgeBy(id2), "", "Did not find badge that was added!");



            string expectedList = "\nValid doors: A1, A2, A3, A4, A5, A6, A7, A8, A9\n";
            string actualList = BadgesRepository.DisplayAllValidDoors();

            Console.WriteLine("E Length: " + expectedList.Length);
            Console.WriteLine("A Length: " + actualList.Length);

            Assert.AreEqual(expectedList.Length, actualList.Length, 0, "Length of List of valid doors not correct!");

            Assert.AreEqual(expectedList, actualList, "", "List of valid doors not correct!");
        }
    }
}

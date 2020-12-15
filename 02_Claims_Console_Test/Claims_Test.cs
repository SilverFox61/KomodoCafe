using System;
using Komodo_Claims_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Komodo_Claims_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestClaimGetters()
        {
            Claims newClaim = new Claims(1, "Car", "Damaged Bumper", 200, 
                DateTime.Parse("Fri Dec 11, 2020"),
                DateTime.Parse("Sat Dec 12, 2020"));

            int id = newClaim.Id;
            string type = newClaim.Type;
            string description = newClaim.Description;
            Decimal amount = newClaim.Amount;

            Assert.AreEqual(1, id, 0, "ID number not set correctly!");
            Assert.AreEqual("Car", type, "", "Type not set correctly!");
            Assert.AreEqual("Damaged Bumper", description, "", "Description not set correctly!");
            Assert.AreEqual(new Decimal(200), amount, "", "Amount not set correctly!");
        }
    }
}

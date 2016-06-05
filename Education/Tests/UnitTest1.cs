using System;
using Education;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRefill()
        {
            AccumulationAccount AA1 = new AccumulationAccount(id: 1, client: "Ivanov", firstBalance: 120000, interestRate: 0.12);
            AccumulationAccount AA2 = new AccumulationAccount(id: 2, client: "Ivanov", firstBalance: 120000, interestRate: 0.12);

            AA1.Refill(1000);
            Assert.AreEqual(121000, AA1.Balance);

        }
    }
}

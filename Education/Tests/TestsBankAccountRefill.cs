using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Education;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Tests
{
    [TestFixture]
    public class TestsBankAccountRefill
    {
        [Test]
        public void Refill_Plus12000()
        {
            AccumulationAccount AA1 = new AccumulationAccount(id: 1, client: "Ivanov", firstBalance: 12000, interestRate: 0.12);
            AA1.Refill(12000);
            Assert.AreEqual(24000, AA1.Balance,"Баланс счета неверный");
        }

        [Test]
        public void Refill_Plus0()
        {
            AccumulationAccount AA1 = new AccumulationAccount(id: 1, client: "Ivanov", firstBalance: 12000, interestRate: 0.12);
            Assert.Throws<ArgumentOutOfRangeException>(() => AA1.Refill(0));
        }

        [Test]
        public void Refill_Minus12000()
        {
            AccumulationAccount AA1 = new AccumulationAccount(id: 1, client: "Ivanov", firstBalance: 12000, interestRate: 0.12);
            Assert.Throws<ArgumentOutOfRangeException>(() => AA1.Refill(-12000));
        }
        [Test]
        public void Refill_MaxDouble()
        {
            AccumulationAccount AA1 = new AccumulationAccount(id: 1, client: "Ivanov", firstBalance: double.MaxValue, interestRate: 0.12);
            Assert.Throws<ArgumentOutOfRangeException>(() =>AA1.Refill(double.MaxValue));
        }
        [Test]
        public void Refill_0_Plus_MaxDouble()
        {
            AccumulationAccount AA1 = new AccumulationAccount(id: 1, client: "Ivanov", firstBalance: 0, interestRate: 0.12);
            AA1.Refill(double.MaxValue);
            Assert.AreEqual(double.MaxValue, AA1.Balance, "Баланс счета неверный");
        }
        [Test]
        public void Refill_ArchivAccount()
        {
            AccumulationAccount AA1 = new AccumulationAccount(id: 1, client: "Ivanov", firstBalance: 0, interestRate: 0.12);
            AA1.CloseBankAccount();
            Assert.Throws<InvalidOperationException>(() => AA1.Refill(double.MaxValue));
        }
    }
}

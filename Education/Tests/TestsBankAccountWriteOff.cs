using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Education;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Tests
{
    [TestFixture]
    public class TestsBankAccountWriteOff
    {
        [Test]
        public void WriteOff_500()
        {
            CalculatedAccount CA1 = new CalculatedAccount(id: 1, client: "Ivanov", firstBalance: 12000, serviceCharge: 120);
            CA1.WriteOff(500);
            Assert.AreEqual(12000-500, CA1.Balance, "Баланс счета неверный");
        }
        [Test]
        public void WriteOff_12001()
        {
            AccumulationAccount AA1 = new AccumulationAccount(id: 1, client: "Ivanov", firstBalance: 12000, interestRate: 0.12);
            Assert.Throws<ArgumentOutOfRangeException>(() => AA1.WriteOff(12001));
        }
        [Test]
        public void WriteOff_MinDouble()
        {
            CalculatedAccount CA1 = new CalculatedAccount (id: 1, client: "Ivanov", firstBalance: 12000, serviceCharge: 120);
            Assert.Throws<ArgumentOutOfRangeException>(() => CA1.WriteOff(double.MinValue));
        }
        [Test]
        public void WriteOff_0()
        {
            CalculatedAccount CA1 = new CalculatedAccount(id: 1, client: "Ivanov", firstBalance: 12000, serviceCharge: 120);
            Assert.Throws<ArgumentOutOfRangeException>(() => CA1.WriteOff(0));
        }
        [Test]
        ///Cнять меньше, чем первоначальная сумма взона. Для накопительных банковсхи счетов
        /// 
        public void WriteOffAccumulationAccount()
        {
            AccumulationAccount AA1 = new AccumulationAccount(id: 1, client: "Ivanov", firstBalance: 12000, interestRate: 0.12);
            Assert.Throws<ArgumentOutOfRangeException>(() => AA1.WriteOff(500));
        }
        [Test]
        public void WriteOff_Sum_Equal_Balance()
        {
            CalculatedAccount CA1 = new CalculatedAccount(id: 1, client: "Ivanov", firstBalance: 12000, serviceCharge: 120);
            CA1.WriteOff(12000);
            Assert.AreEqual(0, CA1.Balance, "Баланс счета неверный");
        }
    }
}

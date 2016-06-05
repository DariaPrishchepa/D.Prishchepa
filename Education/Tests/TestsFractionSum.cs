using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Education;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Tests
{
    [TestFixture]
    public class TestsFractionSum
    {
        [Test]
        public void Sum_1()
        {
            SimpleFraction fr1 = new SimpleFraction(1, 2);
            SimpleFraction fr2 = new SimpleFraction(1, 2);
            SimpleFraction fr3 = fr1 + fr2;
            Assert.AreEqual(1, fr3.Numerator, "неверный числитель");
            Assert.AreEqual(1, fr3.Denominator, "неверный знаменатель");
        }
        [Test]
        public void Sum_2()
        {
            SimpleFraction fr1 = new SimpleFraction(0, 2);
            SimpleFraction fr2 = new SimpleFraction(0, 5);
            SimpleFraction fr3 = fr1 + fr2;
            Assert.AreEqual(0, fr3.Numerator, "неверный числитель");
            Assert.AreEqual(1, fr3.Denominator, "неверный знаменатель");
        }
        [Test]
        public void Sum_3()
        {
            SimpleFraction fr1 = new SimpleFraction(int.MaxValue, int.MaxValue);
            SimpleFraction fr2 = new SimpleFraction(0, 1);
            SimpleFraction fr3 = fr1 + fr2;
            Assert.AreEqual(1, fr3.Numerator, "неверный числитель");
            Assert.AreEqual(1, fr3.Denominator, "неверный знаменатель");
        }
        [Test]
        public void Sum_4()
        {
            SimpleFraction fr1 = new SimpleFraction(0, 1);
            SimpleFraction fr2 = new SimpleFraction(int.MaxValue, 1);
            SimpleFraction fr3 = fr1 + fr2;
            Assert.AreEqual(int.MaxValue, fr3.Numerator, "неверный числитель");
            Assert.AreEqual(1, fr3.Denominator, "неверный знаменатель");
        }
        [Test]
        public void Sum_5()
        {
            SimpleFraction fr1 = new SimpleFraction(int.MaxValue, 1);
            SimpleFraction fr2 = new SimpleFraction(5, 1);
            SimpleFraction fr3;
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                fr3 = fr1 + fr2;
            }) ;
        }
    }
}

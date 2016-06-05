using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Education;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Tests
{
    [TestFixture]
    public class Tests_Fraction_Division
    {
        [Test]
        public void Test_Division_1()
        {
            SimpleFraction fr1 = new SimpleFraction(3, 4);
            SimpleFraction fr2 = new SimpleFraction(3, 4);
            SimpleFraction fr3 = fr1 / fr2;
            Assert.AreEqual(1, fr3.Numerator, "неверный числитель");
            Assert.AreEqual(1, fr3.Denominator, "неверный знаменатель");
        }
        [Test]
        public void Test_Division_2()
        {
            SimpleFraction fr1 = new SimpleFraction(3, 4);
            SimpleFraction fr2 = new SimpleFraction(0, 4);
            SimpleFraction fr3;
            Assert.Throws<ArgumentNullException>(() =>
            {
                fr3 = fr1 / fr2;
            });
        }
        [Test]
        public void Test_Division_3()
        {
            SimpleFraction fr1 = new SimpleFraction(3, 4);
            SimpleFraction fr2 = new SimpleFraction(4, 3);
            SimpleFraction fr3 = fr1 / fr2;
            Assert.AreEqual(9, fr3.Numerator, "неверный числитель");
            Assert.AreEqual(16, fr3.Denominator, "неверный знаменатель");
        }
        [Test]
        public void Tests_Multiplication_5()
        {
            SimpleFraction fr1 = new SimpleFraction(int.MaxValue, 4);
            SimpleFraction fr2 = new SimpleFraction(3, 2);
            SimpleFraction fr3;
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                fr3 = fr1 / fr2;
            });
        }
        [Test]
        public void Test_Division_6()
        {
            SimpleFraction fr1 = new SimpleFraction(0, 4);
            SimpleFraction fr2 = new SimpleFraction(4, 3);
            SimpleFraction fr3 = fr1 / fr2;
            Assert.AreEqual(0, fr3.Numerator, "неверный числитель");
            Assert.AreEqual(1, fr3.Denominator, "неверный знаменатель");
        }

    }
}

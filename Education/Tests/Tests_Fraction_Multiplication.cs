using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Education;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Tests
{
    [TestFixture]
    public class Tests_Fraction_Multiplication
    {
        [Test]
        public void Tests_Multiplication_1()
        {
            SimpleFraction fr1 = new SimpleFraction(3, 4);
            SimpleFraction fr2 = new SimpleFraction(4, 3);
            SimpleFraction fr3 = fr1 * fr2;
            Assert.AreEqual(1, fr3.Numerator, "неверный числитель");
            Assert.AreEqual(1, fr3.Denominator, "неверный знаменатель");
        }
        [Test]
        public void Tests_Multiplication_2()
        {
            SimpleFraction fr1 = new SimpleFraction(0, 4);
            SimpleFraction fr2 = new SimpleFraction(4, 3);
            SimpleFraction fr3 = fr1 * fr2;
            Assert.AreEqual(0, fr3.Numerator, "неверный числитель");
            Assert.AreEqual(1, fr3.Denominator, "неверный знаменатель");
        }
        [Test]
        public void Tests_Multiplication_3()
        {
            SimpleFraction fr1 = new SimpleFraction(int.MaxValue, 1);
            SimpleFraction fr2 = new SimpleFraction(1, 1);
            SimpleFraction fr3 = fr1 * fr2;
            Assert.AreEqual(int.MaxValue, fr3.Numerator, "неверный числитель");
            Assert.AreEqual(1, fr3.Denominator, "неверный знаменатель");
        }
        [Test]
        public void Tests_Multiplication_4()
        {
            SimpleFraction fr1 = new SimpleFraction(int.MaxValue, 4);
            SimpleFraction fr2 = new SimpleFraction(2, 3);
            SimpleFraction fr3;
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                fr3 = fr1 + fr2;
            });
        }
    }
}


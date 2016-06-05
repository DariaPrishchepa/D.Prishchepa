using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Education;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Tests
{
    [TestFixture]
    public class Tests_Fraction_Constructor
    {
        [Test]
        public void FractionConstructor_Num2Den3()
        {
             SimpleFraction fr = new SimpleFraction(2, 3);
             Assert.NotNull(fr);
        }
        [Test]
        public void FractionConstructor_Num0Den6()
        {
            SimpleFraction fr = new SimpleFraction(0, 6);
            Assert.AreEqual(0,fr.Numerator, "неверный числитель");
            Assert.AreEqual(1, fr.Denominator, "неверный знаменатель");
        }
        [Test]
        public void FractionConstructor_Num0Den0()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new SimpleFraction(0, 0));
        }
        [Test]
        public void FractionConstructor_Num5DenMin10()
        {
            SimpleFraction fr = new SimpleFraction(5, -10);
            Assert.AreEqual(-1, fr.Numerator, "неверный числитель");
            Assert.AreEqual(2, fr.Denominator, "неверный знаменатель");
        }
        [Test]
        public void FractionConstructor_NumMin5DenMin10()
        {
            SimpleFraction fr = new SimpleFraction(-5, -10);
            Assert.AreEqual(1, fr.Numerator, "неверный числитель");
            Assert.AreEqual(2, fr.Denominator, "неверный знаменатель");
        }

    }
}

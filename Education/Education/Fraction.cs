using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
    public struct SimpleFraction : IComparable
    {
        //private int _denominator;
        public SimpleFraction(int numerator, int denominator)
        {
            try
            {
                if (denominator < 0)
                {
                    denominator = denominator * (-1);
                    numerator = numerator * (-1);
                    //throw new ArgumentOutOfRangeException($"значение знаменателя должно быть больше 0");
                }
                
                if (denominator == 0)
                {
                    throw new ArgumentOutOfRangeException("denominator", "Знаменатель должен быть больше нуля");
                }
                ReductionNewFraction(ref numerator, ref denominator);
                Numerator = numerator;
                Denominator = denominator;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Denominator = 1;
                Numerator = 0;
                Console.WriteLine($"Не удолось создать дробь. {ex.Message}");
                throw;
            }
        }
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public static void CheckMaxMinForSumMin(int tmp1, int tmp2)
        {
            if ((long) tmp1 + (long) tmp2 > int.MaxValue) throw new ArgumentOutOfRangeException();
            if ((long)tmp1 - (long)tmp2 < int.MinValue) throw new ArgumentOutOfRangeException();
        }
        public static void CheckMaxMinForMultiplication(int tmp1, int tmp2)
        {
            if ((long)tmp1 * (long)tmp2 > int.MaxValue) throw new ArgumentOutOfRangeException();
            if ((long)tmp1 * (long)tmp2 < int.MinValue) throw new ArgumentOutOfRangeException();
        }
        public static int gcd(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }
        public static void ReductionNewFraction(ref int Numerator, ref int Denominator)
        {
            int tmpReduction = gcd(Math.Abs(Numerator), Math.Abs(Denominator));
            Numerator /= tmpReduction;
            Denominator /= tmpReduction;
            // return new SimpleFraction(numerator,denominator);
        }
        public static SimpleFraction ReductionFraction(SimpleFraction fraction)
        {

            int tmpReduction = gcd(Math.Abs(fraction.Numerator), Math.Abs(fraction.Denominator));
            fraction.Numerator /= tmpReduction;
            fraction.Denominator /= tmpReduction;
            return fraction;
        }
        public static SimpleFraction ReductionDenominator(SimpleFraction fraction, int denominator)
        {
            CheckMaxMinForMultiplication(fraction.Numerator, denominator);
            CheckMaxMinForMultiplication(fraction.Denominator, denominator);
            int fractionNumerator = fraction.Numerator * denominator;
            int fractionDenominator = fraction.Denominator * denominator;
            SimpleFraction resultFraction = new SimpleFraction(0, 1);
            resultFraction.Numerator = fractionNumerator;
            resultFraction.Denominator = fractionDenominator;
            return resultFraction;
        }

        public static SimpleFraction operator +(SimpleFraction leftFraction, SimpleFraction rightFraction)
        {
            
            SimpleFraction reductionLeftFraction = ReductionDenominator(leftFraction, rightFraction.Denominator);
            SimpleFraction reductionRightFraction = ReductionDenominator(rightFraction, leftFraction.Denominator);
            CheckMaxMinForSumMin(reductionLeftFraction.Numerator, reductionRightFraction.Numerator);
            SimpleFraction ResultFraction = new SimpleFraction(reductionLeftFraction.Numerator + reductionRightFraction.Numerator, reductionLeftFraction.Denominator);
            return ReductionFraction(ResultFraction);
        }
        public static SimpleFraction operator -(SimpleFraction leftFraction, SimpleFraction rightFraction)
        {
            SimpleFraction reductionLeftFraction = ReductionDenominator(leftFraction, rightFraction.Denominator);
            SimpleFraction reductionRightFraction = ReductionDenominator(rightFraction, leftFraction.Denominator);
            CheckMaxMinForSumMin(reductionLeftFraction.Numerator , reductionRightFraction.Numerator);
            SimpleFraction ResultFraction = new SimpleFraction(reductionLeftFraction.Numerator - reductionRightFraction.Numerator, reductionLeftFraction.Denominator);
            return ReductionFraction(ResultFraction);
        }

        public static SimpleFraction operator *(SimpleFraction leftFraction, SimpleFraction rightFraction)
        {
            CheckMaxMinForMultiplication(leftFraction.Numerator, rightFraction.Numerator);
            CheckMaxMinForMultiplication(leftFraction.Denominator , rightFraction.Denominator);
            SimpleFraction ResultFraction = new SimpleFraction(leftFraction.Numerator * rightFraction.Numerator, leftFraction.Denominator * rightFraction.Denominator);
            return ReductionFraction(ResultFraction);
        }
        public static SimpleFraction operator /(SimpleFraction leftFraction, SimpleFraction rightFraction)
        {
            CheckMaxMinForMultiplication(leftFraction.Numerator , rightFraction.Numerator);
            CheckMaxMinForMultiplication(leftFraction.Denominator, rightFraction.Numerator);
            if (rightFraction.Numerator == 0) throw new ArgumentNullException("rightFraction.Numerator", "На нулевую дробь делить нельзя");
            SimpleFraction ResultFraction = new SimpleFraction(leftFraction.Numerator * rightFraction.Denominator, leftFraction.Denominator * rightFraction.Numerator);
            return ReductionFraction(ResultFraction);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public int CompareTo(object obj)
        {
            SimpleFraction fraction = (SimpleFraction)obj;
            fraction = ReductionDenominator(fraction, Denominator);
            if (fraction.Numerator < 0 && Numerator < 0)
            {
                if (Numerator > fraction.Numerator) return -1;
                if (Numerator < fraction.Numerator) return 1;
                return 0;
            }
            if (Numerator < fraction.Numerator) return -1;
            if (Numerator > fraction.Numerator) return 1;
            return 0;
        }
    }
}


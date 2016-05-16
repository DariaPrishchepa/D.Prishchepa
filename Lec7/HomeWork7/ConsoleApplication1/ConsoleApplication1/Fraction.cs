using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public struct SimpleFraction : IComparable
    {
        private int _denominator;
        public SimpleFraction(int numerator, int denominator) 
        {
            Numerator = numerator;
            if (denominator <= 0)
            {
                throw new ArgumentOutOfRangeException($"значение знаменателя должно быть больше 0");
            }
            _denominator = denominator;
        }
        public int Numerator { get; private set; }
        public int Denominator
        {
            get { return _denominator; }
            private set { _denominator = value; }
        }

        public static int gcd(int a, int b)
        {
            while (b != 0)
                    b = a%(a = b);
                return a;
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
            int fractionNumerator = fraction.Numerator*denominator;
            int fractionDenominator = fraction.Denominator*denominator;
            return new SimpleFraction(fractionNumerator, fractionDenominator);
        }
        
        public static SimpleFraction operator + (SimpleFraction leftFraction, SimpleFraction rightFraction)
        {
            SimpleFraction reductionLeftFraction = ReductionDenominator(leftFraction, rightFraction.Denominator);
            SimpleFraction reductionRightFraction = ReductionDenominator(rightFraction, leftFraction.Denominator);
            SimpleFraction ResultFraction = new SimpleFraction(reductionLeftFraction.Numerator + reductionRightFraction.Numerator, reductionLeftFraction.Denominator);
            return ReductionFraction(ResultFraction);
        }
        public static SimpleFraction operator - (SimpleFraction leftFraction, SimpleFraction rightFraction)
        {
            SimpleFraction reductionLeftFraction = ReductionDenominator(leftFraction, rightFraction.Denominator);
            SimpleFraction reductionRightFraction = ReductionDenominator(rightFraction, leftFraction.Denominator);
            SimpleFraction ResultFraction = new SimpleFraction(reductionLeftFraction.Numerator - reductionRightFraction.Numerator, reductionLeftFraction.Denominator);
            return ReductionFraction(ResultFraction);
        }

        public static SimpleFraction operator *(SimpleFraction leftFraction, SimpleFraction rightFraction)
        {
            SimpleFraction ResultFraction = new SimpleFraction(leftFraction.Numerator * rightFraction.Numerator, leftFraction.Denominator * rightFraction.Denominator);
            return ReductionFraction(ResultFraction);
        }
        public static SimpleFraction operator /(SimpleFraction leftFraction, SimpleFraction rightFraction)
        {
            ////0
            SimpleFraction ResultFraction = new SimpleFraction(leftFraction.Numerator * rightFraction.Denominator, leftFraction.Denominator * rightFraction.Numerator);
            return ReductionFraction(ResultFraction);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public int CompareTo(object obj)
        {
            SimpleFraction fraction = (SimpleFraction) obj;
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

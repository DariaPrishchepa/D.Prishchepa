using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Education;

namespace Lec12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            //int[] mass = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //var filterMass = mass.Where(u=> u%2 == 0 || u>5)
            //                        .OrderByDescending(u => u);
            //foreach (var tmp in filterMass)
            //{
            //    Console.Write($"{tmp}\t");
            //}

            List<SimpleFraction> fractionList = new List<SimpleFraction>();
            for (int i = 0; i < 20; i++)
            {
                fractionList.Add(new SimpleFraction(rand.Next(0,100),rand.Next(1,100)));
            }
            for(int i = 0; i < 20; i++)
            {
                Console.Write($"{fractionList[i]}\t");
            }
            var filterFractionList = fractionList.Where(tmp => tmp.Denominator == 1);

            foreach(var tmp in filterFractionList)
            {
                Console.Write($"{tmp.Numerator}\t");
            }

        }
    }
}

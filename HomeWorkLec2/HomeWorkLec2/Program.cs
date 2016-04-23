using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLec2
{
    class Program
    {
        static void MySearch (int[] mass, int x)
        {
            int left = 0;
            int right = mass.Length;
            int mid;

            if (right == 0)  Console.WriteLine("в массиве нет элементов");
            if (mass[0] > x)  Console.WriteLine("искомое число меньше всех элементов в массиве");
            if (x > mass[right-1]) Console.WriteLine("искомое число больше всех элементов в массиве");

            while (left < right)
            {
                mid = left + Convert.ToInt32((right - left)/2);
                if (mass[mid] >= x) right = mid;
                else left = mid + 1;
            }
            Console.WriteLine(mass[right] != x ? "No" : "Yes");

        }
        static void Main(string[] args)
        {
            //////////Episode I
            int N = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[N];
            int tmp;
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                mass[i] = rand.Next(100);
            }
            for (int i = 0; i < N; i++)
                Console.Write("{0}\t", mass[i]);

            Console.WriteLine("Введите число:");
            Array.Sort(mass);
            tmp = Convert.ToInt32(Console.ReadLine());
            MySearch(mass, tmp);

            /////////Episode II
            Console.WriteLine("Введите число n и m:");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] mass2 = new int[n, m];
            int min;
            int[] MassMin = new int[n];
            for (int i = 0; i < n; i++)
            {
                min = 101;
                for (int j = 0; j < m; j++)
                {
                    mass2[i, j] = rand.Next(100);
                    if (min > mass2[i, j]) min = mass2[i, j];
                }
                MassMin[i] = min;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} \t", mass2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Array.Sort(MassMin);
            for (int i = n-1; i >= 0; i++)
                Console.Write("{0} \t", MassMin[i]);

            ////////Episode III
            Console.WriteLine("введите выражение вида: 4 + 5");
            string op = Console.ReadLine();
            string[] operand = op.Split(' ');
            int k = 0;
            double t;
            foreach (string s in operand)
            {

                if (s.Trim() != "")
                    operand[k] = s;
                    k++;
            }
            
            switch (operand[1])
            {
                case "+":
                    t = Convert.ToInt32(operand[0]) + Convert.ToInt32(operand[2]);
                    Console.WriteLine("{0} + {1} = {2}", operand[0], operand[2], t);
                    break;
                case "-":
                    t = Convert.ToInt32(operand[0]) - Convert.ToInt32(operand[2]);
                    Console.WriteLine("{0} - {1} = {2}", operand[0], operand[2], t);
                    break;
                case "*":
                    t = Convert.ToInt32(operand[0]) * Convert.ToInt32(operand[2]);
                    Console.WriteLine("{0} * {1} = {2}", operand[0], operand[2], t);
                    break;
                case "/":
                    if (operand[2] == "0")
                    {
                        Console.WriteLine("Exseption");
                        break;
                    }
                    t = Convert.ToDouble(operand[0]) / Convert.ToDouble(operand[2]);
                        Console.WriteLine("{0} / {1} = {2}", operand[0], operand[2], t);
                        break;
            }
        }
    }
}

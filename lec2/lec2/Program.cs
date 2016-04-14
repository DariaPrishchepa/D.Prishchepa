using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec2
{
    class Program
    {

        static bool chet(int x)
        {
            if ((x & 1) == 1) return false;
            return true;
        }

        static void WriteMass(int M,int [,] a)
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write("\t{0}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            ///////////////////////////////Part I
            Console.WriteLine("N:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];

            int sum = 0;
            int k = 0;
            int p = 1;

            Console.Write("Введите {0} чисел:\n", n);

            for (int i = 0; i < n; i++)
            {
                mass[i] = Convert.ToInt32(Console.ReadLine());
                sum += mass[i];
                if (chet(mass[i])) k++;
                else p *= mass[i];
            }
            Array.Sort(mass);
            Console.WriteLine("задание 1: Сумма чисел ={0}, максимальное {1}, минимальное {2}, количество четных:{3}, произведение нечетных:{4}", sum, mass[n - 1], mass[0], k, p);
            Console.WriteLine("Ввывод отсортированного массива:");
            for (int i = 0; i < 0; i++)
                Console.WriteLine(mass[i]);

            ////////////////////////////////Part II
            Console.WriteLine();
            Console.WriteLine("M:");
            int M = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[,] mass1 = new int[M, M];
            int[,] mass2 = new int[M, M];
            int[,] mass3 = new int[M, M];

            for (int i=0; i < M; i++)
                for (int j = 0; j < M; j++)
                {
                    mass1[i, j] = rand.Next(100);
                    mass2[i, j] = rand.Next(100);
                    mass3[i, j] = mass1[i, j] + mass2[i, j];
                }
            WriteMass(M, mass1);
            WriteMass(M, mass2);
            WriteMass(M, mass3);
        }
    }
}

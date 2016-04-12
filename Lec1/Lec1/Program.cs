using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Ввести с консоли 2 числа: n и i. Вывести их сумму на консоль");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int sum = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine(sum);
            Console.ReadLine();
            //2
            Console.WriteLine("Ввести с консоли 2 числа: n и i. Вывести значение i-ого бита числа n");
            string n = Console.ReadLine();
            string i = Console.ReadLine();
            byte N = Convert.ToByte(n);
            byte I = Convert.ToByte(i);

            int result1 = (N >> I) & 1;
            Console.WriteLine(result1);
            //3
            Console.WriteLine("Ввести с консоли число. Обнулить последний бит этого числа. Вывести на консоль");
            string m = Console.ReadLine();
            byte X = Convert.ToByte(m);
            int result2 = X & 1111110;
            Console.WriteLine(result2);
        }
    }
}

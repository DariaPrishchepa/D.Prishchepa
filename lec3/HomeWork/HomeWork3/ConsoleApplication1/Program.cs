using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int MyCount(string S, char symbol)
        {
            String[] temp = S.Split(new char[] { symbol }, StringSplitOptions.None);
            return temp.Length - 1;
        }

        static void Main(string[] args)
        {
///////Part1
            string str = Console.ReadLine();
            int s;
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            List< int > mass = new List<int>();
            HashSet<int> dudHashSet = new HashSet<int>();

            for (int i = 0; i < str.Length;)
            {
                dictionary.Add(str[i], MyCount(str, str[i]));
                str = str.Replace(Convert.ToString(str[i]), "");
            }

            
            foreach (KeyValuePair<char, int> kvp in dictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
///////Part2
            while (true)
            {
                s = Convert.ToInt32(Console.ReadLine());
                if (s != -1)
                {
                    mass.Add(s);
                 }
                else break;
            }

            for (int i = 0; i < mass.Count; i++)
            {
                s = 0;
                for (int j = 0; j < mass.Count; j++)
                {
                    if (i != j)
                    {
                        if (mass[i] == mass[j]) s++;
                        if (s > 0)
                        {
                            dudHashSet.Add(mass[i]);
                            break;
                        }
                    }
                }
            }

            foreach (int i in dudHashSet)
            {
             Console.Write("{0}\t", i);   
            }

        }
    }
}

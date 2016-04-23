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
        
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int lenght = str.Length;
            int tmp = 0;
            int s;
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            Dictionary<int, int> mass = new Dictionary<int, int>();
            HashSet<int> dudHashSet = new HashSet<int>();


            foreach (char c in str)
            {
                dictionary.Add(c, lenght);
            }
            
            foreach (KeyValuePair<char, int> kvp in dictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            while (true)
            {
                s = Convert.ToInt32(Console.ReadLine());
                if (s != -1)
                {
                    mass.Add(tmp, s);
                    tmp++;
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

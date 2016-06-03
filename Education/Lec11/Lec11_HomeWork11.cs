using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec11
{
    public static class Lec11_HomeWork11
    {
        public static void WriteMass(this int[] a)
        {
            if (a == null) throw new ArgumentNullException();
            foreach (var tmp in a)
            {
                Console.WriteLine(tmp);
            }
        }
        /// <summary>
        /// HomeWork 11
        /// </summary>
        /// <param name="a"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string AddStringSeparator(this int[] a, string str)
        {
            string resultString = string.Empty;
            if (a == null) throw new ArgumentNullException();
            foreach (var tmp in a)
            {
                resultString += Convert.ToString(tmp) + str;
                // Console.Write($"{tmp}{str}");
            }
            return resultString;
        }
    }
}

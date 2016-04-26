using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec4
{
    class Program
    {
        static void Main(string[] args)
        {
            Telephone police = new Telephone("002");
            Console.WriteLine(police.GetTelephone());
        }
    }
}

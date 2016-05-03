using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec5
{
    class Program
    {
        static void Main(string[] args)
        {
            IP BusinessWomen = new IP(id : 1, phone: "111-11-1", sumOrder: 12000, fio: "Marfa Petrovna", data: "01.05.2016");
            OOO Romashka = new OOO(id: 1, phone: "222-22-2", sumOrder: 2000000, nameOrg: "Romashka", bankC: 1231231231234);

            Console.WriteLine(Romashka.BankC);
            Console.WriteLine(Romashka.Id);
            Console.WriteLine(Romashka.Info());
            Console.ReadLine();

        }
    }
}

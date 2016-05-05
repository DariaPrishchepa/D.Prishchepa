using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            AccumulationAccount AA1 = new AccumulationAccount(id: 1, client: "Ivanov", firstBalance: 120000, interestRate: 0.12);
            //Console.WriteLine($"Balance: {AA1.Balance}");
            //Console.WriteLine($"Client: {AA1.Client}");
            //AA1.Refill(100);
            //AA1.Refill(200000);
            //Console.WriteLine($"Refill: 200000{AA1.Balance}");
            //AA1.WriteOff(100);
            //AA1.WriteOff(200000);
            //Console.WriteLine($"WriteOff: 200000 {AA1.Balance}");
            //AA1.WriteOff(200000);
            //Console.WriteLine($"WriteOff: {AA1.Balance}");
            //AA1.CloseBankAccount();
            //Console.WriteLine($"CloseBankAccount : {AA1.Status}");
            //AA1.WriteOff(200000);
            Console.WriteLine($"CloseBankAccount : {AA1.Status}");
            //AA1.Capitalization();
            //Console.WriteLine($"CloseBankAccount : {AA1.DateCapitalization}");
            

            //MetalAccount MA1 = new MetalAccount(id: 1, client: "Ivanov", firstBalance:1200*100, type: "Ag" , metalCosts: 1200, theNomberOfGrams: 100 );
        }
    }
}

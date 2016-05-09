using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            AccumulationAccount AA1 = new AccumulationAccount(id: 1, client: "Ivanov", firstBalance: 120000, interestRate: 0.12);
            AccumulationAccount AA2 = new AccumulationAccount(id: 2, client: "Ivanov", firstBalance: 120000, interestRate: 0.12);
            MetalAccount MA1 = new MetalAccount(id: 3, client: "Ivanov", firstBalance: 1200 * 100, type: "Ag", metalCosts: 1200, theNomberOfGrams: 100);

            BasicBankClient myBankClient = new BasicBankClient(1);

            myBankClient.AddAccount(AA1);
            myBankClient.AddAccount(AA2);

            Console.WriteLine($"CloseBankAccount : {myBankClient.SumAllAccounts}");
            Console.WriteLine($"2 : {myBankClient.CountBankAccount()}");

            myBankClient.AddAccount(MA1);
            Console.WriteLine($"3 : {myBankClient.CountBankAccount()}");
            Console.WriteLine($"CloseBankAccount : {myBankClient.SumAllAccounts}");

            AccumulationAccount AA3 = new AccumulationAccount(id: 1, client: "Ivanov", firstBalance: 120000, interestRate: 0.12);
            myBankClient.AddAccount(AA3);
            Console.WriteLine($"4 : {myBankClient.CountBankAccount()}");
            Console.WriteLine($"CloseBankAccount : {myBankClient.SumAllAccounts}");

            Bank MyBank = new Bank();
            Console.WriteLine($"ma1 : {MA1.Balance}");
            Console.WriteLine($"AA1 : {AA1.Balance}");
            Console.WriteLine($" TranslationBetweenAccounts: {MyBank.TranslationBetweenAccounts(AA1, MA1, 200)}");
            Console.WriteLine($"ma1 : {MA1.Balance}");
            Console.WriteLine($"AA1 : {AA1.Balance}");

            myBankClient.WriteAccounts();
            myBankClient.CloseAccount(1);

            AccumulationAccount AA4 = new AccumulationAccount(id: 4, client: "Ivanov", firstBalance: 120000, interestRate: 0.12);
            myBankClient.AddAccount(AA4);
            myBankClient.WriteAccounts();
            Console.WriteLine($"CloseBankAccount : {AA1.Status}");
        }
    }
}


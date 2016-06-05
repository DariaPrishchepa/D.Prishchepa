using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
    class Program
    {
        static int gcd(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }

        static void Main(string[] args)
        {

            Random rand = new Random();
            AccumulationAccount AA1 = new AccumulationAccount(id: 1, client: "Ivanov", firstBalance: 120000, interestRate: 0.12);
            AA1.WriteOff(-1200);
            Console.WriteLine($"3 : {AA1.Balance}");
            //AccumulationAccount AA2 = new AccumulationAccount(id: 2, client: "Ivanov", firstBalance: 120000, interestRate: 0.12);
            //MetalAccount MA1 = new MetalAccount(id: 3, client: "Ivanov", firstBalance: 1200 * 100, type: "Ag", metalCosts: 1200, theNomberOfGrams: 100);

            //BasicBankClient myBankClient = new BasicBankClient(1);

            //myBankClient.AddAccount(AA1);
            //myBankClient.AddAccount(AA2);

            //Console.WriteLine($"CloseBankAccount : {myBankClient.SumAllAccounts}");
            //Console.WriteLine($"2 : {myBankClient.CountBankAccount()}");

            //myBankClient.AddAccount(MA1);
            //Console.WriteLine($"3 : {myBankClient.CountBankAccount()}");
            //Console.WriteLine($"CloseBankAccount : {myBankClient.SumAllAccounts}");

            //AccumulationAccount AA3 = new AccumulationAccount(id: 1, client: "Ivanov", firstBalance: 120000, interestRate: 0.12);
            //myBankClient.AddAccount(AA3);
            //Console.WriteLine($"4 : {myBankClient.CountBankAccount()}");
            //Console.WriteLine($"CloseBankAccount : {myBankClient.SumAllAccounts}");

            //Bank MyBank = new Bank();
            //Console.WriteLine($"ma1 : {MA1.Balance}");
            //Console.WriteLine($"AA1 : {AA1.Balance}");
            //Console.WriteLine($" TranslationBetweenAccounts: {MyBank.TranslationBetweenAccounts(AA1, MA1, 200)}");
            //Console.WriteLine($"ma1 : {MA1.Balance}");
            //Console.WriteLine($"AA1 : {AA1.Balance}");

            //myBankClient.WriteAccounts();
            //myBankClient.CloseAccount(1);

            //AccumulationAccount AA4 = new AccumulationAccount(id: 4, client: "Ivanov", firstBalance: 120000, interestRate: 0.12);
            //myBankClient.AddAccount(AA4);
            //myBankClient.WriteAccounts();
            //Console.WriteLine($"CloseBankAccount : {AA1.Status}");

            //SimpleFraction fr = new SimpleFraction(2, 3);
            //Console.WriteLine($"2/3: {fr.Numerator}/{fr.Denominator}");

            //SimpleFraction fr1 = new SimpleFraction(2, 0);
            //Console.WriteLine($"2/0: {fr1.Numerator}/{fr1.Denominator}");
            //Console.WriteLine($"27/9:  {gcd(13, 17)}");
            //Console.WriteLine($"9/27:  {gcd(17, 13)}");

            //SimpleFraction fr1 = new SimpleFraction(3, -5);
            //SimpleFraction fr2 = new SimpleFraction(-3, 7);
            //SimpleFraction fr3 = new SimpleFraction(1, 2);
            //Console.WriteLine($"3/5+3/7:  {fr1 + fr2}");
            //Console.WriteLine($"3+7:  {3+7}");
            //Console.WriteLine($"3/5-3/7:  {fr1 - fr2}");
            //Console.WriteLine($"3/5-3/5:  {fr1 - fr1}");
            //Console.WriteLine($"3/7-3/5:  {fr2 - fr1}");
            //Console.WriteLine($"3/5*3/7:  {fr1 * fr2}");
            //Console.WriteLine($"3/5:3/5:  {fr1 / fr1}");
            //Console.WriteLine($"3/5:3/7:  {fr1 / fr2}");
            //Console.WriteLine($"3/7:3/5:  {fr2 / fr1}");
            ////int N = 5;
            ////List<SimpleFraction> fractions = new List<SimpleFraction>();
            ////fractions.Add(fr1);
            ////Console.WriteLine($"3/7:3/5:  {fr2 / fr3}");

            //SimpleFraction fr4 = new SimpleFraction(6, 0);


            //SimpleFraction fr1 = new SimpleFraction(3, -5);
            //SimpleFraction fr2 = new SimpleFraction(-3, 7);
            //SimpleFraction fr3 = new SimpleFraction(1, 2);
            //Console.WriteLine($"3/5+3/7:  {fr1 + fr2}");
            //Console.WriteLine($"3+7:  {3 + 7}");
            ////SimpleFraction fr5 = new SimpleFraction(3, 8);
            ////Console.WriteLine($"4/8:  {fr4 }");
            //SimpleFraction sum = new SimpleFraction(0, 1);
            //for (int i = 0; i < N; i++)
            //{
            //    fractions.Add(new SimpleFraction(rand.Next(20),rand.Next(20)));
            //    sum += fractions[i];
            //    Console.WriteLine($"{fractions[i]} sum = {sum}");
            //}
            //fractions.Sort();

            //for (int i = 0; i < fractions.Count; i++)
            //{
            //    Console.Write($"{fractions[i]} \t");
            //}

        }
    }
}

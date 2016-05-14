using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Bank
    {
        public bool TranslationBetweenAccounts(BankAccount refillAccount, BankAccount writeOffBankAccount, double summ)
        {
            if (writeOffBankAccount.WriteOff(summ))
            {
                if (refillAccount.Refill(summ)) return true;

                writeOffBankAccount.Refill(summ);
                Console.WriteLine($"не получилось выполнить операцию перевода");
                return false;
            }
            Console.WriteLine($"не получилось выполнить операцию перевода");
            return false;
        }
    }
}

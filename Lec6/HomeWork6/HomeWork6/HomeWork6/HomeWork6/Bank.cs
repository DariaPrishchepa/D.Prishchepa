using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Bank
    {
        public bool TranslationBetweenAccounts(BankAccount from, BankAccount to, double summ)
        {
            if (to.WriteOff(summ))
            {
                if (from.Refill(summ)) return true;
                else
                {
                    to.Refill(summ);
                    Console.WriteLine($"не получилось выполнить операцию перевода");
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"не получилось выполнить операцию перевода");
                return false;
            }
        }
        public Bank() { }
    }
}

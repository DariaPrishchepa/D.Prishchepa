using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
    public class Bank
    {
        public void TranslationBetweenAccounts(BankAccount refillAccount, BankAccount writeOffBankAccount, double summ)
        {
            try
            {
                writeOffBankAccount.WriteOff(summ);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"не получилось выполнить операцию перевода. {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"не получилось выполнить операцию перевода. {ex.Message}");
            }
            try
            {
                refillAccount.Refill(summ);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                writeOffBankAccount.Refill(summ);
                Console.WriteLine($"не получилось выполнить операцию перевода. {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                writeOffBankAccount.Refill(summ);
                Console.WriteLine($"не получилось выполнить операцию перевода. {ex.Message}");
            }
        }
    }
}

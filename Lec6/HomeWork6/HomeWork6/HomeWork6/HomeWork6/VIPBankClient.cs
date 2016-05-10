using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class VIPBankClient : BankClient
    {
        public VIPBankClient(int idAccount) : base(idAccount) { }

        public override void AddAccount(BankAccount bankAccount)
        {
            if (CountBankAccount() < 10)
            {
                base.AddAccount(bankAccount);
            }
            else Console.WriteLine($"невозможно добавить еще один банковский счет (максимально возможное количество счетов для VIP клиена = 10)");
        }
    }
}

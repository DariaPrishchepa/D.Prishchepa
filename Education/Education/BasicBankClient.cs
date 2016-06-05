using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
    class BasicBankClient : BankClient
    {
        public BasicBankClient(int idAccount) : base(idAccount) { }

        public override void AddAccount(BankAccount bankAccount)
        {
            if (CountBankAccount() < 3)
            {
                base.AddAccount(bankAccount);
            }
            throw new ArgumentException($"невозможно добавить еще один банковский счет (максимально возможное количество счетов для VIP клиена = 3)");
        }
    }
}

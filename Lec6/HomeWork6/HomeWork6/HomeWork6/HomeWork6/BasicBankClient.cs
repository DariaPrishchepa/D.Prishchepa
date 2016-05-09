using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class BasicBankClient : BankClient
    {
        public BasicBankClient(int idAccount) : base(idAccount) { }

        public override void AddAccount(BankAccount BA)
        {
            if (CountBankAccount() < 3)
            {
                base.AddAccount(BA);
            }
            else Console.WriteLine($"невозможно добавить еще один банковский счет (максимально возможное количество счетов для базоваого клиена = 3)");
        }
    }
}

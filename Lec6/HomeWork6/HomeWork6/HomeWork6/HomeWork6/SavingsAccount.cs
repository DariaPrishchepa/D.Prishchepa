using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class SavingsAccount : BankAccount
    {
        //сберегательный - возможность пополнения и изъятия денег со счета
        public SavingsAccount(int id, string client, double firstBalance) : base(id, client, firstBalance) { }
    }
}

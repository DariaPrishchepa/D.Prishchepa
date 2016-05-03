using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class CalculatedAccount: BankAccount
    {
        //расчетный - возможность пополнения и изъятия денег со счета, наличие платы за обслуживание, списание суммы за обслуживание со счета
        public static double ServiceСharge { get; set;}

        public CalculatedAccount(int id, string client, double firstBalance, double serviceCharge) : base(id, client, firstBalance)
        {
            ServiceСharge = serviceCharge;
        }

        public void ServiceСhargeWriteOff()
        {
            base.WriteOff(ServiceСharge);
        }

    }
}

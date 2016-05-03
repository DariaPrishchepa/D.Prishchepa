using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec5
{
    class OOO : Client
    {
        public OOO(int id, string phone, int sumOrder, string nameOrg, long bankC) : base(id, phone, sumOrder)
        {
            NameOrg = nameOrg;
            BankC = bankC;
        }

        public string NameOrg { get; set; }
        public long BankC { get; set; }

        public override string Info()
        {
            return $"Название организации: ООО {NameOrg}, сумма заказа: {SumOrder:F2} рублей";
        }
    }
}

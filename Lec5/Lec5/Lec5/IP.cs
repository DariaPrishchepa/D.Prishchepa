using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec5
{
    class IP : Client
    {

        public IP(int id, string phone, int sumOrder,string fio, string data) : base(id, phone, sumOrder)
        {
            FIO = fio;
            Data = data;
        }

        public string FIO { get; set; }
        public string Data { get; set; }

        public override string Info()
        {
            return $"ИП: {FIO}, сумма заказа: {SumOrder:F2} рублей";
        }
    }
}

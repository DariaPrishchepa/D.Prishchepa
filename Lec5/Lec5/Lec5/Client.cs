using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec5
{
    class Client
    {
        public Client(int id, string phone, int sumOrder)
        {
            Id = id;
            Phone = phone;
            SumOrder = sumOrder;
        }

        public int Id { get; }

        public string Phone { get; set;}

        public double SumOrder { get; set;}

        public virtual string Info()
        {
            return $"id: {Id}, SumOrder: {SumOrder}";
        }


    }
}

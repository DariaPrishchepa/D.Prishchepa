using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec5
{
    class Client
    {
        readonly int _id;
        private string _phone;
        private int _sumOrder;

        public Client(int id, string phone, int sumOrder)
        {
            _id = id;
            _phone = phone;
            _sumOrder = sumOrder;
        }

        public int Id { get; }

        public string Phone { get; set;}

        public int SumOrder { get; set; }

    }
}

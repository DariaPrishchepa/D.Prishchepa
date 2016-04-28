using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec5
{
    class IP : Client
    {
        private string _fio;
        private string _data;

        public string FIO { get; set; }
        public string Data { get; set; }

        public IP(int id, string phone, int sumOrder,string fio, string data) : base(id, phone, sumOrder)
        {
            _fio = fio;
            _data = data;
        }
    }
}

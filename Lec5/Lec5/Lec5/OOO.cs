using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec5
{
    class OOO : Client
    {
        private string _nameOrg ;
        private long _bankC;

        public string NameOrg { get; set; }
        public string BankC { get; set; }

        public OOO(int id, string phone, int sumOrder, string nameOrg, long bankC) : base(id, phone, sumOrder)
        {
            _nameOrg = nameOrg;
            _bankC = bankC;
        }
    }
}

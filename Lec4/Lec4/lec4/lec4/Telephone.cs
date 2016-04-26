using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec4
{
    class Telephone
    {
        readonly string Code;
        readonly string Number;

        public string GetTelephone()
        {
            return Code == string.Empty ? Number : $"({Code}){Number}";
        }

        public Telephone(string code, string number)
        {
            Number = number;
            Code = code;
        }

        public Telephone( string number)
        {
            Number = number;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class AccumulationAccount : BankAccount
    {
        //накопительный - возможность пополнения и изъятия денег со счета, но не меньше первоначального взноса, наличие процентной ставки, капитализация процентов за месяц

        private DateTime _dateCapitalization = DateTime.Today.AddMonths(1);

        public DateTime DateCapitalization
        {
            get { return _dateCapitalization; }
            //set { _dateCapitalization = value; }
        }

        public double InterestRate { get; }

        public AccumulationAccount(int id, string client, double firstBalance, double interestRate) : base(id, client, firstBalance)
        {
            InterestRate = interestRate;
        }

        public override bool WriteOff(double sum)
        {
            if (sum >= FirstBalance)
            {
                if (base.WriteOff(sum)) return true;
                return false;
            }
            else Console.WriteLine($"недостаточная сумма для вывода со счета");
            return false;
        }

        public bool RefillInterestRate()
        {
            double summInterestRate = Balance * InterestRate;
            if (base.Refill(summInterestRate)) return true;
            return false;
        }

        public virtual void Capitalization()
        {
            if (DateEnd.AddMonths(1).CompareTo(DateCapitalization) >= 0)
            {
                DateTime date = DateTime.Today;
                //DateTime date1 = new DateTime(2016, 6, 4);
                //Console.WriteLine($"{date1}");

                if (DateCapitalization.CompareTo(date) == 0)
                {
                    RefillInterestRate();
                    _dateCapitalization = _dateCapitalization.AddMonths(1);
                }
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class AccumulationAccount: BankAccount
    {
        //накопительный - возможность пополнения и изъятия денег со счета, но не меньше первоначального взноса, наличие процентной ставки, капитализация процентов за месяц

        private DateTime _dateCapitalization = DateOpen.AddMonths(1);

        public DateTime DateCapitalization
        {
            get { return _dateCapitalization; }
            set { _dateCapitalization = value; }
        }
        
        public double InterestRate {get;}

        public AccumulationAccount(int id, string client, double firstBalance, double interestRate ): base(id, client, firstBalance)
        {
            InterestRate = interestRate;
        }

        public override void Refill(double sum)
        {
            if (sum >= FirstBalance)
            {
                base.Refill(sum);
            }
            else Console.WriteLine($"недостаточная сумма для внесения на счет");
        }

        public override void WriteOff(double sum)
        {
            if (sum >= FirstBalance)
            {
                base.WriteOff(sum);
            }
            else Console.WriteLine($"недостаточная сумма для вывода со счета");
        }

        public void RefillInterestRate()
        {
            double summInterestRate = Balance * InterestRate;
            base.Refill(summInterestRate);
        }

        public virtual void Capitalization()
        {
            while (DateEnd.AddMonths(1).CompareTo(DateCapitalization) >= 0)
                {
                    DateTime date = DateTime.Today;
                    if (DateCapitalization.CompareTo(date) == 0)
                    {
                        RefillInterestRate();
                        DateCapitalization.AddMonths(1);
                    }
                }
         }
    }
}

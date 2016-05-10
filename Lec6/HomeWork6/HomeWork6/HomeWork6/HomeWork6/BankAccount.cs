using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class BankAccount
    {

        //Реализовать классы для управления банковскими счетами. Каждый счет должен иметь номер, владельца, текущую сумму на счету не меньше нуля.  
        //Реализовать метод закрытия счета. С закрытым счетом нельзя проводить никакие операции. Счет не может быть закрыт, если он имеет положительный баланс.

        public int Id { get; }
        public string Client { get; set; }
        private double _firstBalance;
        private double _balance;
        readonly DateTime _dateOpen = DateTime.Today;
        readonly DateTime _dateEnd = DateTime.Today.AddYears(2);
        //private string _status = "Activ";

        internal enum StatusBankAccount { Activ, Archiv }
        StatusBankAccount _status = StatusBankAccount.Activ;

        public StatusBankAccount Status
        {
            get { return _status; }
        }

        public DateTime DateOpen
        {
            get { return _dateOpen; }
        }

        public DateTime DateEnd
        {
            get { return _dateEnd; }

        }

        public double FirstBalance
        {
            get { return _firstBalance; }
        }

        public double Balance
        {
            get { return _balance; }
            //set { _balance = value; }
        }

        public BankAccount(int id, string client, double firstBalance)
        {
            Id = id;
            Client = client;
            _balance = firstBalance;
            _firstBalance = firstBalance;
        }
        public BankAccount(int id, string client)
        {
            Id = id;
            Client = client;
        }


        public virtual bool Refill(double sum)
        {
            if (sum > 0)
            {
                if (Status != StatusBankAccount.Archiv)
                {
                    _balance = Balance + sum;
                    return true;
                }
                else
                {
                    Console.WriteLine($"Счет закрыт. С закрытым счетом нельзя проводить никакие операции.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"Некорректная сумма.");
                return false;
            }
        }

        public virtual bool WriteOff(double sum)
        {
            if (sum > 0)
            {
                if (Status != StatusBankAccount.Archiv)
                {
                    if ((Balance - sum) >= 0)
                    {
                        _balance = Balance - sum;
                        return true;
                    }
                    Console.WriteLine($"При выводе со счета {sum} останется отрицательный баланс, операция невозможна");
                    return false;
                }
                Console.WriteLine($"Счет закрыт. С закрытым счетом нельзя проводить никакие операции.");
                return false;
            }
            Console.WriteLine($"Некорректная сумма.");
            return false;
        }

        public virtual void CloseBankAccount()
        {
            if (Balance >= 0)
            {
                if (Balance > 0)
                    WriteOff(Balance);

                _status = StatusBankAccount.Archiv;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public class BankAccount
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

        public enum StatusBankAccount { Activ, Archiv }
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
            try
            {
                Id = id;
                Client = client;
                _balance = firstBalance;
                _firstBalance = firstBalance;
            }
            catch (Exception)
            {
                Console.WriteLine($"Не удалось создать банковский счет");
            }
            
        }
        public BankAccount(int id, string client)
        {
            Id = id;
            Client = client;
        }


        public virtual void Refill(double sum)
        {
            if (sum <= 0) throw new ArgumentOutOfRangeException("sum", "Сумма должна быть больше нуля");
            if (Status == StatusBankAccount.Archiv) throw new InvalidOperationException($"Счет закрыт. С закрытым счетом нельзя проводить никакие операции.");
            _balance = Balance + sum;
        }

        public virtual void WriteOff(double sum)
        {
            if (sum <= 0) throw  new ArgumentOutOfRangeException("sum","Сумма должна быть больше нуля");
            if (Status == StatusBankAccount.Archiv) throw new InvalidOperationException($"Счет закрыт. С закрытым счетом нельзя проводить никакие операции.");
            if ((Balance - sum) < 0) throw new ArgumentOutOfRangeException("Balance", $"При выводе со счета {sum} останется отрицательный баланс, операция невозможна");

            _balance = Balance - sum;
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

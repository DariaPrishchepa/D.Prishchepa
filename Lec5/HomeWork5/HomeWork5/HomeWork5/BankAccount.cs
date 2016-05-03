using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class BankAccount
    {
        
       //Реализовать классы для управления банковскими счетами. Каждый счет должен иметь номер, владельца, текущую сумму на счету не меньше нуля.  
       //Реализовать метод закрытия счета. С закрытым счетом нельзя проводить никакие операции. Счет не может быть закрыт, если он имеет положительный баланс.
       
        public int Id { get;}
        public string Client { get; set;}
        private static double _firstBalance;
        private double _balance;
        static readonly DateTime _dateOpen = DateTime.Today;
        static readonly DateTime _dateEnd = DateOpen.AddYears(2);
        public string Status { get; set; } = "Activ";
        

        public static DateTime DateOpen
        {
            get { return _dateOpen; }
        }

        public static DateTime DateEnd
        {
            get { return _dateEnd; }

        }

        public static double FirstBalance
        {
            get { return _firstBalance; }
            set { _firstBalance = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public BankAccount(int id, string client, double firstBalance)
        {
            Id = id;
            Client = client;
            Balance = firstBalance;
            _firstBalance = firstBalance;
        }
        public BankAccount(int id, string client)
        {
            Id = id;
            Client = client;
        }

        public virtual void Refill(double sum) 
        {
            if (Status != "Archiv") Balance = Balance + sum;
            else
            {
                Console.WriteLine($"Счет закрыт. С закрытым счетом нельзя проводить никакие операции.");
                return;
            }
        }

        public virtual void WriteOff(double sum)
        {
            if (Status != "Archiv")
            {
                if ((Balance - sum) >= 0) Balance = Balance - sum;
                else
                    Console.WriteLine($"При выводе со счета {sum} останется отрицательный баланс, операция невозможна");
            }
            else
            {
                Console.WriteLine($"Счет закрыт. С закрытым счетом нельзя проводить никакие операции.");
                return;
            }
        }

        public virtual void CloseBankAccount()
        {
            if (Balance > 0)
            {
                WriteOff(Balance);
                Status = "Archiv";
            }
        }
    }
}

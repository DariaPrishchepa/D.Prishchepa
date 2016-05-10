using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    abstract class BankClient
    {
        readonly int _idAccount;
        private List<BankAccount> Accounts = new List<BankAccount>();

        public int IdAccount
        {
            get { return _idAccount; }
        }

        public double SumAllAccounts
        {
            get
            {
                double _sumAllAccounts = 0;
                for (int i = 0; i < Accounts.Count; i++)
                {
                    _sumAllAccounts += Accounts[i].Balance;
                }
                return _sumAllAccounts;
            }
        }

        public BankClient(int idAccount)
        {
            _idAccount = idAccount;
        }

        public int CountBankAccount()
        {
            int ArchivAccounts = 0;
            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].Status == BankAccount.StatusBankAccount.Archiv)
                    ArchivAccounts++;
            }
            return Accounts.Count - ArchivAccounts;
        }

        public virtual void WriteAccounts()
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                Console.WriteLine($"Счет № {Accounts[i].Id} : {Accounts[i]}, баланс счета: {Accounts[i].Balance}, статус счета: {Accounts[i].Status}");
            }
        }

        public virtual void AddAccount(BankAccount bankAccount)
        {
            Accounts.Add(bankAccount);
        }

        public bool CloseAccount(int idAccount)
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].Id == idAccount)
                {
                    Accounts[i].CloseBankAccount();
                    return true;
                }
                Console.WriteLine($"Счета с id = {idAccount} не существует");
                return false;
            }
            return false;
        }
    }
}

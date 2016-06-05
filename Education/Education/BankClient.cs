using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
    public abstract class BankClient : IComparable
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
            try
            {
                _idAccount = idAccount;
            }
            catch (Exception)
            {
                Console.WriteLine($"Не удалось создать объект: BankClient");
            }
            
        }

        public int CountBankAccount()
        {
            try
            {
                int ArchivAccounts = 0;
                for (int i = 0; i < Accounts.Count; i++)
                {
                    if (Accounts[i].Status == BankAccount.StatusBankAccount.Archiv)
                        ArchivAccounts++;
                }
                return Accounts.Count - ArchivAccounts;
            }
            catch (Exception)
            {
                Console.WriteLine($"Не удалось посчитать колличество счетов");
                return -1;
            }
        }

        public virtual void WriteAccounts()
        {
            try
            {
                for (int i = 0; i < Accounts.Count; i++)
                {
                    Console.WriteLine($"Счет № {Accounts[i].Id} : {Accounts[i]}, баланс счета: {Accounts[i].Balance}, статус счета: {Accounts[i].Status}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Не удалось вывести список счетов");
            }
            
        }

        public virtual void AddAccount(BankAccount bankAccount)
        {
            try
            {
                Accounts.Add(bankAccount);
            }
            catch (Exception)
            {
                Console.WriteLine($"Не удалось добавить счет");
            }
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
                throw new ArgumentException("Счета с таким id не существует", nameof(idAccount));
            }
            return false;
        }

        public int CompareTo(object obj)
        {
            BankClient client = (BankClient)obj;
            if (SumAllAccounts > client.SumAllAccounts)
                return 1;
            if (SumAllAccounts < client.SumAllAccounts)
                return -1;
            return 0;
        }
    }
}

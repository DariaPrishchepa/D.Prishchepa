using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Client
    {
        public List< BankAccount> Accounts = new List<BankAccount>();
        
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

        public Client(){}

        public void AddAccount(BankAccount BA)
        {
            Accounts.Add(BA);
        }
    }
}

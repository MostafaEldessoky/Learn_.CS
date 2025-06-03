using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class Account : IDeposit, IWithdraw, ITransferMoney
    {
        private static List<Account> Accounts =  new List<Account>();
        private string _name; private string _id; private int _currency; private string _card;

        public string Name 
        {
            get 
            {
                return _name;
            }  
        }

        public string Id 
        {
            get 
            {
                return _id;
            } 
        }

        public int Currency 
        {
            get
            {
                return _currency;
            }
        }

        public string Card
        {
            get
            {
                return _card;
            }
        }

        public Account(string name,string id, int currency, string card) 
        {
            _name = name;
            _id = id;
            _currency = currency;
            _card = card;
            Accounts.Add(this);

        }

        public bool Deposit(int amount)
        {
            _currency = _currency + amount;
            Console.WriteLine($"Success Deposit to {Id}");
            Console.WriteLine($"Account {Id} current Currency is {Currency}");
            return true;
        }

        public bool Withdraw(int amount)
        {
            if (CheckRules(amount))
            {
                _currency = _currency - amount;
                Console.WriteLine($"Success Withdraw from {Id}");
                Console.WriteLine($"Account {Id} current Currency is {Currency}");
                return true;
            }
            else
            {
                Console.WriteLine($"fail Withdraw from {Id}");
                Console.WriteLine($"Account {Id} current Currency is {Currency} you cant Withdraw {amount}!!");
                return false;
            }
        }

        public bool TranasferMoney(string to, int amount)
        {
            if (CheckRules(amount))
            {
                if (FindAccount(to,amount))
                {
                    _currency = _currency - amount;
                    Console.WriteLine($"Success TrenasferMoney from {Id} to {to}");
                    Console.WriteLine($"Account {Id} current Currency is {Currency}");
                    return true;
                }
                else
                {
                    Console.WriteLine($"fail TrenasferMoney from {Id} to {to}");
                    Console.WriteLine($"there is no account exist with ID {to}");
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"fail TrenasferMoney from {Id} to {to}");
                Console.WriteLine($"Account {Id} current Currency is {Currency} you cant TrenasferMoney {amount}!!");
                return false;
            }
        }

        public bool FindAccount(string to,int amount)
        {
            foreach (Account account in Accounts) 
            {
                if (account.Id == to)
                {
                    return account.Deposit(amount);
                }
            }
            return false;
        }

        private bool CheckRules(int amount)
        {
            if (_currency >= amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

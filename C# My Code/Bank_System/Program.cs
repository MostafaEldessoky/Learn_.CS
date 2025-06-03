using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Bank_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Account> accounts = new List <Account> ();
            int card = 44332211;
            int id = 115394;
            string name;
            int currency;
            int amount;
            string to;
            while (true) 
            {
                Console.WriteLine("enter 1 to open new account 2 to sign in to your account any thing alse to exit");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine("enter name of your account");
                    name = Console.ReadLine();
                    Console.WriteLine("enter starting currency of your account");
                    currency = Convert.ToInt32(Console.ReadLine());
                    id = id + 1;
                    Console.WriteLine($"your account ID is {id}");
                    card = card + 11;
                    Console.WriteLine($"your visa card of your account is {card}");

                    accounts.Add(new Account(name, Convert.ToString(id),currency,Convert.ToString(card)));
                }
                else if (option == "2") 
                {
                    Console.WriteLine("enter name of your account");
                    name = Console.ReadLine();
                    int l = accounts.Count;
                    foreach (Account account in accounts) 
                    {
                        if (account.Name == name)
                        {
                            Console.WriteLine("enter 1 to Deposit 2 to Withdraw 3 to TranasferMoney");
                            string select = Console.ReadLine();
                            switch (select) 
                            {
                                case "1":
                                    Console.WriteLine("enter the amount of deposit");
                                    amount = Convert.ToInt32(Console.ReadLine());
                                    account.Deposit(amount);
                                    break;

                                case "2":
                                    Console.WriteLine("enter the amount of withdraw");
                                    amount = Convert.ToInt32(Console.ReadLine());
                                    account.Withdraw(amount);
                                    break;

                                case "3":
                                    Console.WriteLine("enter the account to transfer money to it");
                                    to = Console.ReadLine();
                                    Console.WriteLine("enter the amount of money to transfer");
                                    amount = Convert.ToInt32(Console.ReadLine());
                                    account.TranasferMoney(to,amount);
                                    break;
                            }

                            break;
                        }
                        l--;
                    }
                    if (l == 0)
                    {
                        Console.WriteLine($"there is no account exist with name {name}");
                    }

                }
                else
                {
                    break;
                }
            }
        }
    }
}

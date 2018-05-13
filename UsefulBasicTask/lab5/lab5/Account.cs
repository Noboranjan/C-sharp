using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account
    {
        internal string accountHolderName;
        internal string accountId;
        internal double balance;

        public Account()
        {
            Console.WriteLine("Account Created");
        }
        public Account(string accountHolderName, string accountId, double balance)
        {

            this.accountHolderName = accountHolderName;
            this.accountId = accountId;
            this.balance = balance;
        }
        public void showinfo()
        {
            Console.WriteLine("  Account ");
            Console.WriteLine(" AccountHolderName   " + accountHolderName);
            Console.WriteLine(" AccountId  " + accountId);
            Console.WriteLine(" Balance  " + Balance);
        }

        public string AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }

        public string AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void depositCash(double amount)
        {
            balance += amount;
        }

        public void withdrawCash(double amount)
        {
            balance -= amount;
        }
        public void transferCash(Account a, double amount)
        {
            a.depositCash(amount);
            a.withdrawCash(amount);

        }

    }
}

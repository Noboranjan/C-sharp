using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account
    {
        private string AccountHoldername;
        private string AccountId;
        private double balance;

        public Account() { }

        public Account(string AN,string AI,double b)
        {
            AccountHoldername = AN;
            AccountId = AI;
            balance = b;
        }

        public string accountHoldername
        {
            get { return AccountHoldername; }
            set { AccountHoldername = value; }
        }
        public string accountId
        {
        get { return AccountId; }
        set { AccountId = value; }
        }
        public double Balance
        {
        get { return balance; }
            set { balance = value; }
        }


        public void deposite(double amount)
        {
            balance += amount;
            Console.WriteLine("Balance"+balance);
        }
        public double withdrawCash(double amount)
        {
            balance -= amount;
            Console.WriteLine("Balance" + balance);
            return amount;

        }
        public void transferCash(Account a, double amount)
        {
            a.balance += amount;
            Console.WriteLine("Balance" + a.balance);
        }
        public void ShowDetails()
        {
            Console.WriteLine("Account Holder Name: {0}\nAccount Id:{1}\nAccount balance:{2}", AccountHoldername, AccountId, balance);
        }
    }
}

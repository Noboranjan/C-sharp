using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Bank
    {
        internal string bankName;
        string address;
        Account[] account;
        public int count = 0;
        public Bank()
        {
            Console.WriteLine("bankinfo Created");
        }
        public Bank(string bankName, string address)
        {
            this.bankName = bankName;
            this.address = address;
            account = new Account[10000];

        }
        public void showBankinfo()
        {
            Console.WriteLine("  Bank  ");
            Console.WriteLine("BankName" + bankName);
            Console.WriteLine("BankAddress" + address);
            for (int i = 0; i < count; i++)
            {
                {
                    Console.WriteLine("Account[" + (i + 1) + "]");
                    account[i].showinfo();
                }
            }

        }

        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public void addAccount(Account a)
        {
            account[count] = a;
            count++;
            Console.WriteLine("New Account Added in Library");

        }

        public void deleteAccount(Account a)
        {

            for (int i = 0; i < count; i++)
            {
                if (account[i] == a)
                {

                    for (int j = i; j + 1 < 10000; j++)
                    {
                        account[j] = account[j + 1];
                    }
                    count--;
                    break;
                }
            }

        }
    }

}

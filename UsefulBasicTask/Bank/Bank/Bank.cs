using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Bank
    {
        private string bankName;
        private string address;
        private Account[] account = new Account[10];

        public Bank() { }
        public Bank(string BN, string add)
        {
            bankName = BN;
            address = add;
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
            for (int i = 0; i < account.Length; i++)
            {
                if (account[i] == null)
                {
                    account[i] = a;
                    break;
                }
            }

        }

        public void deleteAccount(Account a)
        {
            for (int i = 0; i < account.Length; i++)
            {
                if (account[i] == a)
                {
                    account[i] = null;
                }
            }
        }
        public void ShowDetail()
        {
            Console.WriteLine("Bank name :{0}\nAddress :{1}\n", bankName, address);

            for (int i = 0; i < account.Length; i++)
            {
                if (account[i] != null)
                {
                    Console.WriteLine("Account Holder Name: {0}\nAccount Id:{1}\nAccount balance:{2}", account[i].accountHoldername,account[i].accountId,account[i].Balance);
                    
                }
                }
            }

        }
    }



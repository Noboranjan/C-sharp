using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1
{
    class MainAccount
    {
        private int AccountID;
        private string AccountHolderName;
        private double Balance;

        public void setAccountID(int i)
        {
            AccountID = i;

        }
        public void setAccountHolderName(string n )
        { 
            AccountHolderName = n;
        }
        public void setBalance(double b)
    {
        Balance = b;
    }
        public int getAccountID()
        {
            return AccountID;

        }
        public string getAccountHolderName()
        {
            return AccountHolderName;

        }
        public double getBalance()
        {
            return Balance;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class SavingsAccount : BankAccount, IBankAccount
    {

         public void Deposite(double amount)
    {
        Balance = Balance + amount;
    }
        public  void withdraw(double amount)
        {
            if (amount <= 5000)
            { 
                Balance =Balance - amount;
            }
            else
            {
                Console.WriteLine("limit is greather than 50000 ");
            }
        }
        public override void showinfo()
        {
            Console.WriteLine("You have balace"+Balance);
           
        }
    }
}

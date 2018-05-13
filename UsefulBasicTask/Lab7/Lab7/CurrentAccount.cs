using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class CurrentAccount:BankAccount,IBankAccount
    {
        
      public   void Deposite(double amount)
    {
        Balance = Balance + amount;
    }
      public   void withdraw(double amount)
        {
          
               Balance =Balance - amount;
        }
            
        public override void showinfo()
        {
           Console.WriteLine("You have balace"+Balance);
        }

    }
}

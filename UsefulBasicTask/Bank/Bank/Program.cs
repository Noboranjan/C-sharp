using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("Niloy","1",100.0);

            acc1.ShowDetails();

            Account acc2 = new Account("Joy","2",80.00);

            acc2.ShowDetails();


            acc1.deposite(200);

            double WithdrawAmount = acc1.withdrawCash(50);

            acc1.transferCash(acc2, WithdrawAmount);


            Bank b = new Bank("Brac Bank", "Uttara");
            b.addAccount(acc1);
            b.addAccount(acc2);
            b.ShowDetail();

            b.deleteAccount(acc1);
            b.ShowDetail();
        }
    }
}

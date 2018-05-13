using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount s = new SavingsAccount();
            s.Name="Niloy";
            s.Balance = 6000;
            s.AccNo = "New";
            s.PhoneNo = "0124";
            s.Gender = "male";
            s.Address = "Uttara";

            s.Deposite(500);
            s.withdraw(200);
            s.showinfo();

            CurrentAccount c = new CurrentAccount();

            c.Name = "JOY";
            c.Balance = 7000;
            c.AccNo = "New";
            c.PhoneNo = "0124";
            c.Gender = "male";
            c.Address = "Uttara";

            c.Deposite(800);
            c.withdraw(400);
            c.showinfo();
        }
    }
}

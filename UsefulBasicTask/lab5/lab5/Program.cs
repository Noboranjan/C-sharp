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

            Account ob1 = new Account("niloy", "83", 100);

            ob1.showinfo();
            ob1.depositCash(40);
            ob1.withdrawCash(10);
            ob1.showinfo();

            Account ob2= new Account("nobo", "36", 150);

            ob2.showinfo();
            ob2.depositCash(50);
            ob2.withdrawCash(10);
            ob2.showinfo();

            ob1.transferCash(ob2, 50);
            ob1.showinfo();

         Bank aa = new Bank("bank", "uttara");
            aa.addAccount(ob1);
            aa.showBankinfo();

            Bank aaa = new Bank("bank", "azompur");
            aaa.deleteAccount(ob1);
            aaa.showBankinfo();
        }
    }
        }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1
{
    class Program
    {
        static void Main(string[] args)
        {

            MainAccount m = new MainAccount();

            m.setAccountID(1);
            m.setAccountHolderName("NILOY");
            m.setBalance(699.99);
            Console.WriteLine(m.getAccountID() +"\n"+m.getAccountHolderName()+"\n"+m.getBalance());
        }
    }
}

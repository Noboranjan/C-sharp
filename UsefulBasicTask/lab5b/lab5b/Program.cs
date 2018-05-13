using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5b
{
    class Program
    {
        static void Main(string[] args)
        {

            MyBasicCalculator c = new MyBasicCalculator(5,4);

            c.add();
            c.subtract();
            c.divide();
            c.multiply();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            MySciCalculator m = new MySciCalculator(5,2);

            Console.WriteLine("add"+ m.add());
            Console.WriteLine("Sub" + m.subtract());
            Console.WriteLine("Mul" + m.multiply());
            Console.WriteLine("div"+m.divide());
            Console.WriteLine("Power" + m.toThePower());

            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4b
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza p = new Pizza();
            p.Name = "cheze";
            p.Price = 55;
            p.Size = "6'";

            Console.WriteLine(p.getDetails());


            Burger b = new Burger();
            b.Name = "cool";
            b.Price = 25;
            b.NumberOfPatties = 22;
            Console.WriteLine(b.getDetails());
        }
    }
}

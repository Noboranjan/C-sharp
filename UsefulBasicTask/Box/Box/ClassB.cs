using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Box
{
    class ClassB : ClassA 
    {
        public ClassB(ClassB b)
        {
            b.c1 = 20;
            Console.WriteLine("EmptyB !!"); }
    }
}



using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            
            Console.WriteLine("Enter your Name");
            string name=Console.ReadLine();
            Console.WriteLine("Hello!! {0}", name);

            Console.ReadKey(); 
        }
    }
}

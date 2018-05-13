using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            List<string> list2 = new List<string>();
            List<Object> list3 = new List<Object>();
            List<int> list4 = new List<int>();
            list1.Add(10);
            list1.Add(30);
            list1.Add(20);

            list2.Add("hello");
            list2.Add("World");
            list2.Add("OOP2 F");
            list2.Add("OOP2 E2");

            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine("{0} ", list1[i]);
            }

            foreach (int i in list1)
            {
                Console.WriteLine("{0} ", i);
            }

            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine("{0} ", list2[i]);
            }

            foreach (string s in list2)
            {
                Console.WriteLine("{0} ", s);
            }

            list1.Remove(30);

            foreach (int i in list1)
            {
                Console.WriteLine("{0} ", i);
            }

            list1.Add(30);
            list1.Add(40);
            list1.RemoveAt(1);

            foreach (int i in list1)
            {
                Console.WriteLine("{0} ", i);
            }
            list1.Add(55);
            list1.RemoveAll(x => x > 35 & x < 45);
            foreach (int i in list1)
            {
                Console.WriteLine("{0} ", i);
            }
            int sum = list1.Sum();
            double d = list1.Average();
            Console.WriteLine(sum);
            Console.WriteLine(d);
            list1.Add(25);
            foreach (int i in list1)
            {
                Console.WriteLine("{0} ", i);
            }
            list1.Sort();
            foreach (int i in list1)
            {
                Console.WriteLine("{0} ", i);
            }

            Console.WriteLine(list1.Exists(x => x == 50));

            Console.WriteLine(list1.Find(x => x > 15));

            Console.WriteLine(list1.IndexOf(25));

            list1.Add(30);
            list1.Add(60);

            foreach (int i in list1)
            {
                Console.WriteLine("{0} ", i);
            }

            Console.WriteLine(list1.IndexOf(30));
            Console.WriteLine(list1.LastIndexOf(30));

            list2.Clear();
            foreach (string s in list2)
            {
                Console.WriteLine("{0} ", s);
            }

            list2.Add("Khida Lagse");
            list2.Add("Chuti Den");
            list2.Add("Sir Pashan");
            list2.Add("Bonus Lagbe");

            Console.WriteLine(list2.Contains("Break Den"));
            foreach (string s in list2)
            {
                Console.WriteLine("{0} ", s);
            }
            list2.Reverse();
            foreach (string s in list2)
            {
                Console.WriteLine("{0} ", s);
            }
            String str = "C#";
            Int32 i1 = 10;
            list3.Add(str);
            list3.Add(i1);
            foreach (Object o in list3)
            {
                Console.WriteLine("{0} ", o);
            }
            list4.Add(100);
            list4.AddRange(list1);
            foreach (int i in list4)
            {
                Console.WriteLine("{0} ", i);
            }
            list4.Insert(2, 200);
            foreach (int i in list4)
            {
                Console.WriteLine("{0} ", i);
            }




        }
    }
}
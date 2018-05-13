using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MainClass
    {
        static void Main(string[] args)
        {
        Animals tiger = new Animals();
        tiger.SetAnimalName("Simba");
        Console.WriteLine(tiger.GetAnimalName());

        Animals deer = new Animals();
        deer.SetAnimalName("Luvly");
        Console.WriteLine(deer.GetAnimalName());
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4b
{
    class Burger:FoodItem
    {
        private int numberOfPatties;

       public Burger( ){}
       public Burger(int nP, double p, string n)
           : base(p, n)
       {
           numberOfPatties = nP;
       }
       public int NumberOfPatties
       {
           get { return numberOfPatties; }
           set { numberOfPatties = value; }
       }
        public string getDetails()
        {
            return (Price +"\n"+ Name +"\n" +numberOfPatties);
        }

    }
}

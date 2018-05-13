using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4b
{
    class FoodItem
    {
        private double price;
        private string name;
        public FoodItem( ){}
        public FoodItem(double p, string n)
        {
            price = p;
            name = n;
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4b
{
    class Pizza:FoodItem
    {
        private string size;
        public Pizza() { }
        public Pizza(string s, double p, string n)
            : base(p, n)
        {
            size = s;
        }
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        public string getDetails()
        {
            return (Price +"\n"+ Name +"\n"+ size );
        }

    }
}

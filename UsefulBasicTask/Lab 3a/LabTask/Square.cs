using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    class Square
    {
        private double length;

        public Square(){ }
        public Square(double l)
        {
            length = l;
        }

        public double Length
        {
            get
            {
                return length;

            }
            set
            {
                length = value;
            }
        }
        public void showArea()
        {
            Console.WriteLine("Square Area " + (length * length));
        }
    }
}

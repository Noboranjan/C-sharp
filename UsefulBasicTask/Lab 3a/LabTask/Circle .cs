using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    class Circle
    {
         private double radius;

        public Circle(){ }
        public Circle(double r)
        {
            radius = r;
        }

        public double Radius
        {
            get
            {
                return radius;

            }
            set
            {
                radius = value;
            }
        }
        public void showArea()
        {
            Console.WriteLine("Circle Area " + 3.1416 * (radius * radius));
        }
    }
}

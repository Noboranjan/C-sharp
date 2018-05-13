using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    class Rectangle
    {
        private double length;
        private double width;
        private double area;

        public Rectangle() { }
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;

        }

        public double Length
        {
            get
            { return length; }
            set
            { length = value; }
        }
        public double Width 
        {
            get
            { return width; }
            set
            { width = value; }
        }
        public void showArea()
        {
            area = length * width;
            Console.WriteLine("Rectangle area: " + area);
        }

    }
}

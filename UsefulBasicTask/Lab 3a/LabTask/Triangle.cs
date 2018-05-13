using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    class Triangle
    {
        private double height;
        private double land;
        private double area;

        public Triangle() { }
        public Triangle(double h, double l)
        {
            height = h;
            land = l;

        }

        public double Height
        {
            get
            { return height; }
            set
            { height = value; }
        }
        public double Land 
        {
            get
            { return land; }
            set
            { land = value; }
        }
        public void showArea()
        {
            area = (height * land)/2;
            Console.WriteLine("Triangle area: " + area);
        }

    }
}

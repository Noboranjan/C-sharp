using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle r = new Rectangle();
            Rectangle r1 = new Rectangle(5.5,8.5);

            r1.showArea();

            r.Length = 10.2;
            r.Width = 5.5;
            r.showArea();

            Square s = new Square();
            Square s1 = new Square(6.3);

            s1.showArea();
            s.Length = 10;
            s.showArea();

            Triangle t = new Triangle();
            Triangle t1 = new Triangle(6.3,3.3);

            t.Height = 5.5;
            t.Land = 6.2;

            t.showArea();

            t1.showArea();


            Circle c = new Circle();
            Circle c1 = new Circle(6.3);

            c.Radius=2.3;
            c.showArea();

            c1.showArea();
        }
    }
}

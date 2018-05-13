using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5b
{
    class MyBasicCalculator:BasicCalc
    {

       private double value1;
       private double value2;
       private double result;

       public MyBasicCalculator( ){}
       public MyBasicCalculator(double v1, double v2)
       {
           value1 = v1;
           value2 = v2;
       }

       public double Value1
       {
           get { return value1; }
           set {value1=value;}
       }
       public double Value2
       {
           get { return value2; }
           set { value2 = value; }
       }

       public override double add()
       {
           result = value1 + value2;
           return result;
           //Console.WriteLine("ADD"+result);
       }
       public override double subtract()
       {
           result = value1 - value2;
           return result; 
          // Console.WriteLine("Subtract" + result);
       }
       public override double multiply()
       {
           result = value1 * value2;
           //Console.WriteLine("Multiply" + result);
           return result;
       }
       public override double divide( )
       {
           result = value1 / value2;
           //Console.WriteLine("Divide" + result);
           return result;
       }
       





    }
}

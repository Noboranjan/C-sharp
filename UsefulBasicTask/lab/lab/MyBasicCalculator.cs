using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
   abstract class MyBasicCalculator : BasicCalcInterface
    {
        protected double value1;
        protected double value2;
        protected double result;

        public MyBasicCalculator() { }

        public MyBasicCalculator(double v1, double v2)
        {
            value1 = v1;
            value2 = v2;
        }
        public abstract double add();
       public abstract double subtract( );
      public abstract double multiply( );
      public abstract double divide();

    }
}

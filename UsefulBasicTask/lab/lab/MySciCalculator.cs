using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class MySciCalculator : MyBasicCalculator, SciCalcInterface
    {

        public MySciCalculator() { }
        public MySciCalculator(double v1, double v2):base(v1,v2)
        {
         
        }

        public double toThePower()
        {

            return value1 * value1;

        }
        public override double add()
      {
          result = value1 + value2;
          return result;
      }
        public override double divide()
        {
            result=value1 / value2;
            return result;
        }
        public override double multiply()
        {
            result = value1 * value2;
            return result;
        }
        public override double subtract()
        {
            result = value1 - value2;
            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] jArray = new int[4][];

            jArray[0] = new int[5] { 1, 2, 3, 4, 5 };
            jArray[1] = new int[2] { 1, 2 };
            jArray[2] = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            jArray[3] = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

            for (int i = 0; i < jArray.Length; i++)
            {
                for (int j = 0; j < jArray[i].Length; j++)
                {
                    Console.Write("{0} ", jArray[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}

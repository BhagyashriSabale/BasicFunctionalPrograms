using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograms.LargestNumber
{
    internal class Ln
    {
        public static int FindLargestNum(int num1, int num2, int num3)
        {
            int largest = num1;
            if (num2 > largest)
                largest = num2;
            if (num3 > largest)
                largest = num3;

            return largest;
        }
    }
}

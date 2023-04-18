using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograms.EvenOdd
{
    internal class Evodd
    {
        private int num;

        public Evodd(int num)
        {
            this.num = num;
        }
        public string Check()
        {
            if (num%2==0)
            {
                return num + " is even.";
            }
            else
            {
                return num + " is odd.";
            }
        }
    }
}

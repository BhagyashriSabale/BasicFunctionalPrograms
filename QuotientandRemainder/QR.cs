using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograms.QuotientandRemainder
{
    internal class QR
    {
        public void Quorem(int divident, int divisor)
        {

            int quotient = divident / divisor;
            int remainder = divident % divisor;

            Console.WriteLine("Quotient: {0}", quotient);
            Console.WriteLine("remainder: {0} ", remainder);


        }
    }
}

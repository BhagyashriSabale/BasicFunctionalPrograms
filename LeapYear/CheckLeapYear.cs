using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograms.LeapYear
{
    internal class CheckLeapYear
    {
        public void CheckLP(int year)
        {

            //Check input is valid or not
            if (year.ToString().Length != 4)
            {
                Console.WriteLine("Invalid input. Please enter a 4-digit year.");
                return;
            }

            //check year is leap or not
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is a Leap Year.");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year.");
            }
        }
    }
}

using BasicFunctionPrograms.FlipCoin;
using BasicFunctionPrograms.LeapYear;

namespace BasicFunctionPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Functional Programs");

            Console.WriteLine("Please choose a 1 program from below List");
            Console.WriteLine("1.FlipCoin\n2.LeapYear");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option) 
            {
                case 1:
                    CheckLP checkLP = new CheckLP();
                    checkLP.FlipCoin();
                break;
                case 2:
                    Console.WriteLine("Enter a year (4 digits): ");
                    int year = Convert.ToInt32(Console.ReadLine()); 

                    CheckLeapYear checkLeapYear = new CheckLeapYear();
                    checkLeapYear.CheckLP(year);
                break;
            
            }
        }
    }
}
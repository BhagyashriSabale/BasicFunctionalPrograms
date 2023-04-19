using BasicFunctionPrograms.EvenOdd;
using BasicFunctionPrograms.FlipCoin;
using BasicFunctionPrograms.LeapYear;
using BasicFunctionPrograms.PrimeFactors;
using BasicFunctionPrograms.QuotientandRemainder;
using BasicFunctionPrograms.SwapNumber;
using BasicFunctionPrograms.VowelorConstant;

namespace BasicFunctionPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Functional Programs");

            Console.WriteLine("Please choose a 1 program from below List");
            Console.WriteLine("1.FlipCoin\n2.LeapYear\n3.PrimeFactor\n4.QuotientandRemainder\n5.SwapNumbers\n6.EvenOddS\n7.VowelorConstant");
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
                case 3:
                    Console.Write("Please enter the number to find its prime factors: ");
                    int n = int.Parse(Console.ReadLine());

                    Primefact primefact = new Primefact();
                    primefact.Pf(n);

                    Console.ReadKey();
                break;
                case 4:
                    Console.Write("Please enter Divident: ");
                    int dividend = int.Parse(Console.ReadLine());

                    Console.Write("Please enter Divisor: ");
                    int divisor = int.Parse(Console.ReadLine());

                    QR qr = new QR();
                    qr.Quorem(dividend,divisor);
                break;
                case 5:
                    //take user input
                    Console.WriteLine("Please a number a: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter number b: ");
                    int b = int.Parse(Console.ReadLine());

                    // create object of class and inherit their properties
                    Swapnum swapnum = new Swapnum();
                    swapnum.Swap(ref a, ref b);

                    //print swapping numbers
                    Console.WriteLine("After Swapping: ");
                    Console.WriteLine("a: {0}", a);
                    Console.WriteLine("b: {0}", b);
                    break;
                case 6:
                    Console.WriteLine("Please enter the number:");
                    int num = int.Parse(Console.ReadLine());

                    Evodd evodd = new Evodd(num);
                    string result = evodd.Check();

                    Console.WriteLine(result);
               break;
                case 7:
                    Console.Write("Enter a character: ");
                    char c = Console.ReadKey().KeyChar;

                    bool isVowel = Vc.IsVowel(c);
                    if (isVowel)
                    {
                        Console.WriteLine("\nThe character '{0}' is a vowel", c);
                    }
                    else
                    {
                        Console.WriteLine("\nThe character '{0}' is a consonant", c);
                    }

                    Console.ReadLine();
                    break;

            
            }
        }
    }
}
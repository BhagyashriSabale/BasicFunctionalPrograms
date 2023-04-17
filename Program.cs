using BasicFunctionPrograms.FlipCoin;

namespace BasicFunctionPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Functional Programs");

            Console.WriteLine("Please choose a 1 program from below List");
            Console.WriteLine("1.FlipCoin");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option) 
            {
                case 1:
                    CheckLP checkLP = new CheckLP();
                    checkLP.FlipCoin();
                    break;
            
            }
        }
    }
}
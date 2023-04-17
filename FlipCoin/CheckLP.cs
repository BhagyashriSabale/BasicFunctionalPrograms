using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograms.FlipCoin
{
    internal class CheckLP
    {
        public void FlipCoin()
        {
            //Take user input
            Console.WriteLine("Enter the number of times to flip the coin:");

            //Check random no is less than 0.5  
            int numFlips = 0;
            while (numFlips <= 0)
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out numFlips) || numFlips <= 0)
                {
                    Console.WriteLine("Invalid input, please enter a positive integer.");
                }
            }


            //Print percentage head and tail
            int numHeads = 0;
            int numTails = 0;
            Random rand = new Random();
            for (int i = 0; i < numFlips; i++)
            {
                if (rand.NextDouble() < 0.5)
                {
                    numTails++;
                }
                else
                {
                    numHeads++;
                }

            }
            double percentHeads = ((double)numHeads / numFlips) * 100;
            double percentTails = ((double)numTails / numFlips) * 100;

            Console.WriteLine("Percentage of heads: " + percentHeads);
            Console.WriteLine("Percentage of tails: " + percentTails);
        }
    }
}

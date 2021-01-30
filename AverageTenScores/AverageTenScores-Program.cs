using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageTenScores
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> inputNums = new List<double>();
            Console.WriteLine("Hey want to input exactly 10 numbers and find out what average of them is?! " +
                "\nOk but if I do this for you, you have to follow some simple rules" +
                "\n\t1. Only input numbers, no spaces. I mean it!" +
                "\n\t2. Your numbers have to be in between 1 and 100." +
                "\n\t3. Have fun!");
            for (double i = 1; i < 11; i++)
            {
                Console.WriteLine($"Please enter number {i}.");

                double input = double.Parse(Console.ReadLine());
                if (input > 0 && input < 101)
                {
                    inputNums.Add(input);
                }
                else
                {
                    throw new Exception("Hey you broke it! Next time follow the rules! ;)");
                }

            }
            double avg = avgOfNumbers(inputNums);
            Console.WriteLine($"The average of your numbers is {avg}. Ok bye!");
        }

        private static double avgOfNumbers(List<double> nums)
        {
            return nums.Average();

            //// Or I could have done this : 
            //int sum = 0;
            //foreach(var num in nums)
            //{
            //    sum += num;
            //}
            //return sum / nums.Count();
        }
    }
}

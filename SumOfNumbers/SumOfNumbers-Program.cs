using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNums = new List<int>();
            Console.WriteLine("Hey want to input exactly 10 numbers and find out what they add up to?! " +
                "\nOk but if I do this for you, you have to follow some simple rules" +
                "\n\t1. Only input numbers, no spaces. I mean it!" +
                "\n\t2. Your numbers have to be in between 1 and 100." +
                "\n\t3. Have fun!");
            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Please enter number {i}.");
                
                int input = int.Parse(Console.ReadLine());
                if (input > 0 && input < 101) 
                {
                    inputNums.Add(input);
                }
                else
                {
                    throw new Exception("Hey you broke it! Next time follow the rules!)");      
                }

            }
            int totalSum = sumOfNumbers(inputNums);
            Console.WriteLine($"The total sum of your numbers is {totalSum}. Ok bye!");
        }

        /// <summary>
        /// Takes in n amount of inputs and sums them up.
        /// </summary>
        /// <param name="arr">Takes a list of integer.</param>
        /// <returns>The total of inputs.</returns>
        private static int sumOfNumbers(List<int> nums) 
        {
            return nums.Sum();

            //// Or I could have done this : 
            //int sum = 0;
            //foreach(var num in nums)
            //{
            //    sum += num;
            //}
            //return sum;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageANonSpecificNumberOfScores
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> inputNums = new List<double>();
            Console.WriteLine("Hello! Let's figure out the average of your test scores.");
            
            while (true)
            {
                Console.WriteLine($"Please enter a grade number or press f to finish.");
                string userEntry = Console.ReadLine();
                if (userEntry == "f") break;

                double input = double.Parse(userEntry);
                if (input > 0 && input < 101)
                {
                    inputNums.Add(input);
                }
                else
                {
                    throw new Exception("Hey you broke it!");
                }

            }
            if(inputNums.Count < 1)
            {
                Console.WriteLine("You didn't input any scores.");
                Console.ReadLine();
                return;
            }

            double avg = avgOfNumbers(inputNums);
            string letterGrade = findLetterGrade(avg);
            Console.WriteLine($"The numerical average of your grades is {avg}." +
                $" The letter grade for the average is {letterGrade}." +
                $"\nOk bye!");
        }

        private static double avgOfNumbers(List<double> nums)
        {
            double averageNumericalGrade = nums.Average();

            //// Or I could have done this : 
            //int sum = 0;
            //foreach(var num in nums)
            //{
            //    sum += num;
            //}
            //return sum / nums.Count();

            return averageNumericalGrade;

        }

        private static string findLetterGrade(double averageNumericalGrade)
        {
            string letterGrade;
            if (averageNumericalGrade >= 90 && averageNumericalGrade <= 100)
                letterGrade = "A";
            else if (averageNumericalGrade >= 80)
                letterGrade = "B";
            else if (averageNumericalGrade >= 70)
                letterGrade = "C";
            else if (averageNumericalGrade >= 60)
                letterGrade = "D";
            else
                letterGrade = "F";
            return letterGrade;
        }
    }
}

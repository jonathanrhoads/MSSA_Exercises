using System;
using System.Collections.Generic;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            char action = getMathematicalAction();
            List<double> numbers = getNumbers(action);
            double result = performArithmetic(numbers, action);
            Console.WriteLine($"\nSolution:" +
                $"\t{numbers[0]} {action} {numbers[1]} = {result}");

        }

        private static double performArithmetic(List<double> numbers, char action)
        {
            double num1 = numbers[0];
            double num2 = numbers[1];

            if(action == '+')
            {
                return num1 + num2;
            }
            else if (action == '-')
            {
                return num1 - num2;
            }
            else if (action == '*')
            {
                return num1 * num2;
            }
            else
            {
                return num1 / num2;
            }
        }

        static char getMathematicalAction()
        {
            Console.WriteLine("\nWhat type of mathematical symbol would you like to perform. " +
                "\nPlease type in one of the following:" +
                "\n\t+ for addition" +
                "\n\t- for subtraction" +
                "\n\t/ for division" +
                "\n\t* for multiplication.");
            char symbol = Convert.ToChar(Console.ReadLine());

            bool correctSymbol = operatorCheck(symbol);

            if (!correctSymbol)
            {
                Console.WriteLine("Thanks for stopping by!");
                System.Environment.Exit(0);
            }

            Console.WriteLine($"\nYou chose {symbol}");
            return symbol;      
        }


        // Ensures the operator is legal.
        private static bool operatorCheck(char symbol)
        {
            if (symbol != '+' && symbol != '-' && symbol != '/' && symbol != '*')
            {
                return false;
            }
            return true;
        }

        private static List<double> getNumbers(char action)
        {
            List<double> numbers = new List<double>();
            Console.WriteLine($"\nWhat is the first number to perform arithmetic on?.");
            numbers.Add(double.Parse(Console.ReadLine()));
            Console.WriteLine($"\nWhat is the second number to perform arithmetic on?");
            numbers.Add(double.Parse(Console.ReadLine()));


            // Ensures the user does not divide by zero.
            while(action == '/' && numbers[1] == 0)
            {
                Console.WriteLine($"\nDivision by zero is not allowed. Please enter another second number.");
                numbers[1] = double.Parse(Console.ReadLine());
            }
            return numbers;
        }
    }
}

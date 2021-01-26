using System;

namespace MonteCarlo
{
    class Program
    {
        static double DistanceFromOrigin(double x, double y) => Math.Sqrt(x * x + y * y);
        
        static void Main(string[] args)
        {
            Random RandomNumber = new Random();
            int iterations;

            if( args.Length > 0) 
            {
                iterations = int.Parse(args[0]);
            }
            else
            {
                iterations = GetNumberOfIterations();
            }
            
            FindEstimateOfPi(RandomNumber, iterations);
            
        }



        private static void FindEstimateOfPi(Random RandomNumber, int iterations)
        {
            int insideCircleCount = 0;

            for (int i = 0; i < iterations; i++)
            {
                double hypotenuse = DistanceFromOrigin(RandomNumber.NextDouble(), RandomNumber.NextDouble());
                if (hypotenuse <= 1.0)
                {
                    insideCircleCount++;
                }

            }

            double estimate = (double)insideCircleCount / (double)iterations * 4.0;
            Console.WriteLine($"value = {estimate}");
            Console.WriteLine($"Delta = {Math.Abs(estimate - Math.PI)}");
          
        }

        private static int GetNumberOfIterations()
        {
            Console.WriteLine("Monte Carlo. Write in your desired number of iterations");
            return int.Parse(Console.ReadLine());

           
        }
    }
}

/*
 * C:\Users\jonat\OneDrive\Desktop\MSSA HW\Programming Exercises\MonteCarlo\bin\Debug\netcoreapp3.1>MonteCarlo.exe 10
value = 3.6
Delta = 0.458407346410207

C:\Users\jonat\OneDrive\Desktop\MSSA HW\Programming Exercises\MonteCarlo\bin\Debug\netcoreapp3.1>MonteCarlo.exe 100
value = 3.52
Delta = 0.3784073464102069

C:\Users\jonat\OneDrive\Desktop\MSSA HW\Programming Exercises\MonteCarlo\bin\Debug\netcoreapp3.1>MonteCarlo.exe 1000
value = 3.208
Delta = 0.06640734641020707

C:\Users\jonat\OneDrive\Desktop\MSSA HW\Programming Exercises\MonteCarlo\bin\Debug\netcoreapp3.1>MonteCarlo.exe 10000
value = 3.1268
Delta = 0.014792653589793314

C:\Users\jonat\OneDrive\Desktop\MSSA HW\Programming Exercises\MonteCarlo\bin\Debug\netcoreapp3.1>MonteCarlo.exe 100000
value = 3.1466
Delta = 0.0050073464102067256


-------------------------------------------------------------------------------


1. We multiply the value from step 5 by 4 because we want to model 
the entire unit circle instead of just the top right quadrant of it.

2. As the input increases the accuracy of predicting Pi increases. 
This is because the sampling size increases so the random values begin 
depict the boundaries of the unit circle better.

3. No the output will change because it is dependent on the System.Random. 

4. 100 Million took several seconds to compute.

5. The accuracy of the estimate of Pi can be over 99%. This depends on the amount of iterations that you performt the  operation.

6. An example of when this method can be used is when drilling for Oil. They can better predict where the oil will be.

 * 
 */


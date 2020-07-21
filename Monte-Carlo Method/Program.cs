using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Monte.Carlo.Method
{
    public class Random
    {
        public static System.Random ran = new System.Random();
        public double raN = ran.NextDouble();

        public static void Main()
        {
            while (true)
            {

            
                Console.WriteLine("Please give a number of iterations to use: ");
                int iteration = 0;
                iteration = int.Parse(Console.ReadLine());
                double counter = 0;
                //generate random numbers based on iteration
                for (int i = 1; i <= iteration; i++)
                {
                    double x = GenerateDigit();
                    double y = GenerateDigit();
                    //Calculate Hypotenuse
                    double h = Calculate(x, y);
                    if (h <= 1)
                    {
                        counter++;
                    }

                }
                double pi = (counter / iteration) * 4;
                Console.WriteLine($"The value from iterations is {pi} while the actual value of PI is {Math.PI}");
            }
        }

        //Generate Random Number
        public static double GenerateDigit()
        {
            double n = ran.NextDouble();
            return n;
        }

        public static double Calculate(double x, double y)
        {
            double h = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return h;
        }
    }

}


/*
 Please give a number of iterations to use:
10
The value from iterations is 4 while the actual value of PI is 3.141592653589793

Please give a number of iterations to use:
100
The value from iterations is 3.08 while the actual value of PI is 3.141592653589793

Please give a number of iterations to use:
10000
The value from iterations is 3.1352 while the actual value of PI is 3.141592653589793
Please give a number of iterations to use:
*/

/* 
1. We multiply values from step 5 by 4 to estimate the value of pi.

2. The output takes longer and longer to calculate.

3. The output will not remain the same if I run the same number as each iteration will be random. 
However it will still be  closer and closer to pi the larger the number.

4. The parameter was 100000000

5. The longest value I calculated (100000000) was at 3.1414

6. Monte Carlo methods were centeral to the manhattan project. */

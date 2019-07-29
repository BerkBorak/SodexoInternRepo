using System;

namespace SquareSumVsSumSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double squaresum=0, sumsquare=0;
            for (i = 0; i <= 100; i++)
            {
                squaresum += i;
                sumsquare += Math.Pow(i, 2);
            }
            squaresum = Math.Pow(squaresum, 2);
            Console.WriteLine("The difference between the sum of the squares of the first one hundred natural numbers and the square of the sum is: " + (sumsquare - squaresum));

        }
    }
}

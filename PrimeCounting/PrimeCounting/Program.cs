using System;

namespace PrimeCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            int primecount = 1;
            long i = 2;
            bool prime;
            while (primecount != 10001)
            {
                i++;
                if (prime = IsItPrime(i))
                    primecount++;              
            }
            Console.WriteLine(i);
        }
        static bool IsItPrime(long number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}

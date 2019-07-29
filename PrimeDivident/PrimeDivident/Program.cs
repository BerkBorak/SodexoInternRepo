using System;
namespace PrimeDivident
{
    class Program
    {
        static bool IsItPrime(long number)
        {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                        return false;
                }
                return true;
        }
        static void Main(string[] args)
        {
            long bigNumber;
            long divident;
            Console.WriteLine("Lütfen en büyük asal bölenini bulmak istediğiniz sayıyı giriniz: ");
            bigNumber = Int64.Parse(Console.ReadLine());
            for(int i=1; i<=bigNumber/2; i++)
            {
                if (bigNumber % i == 0)
                {
                    divident = bigNumber / i;
                    if (Program.IsItPrime(divident))
                    {
                        Console.WriteLine("En büyük asal böleni: " + divident);
                        return;
                    }
                }
            }
        }
        
    }
}

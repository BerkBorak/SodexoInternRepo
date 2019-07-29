using System;

namespace largePalindrome
{
    class Program
    {
        static bool IsItPalindrome(string test)
        {
            int i;
            int length = test.Length - 1;
            for (i=0; i<=(length/2); i++)
            {
                if (!(test[i].Equals(test[length - i])))
                    return false;
            }
                return true;;
        }
        static void Main(string[] args)
        {
            int i, j, multiple = 0, palin = 0;
            string test;
            bool flag;
            for(i = 999; i > 100; i--)
            {
                for (j = 999; j > 100; j--)
                {
                    multiple = i * j;
                    test = multiple.ToString();
                    flag = IsItPalindrome(test);
                    if (flag == true && multiple > palin)
                        palin = multiple;
                }
            }
            Console.WriteLine("En büyük palindrom: " + palin);
            return;
        }
    }
}

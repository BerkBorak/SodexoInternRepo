using System;
using System.Collections.Generic;
using System.Text;

namespace AdjacentMultiples
{
    class NumberList
    {
        private List<int> digits;
        public NumberList()
        {
            digits = new List<int>(1000);
        }
        public void Digitize(string numberString)
        {
            int i = 0;
            foreach (int digit in numberString)
            {
                digits.Add(Int32.Parse(numberString[i].ToString()));
                i++;
            }
        }
        public double FindHighestCombination(int consecutive)
        {
            double multiple = 1, highestMultiple = 1;
            for (int i = 0; i < digits.Count - consecutive; i++)
            {
                for (int j = 0; j < consecutive; j++)
                {
                    multiple = multiple * digits[i + j];
                }
                if (multiple > highestMultiple)
                    highestMultiple = multiple;
                multiple = 1;
            }
            return highestMultiple;
        }
    }
}

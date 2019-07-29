using System;

namespace ElephantCarpaccio
{
    class Program
    {
        static void Main(string[] args)
        {
            string read;
            double itemSum=0, tax=1;
            int itemNumber;
            Console.Write("Enter the number of bought products: ");
            read = Console.ReadLine();
            itemNumber = Int32.Parse(read);
            for(int i=0; i<itemNumber; i++)
            {
                Console.Write("Please enter the price of the product number " + (i+1) + ": ");
                read = Console.ReadLine();
                itemSum += double.Parse(read);
            }
            Console.Write("Please enter your state code: ");
            read = Console.ReadLine();
            switch(read)
            {
                case "UT":
                    tax = 1.2;
                    break;
                case "PH":
                    tax = 1.25;
                    break;
                case "AR":
                    tax = 1.28;
                    break;
                case "OR":
                    tax = 1.33;
                    break;
                case "OK":
                    tax = 1.17;
                    break;
            }
            itemSum = itemSum * tax;
            if (itemSum > 200)
            {
                Console.WriteLine("Your price before discount: " + itemSum);
                Console.WriteLine("Your discount: 15%");
                itemSum = itemSum * 0.85;
            }
            else if (itemSum > 150)
            {
                Console.WriteLine("Your price before discount: " + itemSum);
                Console.WriteLine("Your discount: 12.5%");
                itemSum = itemSum * 0.875;
            }
            else if (itemSum > 100)
            {
                Console.WriteLine("Your price before discount: " + itemSum);
                Console.WriteLine("Your discount: 10%");
                itemSum = itemSum * 0.9;
            }
            else if (itemSum > 50)
            {
                Console.WriteLine("Your price before discount: " + itemSum);
                Console.WriteLine("Your discount: 7%");
                itemSum = itemSum * 0.93;
            }
            else if (itemSum > 25)
            {
                Console.WriteLine("Your price before discount: " + itemSum);
                Console.WriteLine("Your discount: 4%");
                itemSum = itemSum * 0.96;
            }
            Console.WriteLine("Your total cost: " + itemSum);

        }
    }
}

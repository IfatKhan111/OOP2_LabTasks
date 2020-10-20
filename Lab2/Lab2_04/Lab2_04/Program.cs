using System;

namespace Lab2_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, sumOfEven = 0;
            int sumOfOdd = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 ==0)
                {
                    sumOfEven += i;
                }
                else
                {
                    sumOfOdd += i;
                }
            }
            Console.WriteLine("\nSum of even number from 1 to 100 is " + sumOfEven);
            Console.WriteLine("\nSum of odd  number from 1 to 100 is " + sumOfOdd);
        }
    }
}

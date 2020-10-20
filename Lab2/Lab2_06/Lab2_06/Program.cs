using System;

namespace Lab2_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number: ");
            long n = Convert.ToInt32(Console.ReadLine());
            long answer = 1;
            for (int i = 1; i <= n; i++)
            {
                answer *= i;
            }
            Console.WriteLine("The factorial of "+ n +" is: " + answer);
        }
    }
}

using System;

namespace Lab2_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, a = 0;
            Console.Write("---------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number n : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe even numbers from 1 to n are : ");
            for (i = 1; i <= n; i++)
            {
                a = 2 * i;
                if (a <= n)
                {
                    Console.Write(a + " ");
                }
            }
        }
    }
}

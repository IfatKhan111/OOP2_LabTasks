using System;

namespace Lab2_03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j < i + 5; j++)
                {
                    Console.Write(j);
                }

                Console.Write("\n");
            }
        }
    }
}

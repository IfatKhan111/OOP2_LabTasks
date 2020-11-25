using System;

namespace Final_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(" Sum = " + c.sum(10,5));
            Console.WriteLine(" Sub = " + c.sub(10,5));
            Console.WriteLine(" Multiplication = " + c.multiplication(10,5));
            Console.WriteLine(" Division = " + c.division(10,5));
            Console.WriteLine(" Power = " + c.XtoY(10,5));
            Console.WriteLine(" Factorial = " + c.factorial(5));
        }
    }
}

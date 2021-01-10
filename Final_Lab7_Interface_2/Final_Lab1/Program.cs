using System;

namespace Final_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a0 = new Savings();
            Account a1 = new Savings("Ifat Khan", 113234,20000);

            SpecialSavings s1 = new SpecialSavings(30);
            Account a2 = new SpecialSavings("Sohel Hossain", 343345,10000,25);

            Account a3 = new Fixed("Ifat Khan", 813444,8000);

            Account a4 = new Overdraft(2000);
            Overdraft od1 = new Overdraft("Ifat Khan", 224234,12500,4000);
        }
    }
}

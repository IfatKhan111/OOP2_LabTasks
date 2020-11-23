using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Lab1
{
    class SpecialSavings : Account
    {
        public SpecialSavings(int MaxNumofTransaction) : base()
        {
            this.MaxNumOfTransaction = MaxNumOfTransaction;
        }
        public SpecialSavings(string name, int? accNo, double balance,int MaxNumOfTransactions) : base(name, accNo,balance)
        {
            this.MaxNumOfTransaction = MaxNumOfTransaction;
        }
        public override void Withdraw(double amount)
        {
            if (numOfTransaction <= MaxNumOfTransaction && Balance - amount >= amount * 20 / 100)
            {
                Balance -= amount;
                numOfTransaction++;
            }
            else
            {
                Console.WriteLine("Given amount exceeds the minimum balance");
            }
        }
    }
}

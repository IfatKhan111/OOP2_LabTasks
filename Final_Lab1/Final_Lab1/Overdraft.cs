using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Lab1
{
    class Overdraft : Account
    {
        double overdraftLimit;

        public Overdraft(double overdraftLimit) : base()
        {
            this.overdraftLimit = overdraftLimit;
        }
        public Overdraft(string name, int? accNo, double balance,double overdraftLimit) : base(name, accNo, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount)
        {
            if (amount <= Balance + overdraftLimit)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Amount exceeds the limit!");
            }
        }
    }
}

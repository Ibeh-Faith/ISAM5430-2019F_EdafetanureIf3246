using System;
using System.Collections.Generic;
using System.Text;

namespace HW05
{
    class Account
    {
        private double balance;
        public Account(double initialBalance)
        {
            if (initialBalance > 0.0)
                balance = initialBalance;
        }

        public void credit(double amount)
        {
            balance = balance + amount;
        }
        public void debit(double amount)
        {
            if (amount > balance)
                Console.WriteLine("Withdrawal amount exceeded account balance");
            else balance = balance - amount;
        }

        public double getBalance()
        {
            return balance;
        }
    }

}

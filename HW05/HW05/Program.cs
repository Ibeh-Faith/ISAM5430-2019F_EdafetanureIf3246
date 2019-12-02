using System;

namespace HW05
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(50.00);

            Console.WriteLine("account balance is " + account.getBalance());

            Console.WriteLine("enter withdrawal amount");
            double withdrawamount = double.Parse(Console.ReadLine());
            account.debit(withdrawamount);

            Console.WriteLine("the balance is " + account.getBalance());
        }
    }
}

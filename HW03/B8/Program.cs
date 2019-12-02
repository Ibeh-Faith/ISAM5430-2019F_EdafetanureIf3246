using System;
using static System.Console;

namespace B8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int sum = 0;
            int reverse = 0;
            int rem = 0;
            WriteLine("enter first number");
            num1 = int.Parse(ReadLine());
            WriteLine("enter second number");
            num2 = int.Parse(ReadLine());

            if (num1>=0 && num2 >= 0)
            {
                sum = num1 + num2;

                while (sum != 0)
                {
                    rem = sum % 10;
                    reverse = reverse * 10 + rem;
                    sum /= 10;
                }

                WriteLine($"the reverse of the sum is : {reverse}");
            }
        }
    }
}

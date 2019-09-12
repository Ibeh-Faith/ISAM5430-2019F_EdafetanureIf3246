using System;
using static System.Console;

namespace C._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int fact = 1;
            while (i <= 6)
            {
                fact = fact * i;
                WriteLine(fact + " ");
               
            }
            i = i + 1;


            // 12

            int num1 = 0;
            int num2 = 1;
            int sum = 1;

            WriteLine(num1);
            WriteLine(num2);
            while (num1 <= 25000)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                WriteLine(num2);
            }

        }
    }
}

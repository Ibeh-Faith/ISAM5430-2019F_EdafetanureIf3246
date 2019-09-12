using System;
using static System.Console;

namespace C4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter your count");
            int count = int.Parse(ReadLine());
            int num=0;
            decimal sum=0;
            int input = 0;
            decimal average;
            while (num < count)
            {
                WriteLine($"input the {count} numbers");
                input = Convert.ToInt32(ReadLine());

                sum = sum+ input;
                num=num + 1;
            }
            

            average =(decimal) sum / count;
            WriteLine($"the sum of {count} number is : {sum} the average is : {average}");
        }
    }
}

using System;
using static System.Console;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            //print enter the first number
            WriteLine("Enter the first number");
            //input the first number
            int first = int.Parse(ReadLine());
            //print enter the second number
            WriteLine("Enter the second number");
            //input the second number
            int second = Convert.ToInt32(ReadLine());
            //if the first number > second number
            if (first > second)
            {
                //print the first number
                WriteLine(first);
            }
            //else if the second number > first number
            else if (second > first)
            {
                //print second number
                WriteLine(second);
            }
            //else
            else
            {
                //print both are the same
                WriteLine("both are the same");
            }
        }
    }
}

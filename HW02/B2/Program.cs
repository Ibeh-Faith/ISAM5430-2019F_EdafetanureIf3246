using System;
using static System.Console;

namespace B2
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
            //print enter the third number number
            WriteLine("Enter the third number");
            //input the second number
            int third = Convert.ToInt32(ReadLine());

            /* if second number > first number and first number is > third number 
            or if third number > first number and first number >second number */

            if (second > first && first > third || third > first && first > second)
            {
                WriteLine("The first is the middle number");
            }
            else if (first > second && second > third || third > second && second > first)
            {
                WriteLine("The second is the middle number");
            }
            else
            {
                WriteLine("The third is the middle number");
            }

        }
    }
}


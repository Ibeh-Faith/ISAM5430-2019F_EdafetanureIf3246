using System;
using static System.Console;

namespace B7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int reverse = 0;
            int rem = 0;
            WriteLine("enter number");
            num= int.Parse(ReadLine());

            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
                
            }

            WriteLine($"the reverse the num is : {reverse}");
        }
    }
}

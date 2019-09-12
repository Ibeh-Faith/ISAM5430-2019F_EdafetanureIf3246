using System;
using static System.Console;

namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {
            //8

            int num1 = 1;
            int sum = 1;

            WriteLine(num1);
            while (num1 <= 60)
            {
                sum = num1 * 2;
                num1 = sum;
                
                WriteLine(num1);
            }

            // 9
            num1 = 100;
            sum = 1;
            WriteLine(num1);
            while (num1 >= 1)
            {
                sum = num1 / 2;
                num1 = sum;

                WriteLine(num1);
            }
            num1 = num1 - 1;


            //10

            double numb = 100;
            double cal = 1;
            WriteLine(numb);
            while (numb >= 1)
            {
                cal = numb / 2;
                numb = cal;

                WriteLine(numb);
            }
            numb = num1 - 1;
        }
    }
}

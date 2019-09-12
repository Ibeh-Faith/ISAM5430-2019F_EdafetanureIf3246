using System;
using static System.Console;
namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1

            int num = 20;
            while (num >= 1)
            {
                WriteLine(num);
                num = num - 1;
               
            }
            

            // 2

            num = 1;
            while (num <= 10)
            {
                if (num % 2 == 0)
                {
                    WriteLine(num);
                }
                num = num + 1;
            }

            // 3

            num = 1;
            while (num < 100)
            {
                if (num % 10 == 0)
                {
                    WriteLine(num);
                }
                num = num + 1;
            }

            // 4
           
            num = 1;
            while (num <= 20)
            {
                if (num % 2 !=0 && num % 3 != 0)
                {
                    WriteLine(num);
                }
                num = num + 1;
            }
           
            // 5

            num = 1;
            while (num < 100)
            {
                if (num * num >=10 && num * num < 100)
                {
                    WriteLine(num * num);
                }
                num = num + 1;
            }

            // 7

            /* Char letter = Char.ToLower('a');
             while (letter <= 'z')
             {
                 WriteLine(letter);
                 letter = letter++;
             }
             */
            for (char letter = char.ToLower('a'); letter <= 'z'; letter++)
            {
                WriteLine(letter);
            }
        }
    }
}

using System;
using static System.Console;

namespace C11
{
    class Program
    {
        static void Main(string[] args)
        {
            int tbl = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0}*{1}={2}", i, j, (i * j));
     }
            }
            Console.ReadLine();
        }
    }
}

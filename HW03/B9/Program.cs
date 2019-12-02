using System;
using static System.Console;

namespace B9
{
    class Program
    {
        static void Main(string[] args)
        {
            string binary = null;
            string bit;
            int r = 0;
            WriteLine("enter a positive integer");
            int i = int.Parse(ReadLine());
            while (i != 0)
            {
                r= i % 2;
                bit = r.ToString();
                i = i / 2;
                binary = bit + binary;
            }
            WriteLine($"the binary number of the positive integer is: {binary}");
        }
    }
}

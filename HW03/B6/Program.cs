using System;
using static System.Console;

namespace B6
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int i = 1;
            int count = 0;
            string output="";
            WriteLine("Enter input");

            while (i > 0)
            {
                count++;
                i = int.Parse(ReadLine());

                if (i < min)
                {
                    min = i;
                }
                else if (min * min <= i)
                {
                    output += i + "|";
                    WriteLine("count: " + count + "\n output: " + output);
                    WriteLine("\n Enter new set: ");
                    i = 1;
                    count = 0;
                    min = int.MaxValue;
                }
                if (count != 0)
                {
                    output += i + ",";
                }
            }
            WriteLine("\n Final output: " + output);

        }
    }
}

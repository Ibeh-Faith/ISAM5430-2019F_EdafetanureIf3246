using System;
using static System.Console;

namespace C10
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    Write("X");
                }
                WriteLine();
            }
        }
    }
}

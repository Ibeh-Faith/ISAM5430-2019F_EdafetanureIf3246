using System;
using static System.Console;

namespace C16
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int n = 0;
            int z = 0;


            WriteLine("enter input:");
            int i = int.Parse(ReadLine());
            for (n = 1; n <= i; n++)
            {
                for(a=1; a<=i-n; a++)
                {
                    Write("0" + ",");
                }
                for (a = n; a >= 1; a--)
                { 
                    
                Write(a + ",");
                }
                WriteLine("");




            }
        }
    }
}

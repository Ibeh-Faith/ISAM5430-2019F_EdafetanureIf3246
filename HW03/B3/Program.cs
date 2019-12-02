using System;
using static System.Console;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int prevnum = 0;
            int largest = int.MinValue;

            

           while (true)
            {
                WriteLine("enter input:");
                int a = int.Parse(ReadLine());
                num++;
                
                if (a < prevnum)
                {
                    break;
                }
                else
                {
                    prevnum = a;
                }
                if (a > largest)
                {
                    largest = a;
                }
                
                
            }
            WriteLine($"the largest value is: {largest}");






















            //while (true)
            //{
            //    WriteLine("input num:");
            //    num = int.Parse(ReadLine());

            //    prevnum = a;
            //    distance = a - prevnum;
            //    distanceprev = distance;
            //    if (distance > distanceprev)
            //    {
            //        maxdistance = distance;
            //    }
            //}

        }
        
    }
}

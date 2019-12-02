using System;
using static System.Console;

namespace HW03
{
    class Program
    {
        static void Main(string[] args)
        {

            //B1

            decimal sum = 0;
            int count = 0;
            decimal average = 0;
            int num = 0;
            string n = null;
            int nn = 0;
            int max = int.MinValue;

            for(int i=0; i<=100; i++)
            {
                WriteLine("input:");
                 i = int.Parse(ReadLine());
                sum = sum + i;
                count++;

               
                if (i<0 || i > 100)
                {
                   
                    break;
                }

                if (i > max)
                {
                    max = i;
                }
                
            }
            average = (decimal)sum / count;
            WriteLine("the average is: " + average);
            WriteLine("the highest score is: " + max);

            //while (true)
            //{
            //    WriteLine("enter input:");
            //    num = int.Parse(ReadLine());
            //    if (num < 0 && num > 100)
            //    {
            //        break;
            //    }
            //    else if(num>=0 && num <=100)
            //    {
            //        sum = sum + num;
            //        count++;


            //    }
            //}
            //average = (decimal)sum / count;
            //WriteLine("the average is: " + average);

        }
    }
}


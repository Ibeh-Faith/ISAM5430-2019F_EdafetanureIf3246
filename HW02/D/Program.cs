using System;
using static System.Console;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count");
            int count = int.Parse(Console.ReadLine());

            //i=0
            int i = 0;
            //min=largest possible 
            int min = int.MaxValue;
            //max=smallest possible
            int max = int.MinValue;
            int positive=0;
            int zero=0;
            int even=0;
            string increasing = "";
            while (i < count)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)
                {
                    positive = num ++;
                }
                if (num == '0')
                {
                    zero = i ++;
                }
                if (num % 2 == 0)
                {
                    even = num;
                }
                
                if (num < min)
                {
                    //replace min with the num
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
              
                if(num < (num + 1))
                {
                    increasing="The numbers are in increasing order";
                }
                if (num >(num +1))
                {
                    increasing="They are not in increasing order ";
                }

                //for (i=0; i<count/2; i++)
                //{
                //    int ca = 0;
                //    int cb = 0;
                    
                //}
                i = i + 1;
            }
            //N, P, C,
            Console.WriteLine($"The largest number is {max:N0} and the smallest number is {min:N0}.");
            WriteLine($"the positive numbers are {positive}");
            WriteLine($"the zero numbers are {zero}");
            WriteLine($"the even numbers are {even}");
            WriteLine(increasing);
            // print out the maximum valyue with thousand-commas and no decimal places(0)
        }
    }
}

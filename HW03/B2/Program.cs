using System;
using static System.Console;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {


            int sum = 0;
            int num = 0;
            int prevnum = -1;
            int i = 0;


            while (true)
            {
                WriteLine("input:");
                 i = int.Parse(ReadLine());
                num++;
               
                if (i== prevnum)
                {
                    break;
                }

                else
                {
                    sum = sum + i;
                    prevnum = i;
                }
                
            }
            WriteLine("the sum is: " + sum);
        }
            }
            }



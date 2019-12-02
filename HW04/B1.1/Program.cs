using System;
using static System.Console;

namespace B1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sum2 = 0;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                        sum2 += i * j;
                        WriteLine($"{i}, {j}");

                    }
                    else
                    {
                        continue;
                    }
                }
            }
            WriteLine("the sum for 2 number permutation is " + sum2);

           
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                        
                        for (int z = 1; z <= 5; z++)
                        {
                            if (i != z && j != z)
                            {
                                sum += i * j * z;
                                WriteLine($"{i}, {j}, {z}");

                            }
                            else
                            {
                                continue;
                            }

                        }

                    }
                    else
                    {
                        continue;
                    }
                }
            }
            WriteLine("the sum is " + sum);
          

        }
    }
}
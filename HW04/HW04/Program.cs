using System;
using static System.Console;

namespace HW04
{
    class Program
    {
        static void Main(string[] args)
        {
            int product = 0;
            int product3 = 0;
            int product4 = 0;
            int product5 = 0;


            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j && j > i)
                    {
                        product += i * j;
                        WriteLine($"{i}, {j}");
                    }

                    else
                    {
                        continue;
                    }
                }
            }
            WriteLine("the product for 2 number combination is " + product);
            //for three numbers

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j && j > i)
                    {
                        for (int k = 1; k <= 5; k++)
                        {
                            if (i != k && j != k && k > j)
                            {
                                product3 += i * j * k;
                                WriteLine($"{i}, {j}, {k}");
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
            WriteLine("the product for 3 number combination is " + product3);

            //for four numbers
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j && j > i)
                    {
                        for (int k = 1; k <= 5; k++)
                        {
                            if (i != k && j != k && k > j)
                            {

                            for (int m=1; m<=5; m++)
                                {
                                    if (i != m && j != m && k !=m && m > k)
                                    {
                                        product4 += i * j * k * m;
                                        WriteLine($"{i}, {j}, {k}, {m}");
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
                    else
                    {
                        continue;
                    }
                }
            }
            WriteLine("the product for 4 number combination is " + product4);
            //for five numbers
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j && j > i)
                    {
                        for (int k = 1; k <= 5; k++)
                        {
                            if (i != k && j != k && k > j)
                            {

                                for (int m = 1; m <= 5; m++)
                                {
                                    if (i != m && j != m && k != m && m > k)
                                    {

                                        for(int n=1; n<=5; n++)
                                        {
                                            if(i != n && j != n && k != n && m !=n && n > m)
                                            {
                                                product5 += i * j * k * m * n;
                                                WriteLine($"{i}, {j}, {k}, {m}, {n}");
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
            WriteLine("the product for 5 number combination is " + product5);
        }
    }
}

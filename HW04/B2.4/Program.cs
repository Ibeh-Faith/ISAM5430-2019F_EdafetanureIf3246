using System;
using static System.Console;

namespace B2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            for(char a='A'; a<='H'; a++)
            {
                for (char b = 'A'; b <= 'H'; b++)
                {
                    
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        Write($"{a}{b}{c} ");
                    }
                }
            }
            WriteLine();
            WriteLine();
            //b
            for (char a = 'A'; a <= 'H'; a++)
            {
                for (char b = 'A'; b <= 'H'; b++)
                {
                    if (b=='A' || b == 'E')
                    {

                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        Write($"{a}{b}{c} ");
                    }
                }
                    else
                    {
                        continue;
                    }
                }
            }
            WriteLine();
            WriteLine();

            //c
            for (char a = 'A'; a <= 'H'; a++)
            {
                for (char b = 'A'; b <= 'H'; b++)
                {
                    for (char c = 'A'; c <= 'H'; c++)
                    {

                        if (((a == 'A' || a == 'E') && !(b == 'A' || b == 'E') && (c == 'A' || c == 'E')) ||
                               (!(a == 'A' || a == 'E') && (b == 'A' || b == 'E') && (c == 'A' || c == 'E')) ||
                              (!(a == 'A' || a == 'E') && (b == 'A' || b == 'E') && !(c == 'A' || c == 'E'))||
                                ((a == 'A' || a == 'E') && !(b == 'A' || b == 'E') && (c == 'A' || c == 'E')))
                        {
                            Write($"{a}{b}{c} ");
                        }
                        else
                        {
                            continue;
                        }
                }
                }
            }
            WriteLine();
            WriteLine();

            // d

            for (char a = 'A'; a <= 'H'; a++)
            {
                for (char b = 'A'; b <= 'H'; b++)
                {
                    if (b == 'A' || b == 'E')
                    {

                        for (char c = 'A'; c <= 'H'; c++)
                        {

                            if (a != c && a!=b && b!=c)
                            {

                            
                            Write($"{a}{b}{c} ");
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
            
        }
    }
}

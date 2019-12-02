using System;
using static System.Console;

namespace b5
{
    class Program
    {
        static void Main(string[] args)
        { 
            //a

            for (char a = 'A'; a <= 'H'; a++)
            {
                bool vowelA = a == 'A' || a == 'E';

                for (char b = 'A'; b <= 'H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';
                    int vowels2 = (vowelA ? 1 : 0) + (vowelB ? 1 : 0);
                    if (vowels2 >= 1)
                    {
                        Write($"{a}{b} ");
                    }
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        bool vowelC = c == 'A' || c == 'E';
                        int vowels = vowels2 + (vowelC ? 1 : 0);

                        if (vowels == 1 || vowels == 2)
                            Write($"{a}{b}{c}  ");

                    }
                }
            }
            WriteLine();
            WriteLine();
            //b

            for (char a = 'A'; a <= 'H'; a++)
            {
                bool vowelA = a == 'A' || a == 'E';

                for (char b = 'A'; b <= 'H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';
                    int vowels2 = (vowelA ? 1 : 0) + (vowelB ? 1 : 0);
                    if (vowels2 >= 1 &&(!(a=='A' || a=='E') && (b == 'A' || b == 'E')))
                    {
                        Write($"{a}{b} ");
                    }
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        bool vowelC = c == 'A' || c == 'E';
                        int vowels = vowels2 + (vowelC ? 1 : 0);

                        if ((vowels == 1 || vowels == 1) && (!(a == 'A' || a == 'E') && (c == 'A' || c == 'E')))
                            Write($"{a}{b}{c}  ");

                    }
                }
            }
            WriteLine();
            WriteLine();

            //c

            for (char a = 'A'; a <= 'H'; a++)
            {
                bool vowelA = a == 'A' || a == 'E';

                for (char b = 'A'; b <= 'H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';
                    int vowels2 = (vowelA ? 1 : 0) + (vowelB ? 1 : 0);
                    if (vowels2 >= 1)
                    {
                        Write($"{a}{b} ");
                    }
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        bool vowelC = c == 'A' || c == 'E';
                        int vowels = vowels2 + (vowelC ? 1 : 0);

                        if ((vowels == 1 || vowels == 2) && (b == 'A' || b == 'E') && !(a == c || a == b || b == c))
                            Write($"{a}{b}{c}  ");

                    }
                }
            }
        }
    }
}


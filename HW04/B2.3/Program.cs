using System;
using static System.Console;

namespace B2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // a

            for(char a='A'; a<='H'; a++)
            {
                for (char b='A'; b<='H'; b++)
                {
                    if (a=='A' || a=='E' || b=='A' || b == 'E')
                    {
                        Write($"{a}{b} ");
                    }
                }
            }
            WriteLine();
            for (char a = 'A'; a <= 'H'; a++)
            {
                for (char b = 'A'; b <= 'H'; b++)
                {
                    if(((a == 'A' || a == 'E') && !(b == 'A' || b == 'E'))||(!(a == 'A' || a == 'E') && (b == 'A' || b == 'E')))
                    { 
                       
                        Write($"{a}{b} ");
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            WriteLine();
            //c
            for(char a='A'; a<='H'; a++)
            {
                for(char b='A'; b<='H'; b++)
                {
                    if(!(a=='A' || a== 'E') && (b=='A' || b=='E'))
                    {
                        Write($"{a}{b} ");
                    }
                }
            }

        }
    }
}

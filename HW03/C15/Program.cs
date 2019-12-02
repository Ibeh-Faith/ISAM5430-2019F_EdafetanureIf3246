using System;
using static System.Console;

namespace C15
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 0;
            int n = 0;
        
            WriteLine("enter input:");
            int i = int.Parse(ReadLine());
            for(n=0; n<=i; n++)
            {
                for(a=1; a<n+1; a++)
                
                    Write (a + ",");
                WriteLine();
                   
                }

            }

        }
    
}

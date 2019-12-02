using System;
using static System.Console;

namespace C12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int count = 0;
            WriteLine("Enter a number");
            num = int.Parse(ReadLine());

            for(int i=1; i<=num; i++)
            {
                count = 0;
                for(int j=2; j<=i/2; j++)
                {
                    if(i%j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if(count==0 && i != 1)
                {
                    WriteLine(i);
                }
            }


        }
    }
}




















//WriteLine("the prime numbers are: 2");
//WriteLine("the prime numbers are: 3");
//WriteLine("the prime numbers are: 5");
//WriteLine("the prime numbers are: 7");
//while (a < num)
//{
//    a++;
//    num1 = num / 2;
//    num1++; 
//    if (a%num1!=0  && a!= 0 && a!=1 && a%2!=0 && a%3!=0 && a%5!=0 && a%7!=0)
//    {

//        WriteLine("the prime numbers are: " + a);
//        num = num++;
//    }


//}




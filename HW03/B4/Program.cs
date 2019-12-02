using System;
using static System.Console;

namespace B4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("enter first side");
            int side1 = int.Parse(ReadLine());
            WriteLine("enter second side");
            int side2 = int.Parse(ReadLine());
            WriteLine("enter third side");
            int side3 = int.Parse(ReadLine());

            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                WriteLine("stop");
            }


            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                WriteLine("this is a valid triangle");
            }
            else
            {
                WriteLine("this is not a valid triangle");
            }
        }
            }
        }
    



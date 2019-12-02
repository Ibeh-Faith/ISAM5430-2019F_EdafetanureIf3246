using System;
using static System.Console;

namespace B5
{
    class Program
    {
        static void Main(string[] args)
        {
            int item = 0;
            int distance = 0;
            int prevnum = 0;
            int closestnum = 0;
            int num = 0;
            int count = 0;
            int closestdistance = int.MaxValue;

            WriteLine("enter an item");
            item = int.Parse(ReadLine());

            while (true)
            {
                WriteLine("enter input");
                num = int.Parse(ReadLine());
                if (num == item)
                {
                    break;
                }
                else
                {
                    count++;

                    prevnum = num;
                    distance = item - prevnum;
                    if (distance < closestdistance)
                    {
                        closestnum = prevnum;
                    }
                    closestdistance = distance;

                }
                WriteLine($"the closest distance is {closestdistance} and closest num is: {closestnum}");
            }
        }
    }
}

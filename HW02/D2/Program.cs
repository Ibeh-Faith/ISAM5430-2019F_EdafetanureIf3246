using System;
using static System.Console;

namespace D2
{
    class Program
    {
        static void Main(string[] args)
        {

            //8 and 9

            int[] array = { 1, 2, 2, 3, 4, 4, 6, 6 };
            int count = 0;
            bool ans = false;
            int sol = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] == array[i] && !ans)
                {
                    ans = true;
                    count = count + 1;
                    sol = array[i]++;
                    WriteLine("the clump is " + sol);
                }
                else if (array[i + 1] != array[i])
                {
                    ans = false;
                }
            }
            WriteLine("The number of clump is " + count);

            //10

            int[] numb = { 1, 1, 5, 5, 10, 8, 7 };
            int countt = 0;
            int sum = 0;
            for (int i = 1; i < numb.Length - 1; i++)
            {
                sum += numb[i];
                countt++;
                int item = sum / countt;
                WriteLine("the centered average is " + item);
            }

            int[] nums = { 2, 2, 4, 2 };
            int index = 0;
            for (int i = 0; i < (nums.Length); i++)
            {
                if (nums[i] == 2)
                {
                    i++;
                    if (!(i < (nums.Length)) || nums[i] == 2)
                    {
                        WriteLine("two is not next to two " + false);
                    }
                    if (i < nums.Length && nums[i] == 2 && nums[i + 1] != 2 && nums[i] == 2)
                    {
                        WriteLine("two is not next to two " + false);
                    }

                    while (i < nums.Length && nums[i] == 2)
                        i++;

                    WriteLine("two is next to two " + true);
                }
            }
          
        }
    }
}











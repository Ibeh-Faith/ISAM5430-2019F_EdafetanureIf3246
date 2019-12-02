using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments
{
    public class ArrayCreation
    {
        /// <summary>
        /// Given a number n, create and return a new int array of length n, containing the numbers 0, 1, 2, ... n-1. The given n may be 0, in which case just return a length 0 array. You do not need a separate if-statement for the length-0 case; the for-loop should naturally execute 0 times in that case, so it just works. The syntax to make a new int array is: new int[desired_length] 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int[] FizzArray(int number)
        {
            int[] arr = new int[number];

            for (int i = 0; i < number; i++)

                arr[i] = i;

            return arr;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a number n, create and return a new string array of length n, containing the strings "0", "1" "2" .. 
        /// through n-1. N may be 0, in which case just return a length 0 array.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string[] FizzArray2(int number)
        {
            string[] result = new string[number];
            for (int i = 0; i < number; i++)
            result[i] = Convert.ToString(i);
            return result;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given start and end numbers, return a new array containing the sequence of integers from start up to but not including end, so start=5 and end=10 yields {5, 6, 7, 8, 9}. The end number will be greater or equal to the start number. Note that a length-0 array is valid.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public int[] FizzArray3(int start, int end)
        {
            int n = end - start;
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
             result[i] = start++;
            return result;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given n>=0, create an array length n*n with the following pattern, shown here for n=3 : {0, 0, 1,    0, 2, 1,    3, 2, 1} (spaces added to show the 3 groups).
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int[] SquareUp(int number)
        {
            int[] result = new int[number * number];
            int x = number - 1, pass = 1, index = 0;
            if (number == 0) { return result; }
          for (int i = number - 1; i < result.Length; i += number)
            {
           index = i;
          for (int k = 1; k <= pass; k++)
                {
          if (k == 0) { break; }
          result[index] = k;
          index--;
          }
         pass++;
        }
        return result;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given n>=0, create an array with the pattern {1,    1, 2,    1, 2, 3,   ... 1, 2, 3 .. n} (spaces added to show
        /// the grouping). Note that the length of the array will be 1 + 2 + 3 ... + n, which is known to sum to exactly
        /// n*(n + 1)/2.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int[] SeriesUp(int number)
        {
            int[] result = new int[number * (number + 1) / 2];
              int i = 0;
              for (int j = 1; j <= number; ++j)
                for (int k = 1; k <= j; ++k)
                  result[i++] = k;
                return result;
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method will simply return a new subarray that is in the original array, 
        /// containing values from the first index to the last index.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="firstIndex"></param>
        /// <param name="lastIndex"></param>
        /// <example>If your array is { 2, 4, 6, 8, 10, 1, 3, 5, 7} and if the first index is 3 and the last index is 5, 
        /// the method will return a new array, {8, 10, 1}. </example>
        /// <returns>the subarray</returns>
        public int[] Subarray(int[] array, int firstIndex, int lastIndex)
        {
            if(array==null || array.Length==0) return array;
            int[] sub = { };
            if(firstIndex>=0 && firstIndex<array.Length&& lastIndex>=0 && lastIndex < array.Length)
            {
                sub = new int[lastIndex - firstIndex + 1];

                for(int i= firstIndex, j=0; i<=lastIndex; i++, j++)
                {
                    sub[j] = array[i];
                }
            }
            return sub;
            //int[] result = new int[lastIndex-firstIndex+1];
            //for (int i = firstIndex; i < lastIndex + 1; i++)
            //    result[i - firstIndex] = array[i];
            //return result;
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method will simply create and return a copy of the original array by calling the Subarray method. 
        /// </summary>
        /// <param name="array"></param>
        /// <seealso cref="Subarray(int[], int, int)"/>
        /// <returns></returns>
        public int[] Copyarray(int[] array)
        {
            int[] result = Subarray(array, 3, 5);
            return result;
            throw new NotImplementedException();
        }
    }
}
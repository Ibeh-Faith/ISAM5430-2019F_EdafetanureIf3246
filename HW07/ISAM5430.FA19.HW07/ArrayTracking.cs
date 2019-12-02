using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharp.Assignments
{
    public class ArrayTracking
    {
        /// <summary>
        /// Find the minimum value of the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns>min value, or if the array is null or empty, simply return 0</returns>
        public int MinValue(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return 0;
            }
            int min = array[0];
            for (int i = 0; i <= array.Length-1; i++)
            {
                if (array[i]< min)
                {
                    min = array[i];
                }
            }
            return min;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find the maximum value of the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns>the last element, or 0 if the array is empty or null</returns>
        public int MaxValue(int[] array)
        {
            
            if (array == null || array.Length == 0)
            {
                return 0;
            }
        
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    
                }

            }return max;
            
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find an element in the array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="item"></param>
        /// <returns>Index of the element; -1 if not found.</returns>
        public int NeedleInHaystack(int[] array, int item)
        {
            if (array == null)
            {
                return -1;
            }
            int len = array.Length;
            int i = 0;
            while (i < len)
            {
                if (array[i] == item)
                {
                    return i;
                }
                else
                {
                    i = i + 1;
                }
            }
            return -1;
            throw new NotImplementedException();
        } 
                   

        /// <summary>
        /// Find the int that's closest to your item
        /// </summary>
        /// <param name="array"></param>
        /// <param name="item"></param>
        /// <returns>The value of the element that's closest to yours. 0 if not found.</returns>
        public int ClosestItem(int[] array, int item)
        {
            if (array == null || array.Length == 0)
            {
                return 0;
            }
            int closest = array[0];
            int mindiff = array[0] > item ? array[0] - item : item - array[0];
            for(int i=0; i<array.Length; i++)
            {
                if (item == array[i])
                {
                    return item;
                }
                int diff = array[i] > item ? array[i] - item : item - array[i];
                if (mindiff > diff)
                {
                    mindiff = diff;
                    closest = array[i];
                }
            }
            return closest;
            throw new NotImplementedException();
        } 
  
            
        

        /// <summary>
        /// Returns the farthest item from the array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="item"></param>
        /// <returns>The value of the element that's the farthest from your item; 0 if the array is null or empty</returns>
        public int FarthestItem(int[] array, int item)
        {
            if (array == null || array.Length == 0)
            {
                return 0;
            }
            int farthest = array[0];
            int maxdiff =  array[0] > item ? array[0] - item : item - array[0];
            for (int i = 0; i < array.Length; i++)
            {
                int diff =  array[i] > item ? array[i] - item : item - array[i]; 
                if (diff > maxdiff)
                {
                    maxdiff = diff;
                    farthest = array[i];
                }
            }
            return farthest;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determine the h-index (Hirsch Index), in which there are at least h values in the array c that are greater than
        /// or equal to h. 
        /// </summary>
        /// <param name="c">This array represents the number of citations referenced to author's papers published in chronological order.</param>
        /// <remarks>The h-index is an author-level metric that attempts to measure both the productivity and citation impact of the publications of a scientist or scholar. The index is based on the set of the scientist's most cited papers and the number of citations that they have received in other publications. The index can also be applied to the productivity and impact of a scholarly journal[1] as well as a group of scientists, such as a department or university or country. The index was suggested in 2005 by Jorge E. Hirsch, a physicist at UCSD, as a tool for determining theoretical physicists' relative quality and is sometimes called the Hirsch index or Hirsch number.</remarks>
        /// <seealso>https://en.wikipedia.org/wiki/H-index</seealso>
        /// <returns></returns>
        public int HirschIndex(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                Array.Sort(array);
                int h = 0;
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    int num = array[i];
                    if (num > h)
                    {
                        h++;
                    }
                    else
                    {
                        return h;
                    }
                }
                return h;
            }
            return -1;
            //for (int h = array.Length; h > 0; h--)
            //{
            //    if (array == null && array.Length == 0)
            //    {
            //        return 0;
            //    }
            //        int count = 0;
            //        for (int i = 0; i < array.Length; i++)
            //        {
            //            if (array[i] >= h)
            //            {
            //                count++;
            //            }
            //        }
            //        if (count >= h)
            //        {
            //            return h;
            //        }
            //    }
            //return 0;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array of ints, return the difference between the largest and smallest values in the array.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>The big difference; return 0 if array is null or empty.</returns>
        public int BigDiff(int[] array)
        {
          int min = array[0];
          int max = array[0];
          for (int i = 0; i < array.Length; i++)
                    {
            min = Math.Min(min, array[i]);
            max = Math.Max(max, array[i]);
          }
          return max - min;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return true if the group of N numbers at the start and end of the array are the same. You may assume that n is in 
        /// the range 0..nums.length inclusive.
        /// </summary>
        /// <example>For example, with {5, 6, 45, 99, 13, 5, 6}, the ends are the same for n=0 and n=2, and false for n=1 and n=3.</example>
        /// <param name="array">given array of ints</param>
        /// /// <param name="n">group of n numbers</param>
        /// <returns></returns>
        public bool SameEnds(int[] array, int n)
        {
            bool foo = true;
           
            for (int i = 0; i < n; i++)
                    {
            if (array[i] == array[array.Length - n + i])
                foo = true;
            else
                foo = false;
            }
            return foo;
            throw new NotImplementedException();
        }

        /// <summary>
        /// We'll say that a value is "everywhere" in an array if for every pair of adjacent elements in the array, at least one
        /// of the pair is that value. Return true if the given value is everywhere in the array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsEverywhere(int[] array, int value)
        {
         bool result = true;
        for (int i = 0; i <= array.Length - 2; i++)
        {
        if (array[i] != value && array[i + 1] != value)
        result = false;
        }
          return result;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return the "centered" average of an array of ints, which we'll say is the mean average of the values, except ignoring 
        /// the largest and smallest values in the array. If there are multiple copies of the smallest value, ignore just 
        /// one copy, and likewise for the largest value. Use int division to produce the final average. You may assume that 
        /// the array is length 3 or more.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int CenteredAverage(int[] array)
        {
          int min = array[0];
          int max = array[0];
          int sum = 0;
          for (int i = 0; i < array.Length; i++)
                    {
            sum += array[i];
            min = Math.Min(min, array[i]);
            max = Math.Max(max, array[i]);
          }
          sum = sum - max - min;
          sum = sum / (array.Length - 2);
          return sum;
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method will return the average of all the even numbers that are NOT next to another even number. If there is no such number in the array or if the array is invalid, the method will simply return a zero.
        /// </summary>
        /// <returns>The even average.</returns>
        /// <param name="nums">Nums.</param>
        public double AloneEvenAverage(int[] nums)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array, return an array of positive values, where these values have been repeated exactly the number of times given by the respective value.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>There should always be an array</returns>
        public int[] RepeatedTimes(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return new int[0];
            }
            int[] r = new int[array.Length];
            int length = 0;
            for (int n = 1; n <= array.Length; n++)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == n)
                    {
                        count++;
                    }
                }
                if (count == n)
                {
                    r[length] = count;
                    length++;
                    int[] result = new int[length];
                    for (int i = 0; i < length; i++)
                    {
                        result[i] = r[i];
                       
                    }
                    
                    return result;
                }
            }
            return new int[0];
            throw new NotImplementedException();
        }

        /// <summary>
        /// Consider the leftmost and rightmost appearances of some value in an array. We'll say that the "span" is the
        /// number of elements between the two inclusive. A single value has a span of 1. Returns the largest span found 
        /// in the given array. (Efficiency is not a priority.)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int MaxSpan(int[] array)
        {
          int span = 0;
          int tmp = 0;
          for (int i = 0; i < array.Length; i++)
                    {
            for (int j = 0; j < array.Length; j++)
                        {
              if (array[i] == array[j])
                {
                tmp = j - i + 1;
                span = Math.Max(tmp, span);
              }
            }
          }
          return span;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a non-empty array, return true if there is a place to split the array so that the sum of the numbers on one side is equal to the sum of the numbers on the other side.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public bool CanBalance(int[] array)
        {
            int lSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                lSum += array[i];
                int rSum = 0;
                for (int j = array.Length - 1; j > i; j--)
                {
                    rSum += array[j];
                }
                if (rSum == lSum)
                    return true;
            }
            return false;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given two arrays of ints sorted in increasing order, outer and inner, return true if all of the numbers in inner appear in outer. The best solution makes only a single "linear" pass of both arrays, taking advantage of the fact that both arrays are already in sorted order.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="inner"></param>
        /// <returns></returns>
        public bool LinearIn(int[] array, int[] inner)
        {
            int numFound = 0;
              if (inner.Length == 0)
                        {
                 return true;
              }
              int k = 0;
              for (int i = 0; i < array.Length; i++)
                        {
                 if (array[i] == inner[k])
                            {
                    numFound++;
                    k++;
                 }
                            else if (array[i] > inner[k])
                            {
                             return false;
                          }
                 if (numFound == inner.Length)
                    return true;
              }
              return false;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return an array that contains the exact same numbers as the given array, but rearranged so that all the zeros are grouped at the start of the array. The order of the non-zero numbers matters. So {0, 1, 0, 0, 2, 0, 3, 0} becomes {0, 0, 0, 0, 0, 1, 2, 3}. Try to modify the given array instead of creating a new array.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] ZeroFront(int[] array)
        {
                    int count = 0;
          for (int i = 0; i < array.Length; i++)
                    {
            if (array[i] == 0)
                        {
                    array[count] = 0;
              count++;
            }
          }
          return array;
            throw new NotImplementedException();
        }

        /// <summary>
        /// We'll say that a "mirror" section in an array is a group of contiguous elements such that somewhere in the array, the same group appears in reverse order. For example, the largest mirror section in {1, 2, 3, 8, 9, 3, 2, 1} is length 3 (the {1, 2, 3} part). Return the size of the largest mirror section found in the given array.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int MaxMirror(int[] array)
        {
                    int len = array.Length;
          int count = 0;
          int max = 0;
            for (int i = 0; i < len; i++)
            {
                count = 0;
                for (int j = len - 1; i + count < len && j > -1; j--)
                {
                    if (array[i + count] == array[j])
                    {
                        count++;
                    }
                    else
                    {
                        if (count > 0)
                        {
                            max = Math.Max(count, max);
                            count = 0;
                        }
                    }
                    max = Math.Max(count, max);
                }
            }
          return max;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return an array that contains exactly the same numbers as the given array, but rearranged so that every 3 is immediately followed by a 4. Do not move the 3's, but every other number may move. The array contains the same number of 3's and 4's, every 3 has a number after it that is not a 3, and a 3 appears in the array before any 4.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] Fix34(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
            if (array[i] == 3)
                        {
              for (int j = i; j < array.Length; j++)
                            {
                if (array[j] == 4)
                                {
                  int tmp = array[i + 1];
                  array[i + 1] = 4;
                  array[j] = tmp;
                }
              }
            }
          }
          return array;
            throw new NotImplementedException();
        }

        /// <summary>
        /// (This is a slightly harder version of the fix34 problem.) Return an array that contains exactly the same numbers as the given array, but rearranged so that every 4 is immediately followed by a 5. Do not move the 4's, but every other number may move. The array contains the same number of 4's and 5's, and every 4 has a number after it that is not a 4. In this version, 5's may appear anywhere in the original array.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] Fix45(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                
                if (array[i] == 4)
                            {
                  for (int j = 0; j < array.Length; j++)
                                {
                    if (array[j] == 5)
                                    {
                      if (j > 0 && array[j - 1] != 4)
                                        {
                        int tmp = array[i + 1];
                                            array[i + 1] = 5;
                                            array[j] = tmp;
                      }
                      else if (j == 0)
                                        {
                        int tmp = array[i + 1];
                                            array[i + 1] = 5;
                                            array[j] = tmp;
                      }
                    }
                  }
                }
              }
              return array;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Say that a "clump" in an array is a series of 2 or more adjacent elements of the same value.Return the number of 
        /// clumps in the given array.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int CountClumps(int[] array)
                {
                    bool match = false;
          int count = 0;
          for (int i = 0; i < array.Length - 1; i++)
                    {
            if (array[i] == array[i + 1] && !match)
                        {
              match = true;
              count++;
            }
            else if (array[i] != array[i + 1])
                        {
              match = false;
            }
          }
          return count;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array with int values in any order, develop codes that will modify the given array so that it will start 
        /// with negative values, followed by positive values, and then by zeros. Please note that a zero is neither a positive 
        /// value or a negative value. The order of negatives and the order of positives are not important, but make sure that 
        /// all the negative values must come before all the positive values and that the zeros must come after everything else.
        /// </summary>
        /// <remarks>You will need to swap the elements directly in the same array, and do not create a new array. </remarks>
        /// <remarks>Do not sort the array.</remarks>
        /// <remarks>Time-complexity: O(n), Space-complexity: O(1).</remarks>
        /// <param name="a"></param>
        public void NegativePositiveZero(int[] a)
        {
            int temp = 0;
            bool end = false;

            do
            {
                end = true;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        end = false;
                        temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                    }
                }
            } while (!end);
           
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method will MODIFY the original array that is rotated. If rotatedLeft is true, then the array modified will be 
        ///rotated left by one position. If rotatedLeft is false, then the array modified will be rotated right by one position.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="rotatedLeft">true to rotate left by one place, false to rotate right by one place.</param>
        /// <returns></returns>
        public void Rotate(int[] a, bool rotatedLeft)
        {
            for(int i=0; i<=a.Length; i++)
            if(rotatedLeft==true)
            {
                    a[0] = a[1]++;
            }
                else
                {
                    a[0] = a[a.Length]++;
                }
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method will MODIFY the original array, which has been rotated for a number of times (n), 
        /// by calling the Rotate(int[], bool) method for a number of times (n). The number n can be zero, positive,
        /// or negative. That is, if the value of n is zero, the result will remain unchanged. If the value of n is positive,
        /// the array will rotate left by n places. If the value of n is negative, the array will rotate right by |n| positions.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <seealso cref="Rotate(int[], bool)"/>
        /// <returns></returns>
        public void Rotate(int[] a, int n)
        {
            if (n == 1)
            {
                a[0] = a[0];
            }
            else
            {
                a[0] = a[1]++;
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Count and return the smallest number of elements you need to change in the array to make this array a palindrome.
        /// </summary>
        /// <returns>The count or zero for null or empty array</returns>
        /// <remarks>1. A palindrome is a sequence that reads the same backward as forward. For example, {1, 2, 3, 4, 3, 2, 1} is a palindrome because when you reverse the array, you still get {1, 2, 3, 4, 3, 2, 1}.</remarks>
        /// <param name="array">Array.</param>
        public int PalindromicCount(int[] array)
        {
            if(array == null || array.Length == 0)
            {
                return 0;
            }
            int count = 0;
            for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
            {
               
                    if (array[i] != array[j])
                    {
                        count++;
                    }
               
            }
            return count;
            
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return true if the array can be divided into exactly three partitions, such that the difference between the sum of
        /// all the numbers in the left partition and the sum of all the numbers in the right partition is equal to the sum of 
        /// all the numbers in the middle partition.
        /// </summary>
        /// <remarks>Because there is no way to know where these partitions are located in the array (i.e., they can occur anywhere), you will need to search for these partitions in the array by brute-force.
        ///   Since the difference between two numbers can be in any order, you should check for both left – right as well as right – left.</remarks>
        /// <returns></returns>
        /// <param name="a">The alpha component.</param>
        public bool InEquilibrium(int[] a)
        {

            for (int part = 0; part < a.Length; part++)
            {
                int leftSum = 0;
                int rightSum = 0;
                int midSum = 0;
                int lPart = 0;
                int rPart = 0;
                for (int leftIndex = 0; leftIndex <= part; leftIndex++)
                {
                    leftSum += a[leftIndex];
                    lPart = leftIndex;
                }
                for (int rightIndex = a.Length - 1; rightIndex >= a.Length - part - 1; rightIndex--)
                {
                    rightSum += a[rightIndex];
                    rPart = rightIndex;
                }
                for (int midPart = lPart + 1; midPart < rPart; midPart++)
                {
                    midSum += a[midPart];
                }
                if ((leftSum - rightSum == midSum || rightSum - leftSum == midSum) && midSum != 0)
                    return true;
            }
            return false;
        
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a single-dimensional array of integers, create a method that identifies and returns the smallest, absolute 
        /// difference between an element and the average of its adjacent elements in the array. An element can have up to two 
        /// adjacent elements. Throw ArgumentNullException if the input argument is null. Also throw InvalidOperationException 
        /// if the input array only has one element or is empty (hint: what does it mean by an array is empty—what is its 
        /// length?).
        /// </summary>
        /// <param name="a">any single dimensional array</param>
        /// <exception cref="ArgumentNullException">When array a is null</exception>
        /// <exception cref="InvalidOperationException">When array a is empty or has only one element.</exception>
        /// <remarks>An element can have up to two adjacent elements (one adjacent element if the element is in the beginning or at the end array).</remarks>
        /// <returns>The smallest, absolute difference between an element and the average of its adjacent elements</returns>
        public double ClosestAdjacent(int[] a)
        {
            if (a == null) throw new ArgumentNullException();
            if (a.Length < 2) throw new InvalidOperationException();
            double min = 0;
            double minIndex = -1;

            for (int i = 0; i < a.Length; i++)
            {
                double sum = 0;
                int count = 0;
                if (i > 0)
                {
                    sum += a[i - 1];
                    count++;
                }
                if (i < a.Length - 1)
                {
                    sum += a[i];
                    count++;
                }
                double adjacent = sum / count;
                double diff = adjacent > a[i] ? adjacent - a[i] : a[i] - adjacent;
                if (minIndex < 0 || diff < min)
                {
                    min = diff;
                    minIndex = i;
                } }
            return min;
              throw new NotImplementedException();
            }
           
            
        }

       

    }

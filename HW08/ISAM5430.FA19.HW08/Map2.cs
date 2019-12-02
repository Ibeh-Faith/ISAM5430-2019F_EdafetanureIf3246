using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAM5430.FA19.HW08
{
    public class Map2
    {
        /// <summary>
        /// Given an array of strings, return a Dictionary<string, int> containing a key for every different string in the array, always with the value 0. For example the string "hello" makes the pair "hello":0. We'll do more complicated counting later, but for this problem the value is simply 0.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, int> Word0(string[] strings)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < strings.Length; i++)
            {
                dict[strings[i]] = 0;

            }

            return dict;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array of strings, return a Dictionary<string, int> containing a key for every different string in the array, and the value is that string's length.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, int> WordLen(string[] strings)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < strings.Length; i++)
            {
                string tmp = strings[i];
                dict[tmp] = tmp.Length;
            }
            return dict;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array of non-empty strings, create and return a Dictionary<string, string> as follows: for each string add
        /// its first character as a key with its last character as the value.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, string> Pairs(string[] strings)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            for (int i = 0; i < strings.Length; i++)
            {
                string tmp = strings[i];
                string first = tmp[0].ToString();
                string last = tmp[tmp.Length - 1].ToString();
                dict[first] = last;
            }

            return dict;

            throw new NotImplementedException();
        }

        /// <summary>
        /// The classic word-count algorithm: given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the number of times that string appears in the array.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, int> WordCount(string[] strings)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < strings.Length; i++)
            {

                string tmp = strings[i];

                if (dict.ContainsKey(tmp))
                {
                    int count = dict[tmp];
                    dict[tmp] = count + 1;

                }
                else
                {
                    dict[tmp] = 1;
                }

            }
            return dict;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array of non-empty strings, return a Dictionary<string, string> with a key for every different first character seen, with the value of all the strings starting with that character appended together in the order they appear in the array.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, string> FirstChar(string[] strings)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            for (int i = 0; i < strings.Length; i++)
            {

                string key = (strings[i][0]).ToString();

                if (dict.ContainsKey(key))
                {
                    string val = dict[key] + strings[i];
                    dict[key] = val;
                }
                else
                {
                    dict[key] = strings[i];
                }

            }

            return dict;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Loop over the given array of strings to build a result string like this: when a string appears the 2nd, 4th, 6th, etc. time in the array, append the string to the result. Return the empty string if no string appears a 2nd time.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public string WordAppend(string[] strings)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            String result = "";

            for (int i = 0; i < strings.Length; i++)
            {

                string key = strings[i];

                if (dict.ContainsKey(key))
                {
                    int val = dict.GetValueOrDefault(key);
                    val++;
                    if (val % 2 == 0)
                    {
                        result += key;
                    }
                    dict[key]= val;
                }
                else
                {
                    dict[key] = 1;
                }

            }

            return result;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array of strings, return a Dictionary<String, bool> where each different string is a key and its value is true if that string appears 2 or more times in the array.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, bool> WordMultiple(string[] strings)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();
            Dictionary<string, bool> result = new Dictionary<string, bool>();

            for (int i = 0; i < strings.Length; i++)
            {
                string key = strings[i];

                if (counts.ContainsKey(key))
                {
                    int val = counts[key];
                    val++;
                    counts[key]=val;
                }
                else
                {
                    counts[key] = 1;
                }

                result[key]=counts[key] >= 2;
            }

            return result;
            throw new NotImplementedException();
        }

        /// <summary>
        /// We'll say that 2 strings "match" if they are non-empty and their first chars are the same. Loop over and then return the given array of non-empty strings as follows: if a string matches an earlier string in the array, swap the 2 strings in the array. When a position in the array has been swapped, it no longer matches anything. Using a Dictionary, this can be solved making just one pass over the array. More difficult than it looks.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public string[] AllSwap(string[] strings)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            for (int i = 0; i < strings.Length; i++)
            {

                string key = (strings[i][0]).ToString();

                if (map.ContainsKey(key)) { 
                    int pos = map[key];
                    string tmp = strings[pos];
                    strings[pos] = strings[i];
                    strings[i] = tmp;
                    map.Remove(key);
                }
                else
                {
                    map[key] = i;
                }
            }
            return strings;

            throw new NotImplementedException();
        }

        /// <summary>
        /// We'll say that 2 strings "match" if they are non-empty and their first chars are the same. Loop over and then 
        /// return the given array of non-empty strings as follows: if a string matches an earlier string in the array, 
        /// swap the 2 strings in the array. A particular first char can only cause 1 swap, so once a char has caused a 
        /// swap, its later swaps are disabled. Using a Dictionary, this can be solved making just one pass over the array.
        /// More difficult than it looks.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public string[] FirstSwap(string[] strings)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < strings.Length; i++)
            {
                string key = (strings[i][0]).ToString();
                if (dict.ContainsKey(key))
                {
                    int val = dict[key];
                    if (val == -1)
                    {
                        continue;
                    }
                    // swap
                    int pos = dict[key];
                    string tmp = strings[pos];
                    strings[pos] = strings[i];
                    strings[i] = tmp;

                    // set a flag
                    dict[key] = -1;
                }
                else
                {
                    dict[key] = i;
                }
            }
            return strings;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a string, count the number of unique characters in the string.
        /// </summary>
        /// <param name="str">String</param>
        /// <returns>The unique characters.</returns>
        /// <remarks>
        /// Null and empty strings both count as zero unique characters. 
        /// You can determine the length of this Boolean array with char.MaxValue + 1. 
        /// Thus, you can create a Boolean array with a length of char.MaxValue + 1
        /// to tag each character in a string. 
        /// As char is compatible with int, you will need to use 
        /// each char from the string as an index to this Boolean array, 
        /// hence incrementing the counter when a new character is first seen,
        /// while iterating through all the characters in a string.</remarks>
        public int CountUniqueCharacters(string str)
        {
            if(str is null || str.Length==0|| str=="") return 0;
            char[] ch = str.ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int count = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (!dict.ContainsKey(ch[i]))
                {
                    dict[ch[i]] = 1;
                    count++;
                }
            }
            return count;
                //bool[] isItThere = new bool[char.MaxValue+1];
                //for (int i = 0; i < str.Length; i++)
                //{
                //    isItThere[str[i]] = true;
                //}

                //int count = 0;
                //for (int i = 0; i < isItThere.Length; i++)
                //{
                //    if (isItThere[i] == true)
                //    {
                //        count++;
                //    }
                //}

                //return count;

                throw new NotImplementedException();
        }
    }
}

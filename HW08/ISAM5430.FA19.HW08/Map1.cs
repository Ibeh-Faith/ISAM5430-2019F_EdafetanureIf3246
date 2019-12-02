using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAM5430.FA19.HW08
{
    public class Map1
    {
        /// <summary>
        /// Modify and return the given Dictionary as follows: if the key "a" has a value, set the key "b" to have that value, 
        ///and set the key "a" to have the value "".Basically "b" is a bully, taking the value and replacing it with the empty string.
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public Dictionary<string, string> MapBully(Dictionary<string, string> dict)
        {
            if (dict.ContainsKey("a"))
            {
                //if (dict.ContainsKey("a"))
                //{
                //    dict.Add("b", dict.GetValueOrDefault("a"));

                //    dict.Add("a", "");
                string tmp = dict.GetValueOrDefault("a");
                dict["b"]= tmp;
                dict["a"]= "";
            }
            return dict;
        
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modify and return the given Dictionary as follows: if the key "a" has a value, set the key "b" to have that same 
        /// value. In all cases remove the key "c", leaving the rest of the Dictionary unchanged.
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public Dictionary<string, string> MapShare(Dictionary<string, string> dict)
        {
            if (dict.ContainsKey("a"))
            {
                string tmp = dict.GetValueOrDefault("a");
                dict["b"]= tmp;
            }
            dict.Remove("c");
            return dict;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modify and return the given Dictionary as follows: for this problem the dictionary may or may not contain the "a" and "b" keys. If both keys are present, append their 2 string values together and store the result under the key "ab".
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public Dictionary<string, string> MapAB(Dictionary<string, string> dict)
        {
            if (dict.ContainsKey("a") && dict.ContainsKey("b"))
            {
                String tmp = dict.GetValueOrDefault("a") + dict.GetValueOrDefault("b");
                dict["ab"] = tmp;
            }
            return dict;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a map of food keys and topping values, modify and return the map as follows: if the key "ice cream" is present, set its value to "cherry". In all cases, set the key "bread" to have the value "butter".
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public Dictionary<string, string> Topping1(Dictionary<string, string> dict)
        {
            if (dict.ContainsKey("ice cream"))
            {
                dict["ice cream"]= "cherry";
            }
            dict["bread"]="butter";
            return dict;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a map of food keys and their topping values, modify and return the map as follows: if the key "ice cream" has a value, set that as the value for the key "yogurt" also. If the key "spinach" has a value, change that value to "nuts".
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public Dictionary<string, string> Topping2(Dictionary<string, string> dict)
        {
            if (dict.ContainsKey("ice cream"))
            {
                dict["yogurt"]=dict.GetValueOrDefault("ice cream");
            }
            if (dict.ContainsKey("spinach"))
            {
                dict["spinach"]="nuts";
            }
            return dict;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a dictionary of food keys and topping values, modify and return the map as follows: if the key "potato" has a value, set that as the value for the key "fries". If the key "salad" has a value, set that as the value for the key "spinach".
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public Dictionary<string, string> Topping3(Dictionary<string, string> dict)
        {
            if (dict.ContainsKey("potato"))
            {
                dict["fries"]=dict.GetValueOrDefault("potato");
            }
            if (dict.ContainsKey("salad"))
            {
                dict["spinach"]= dict.GetValueOrDefault("salad");
            }
            return dict;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modify and return the given dictionary as follows: if the keys "a" and "b" are both in the dictionary and have equal values, remove them both.
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public Dictionary<string, string> MapAB2(Dictionary<string, string> dict)
        {
            if (dict.ContainsKey("a") && dict.ContainsKey("b"))
            {
                if (dict.GetValueOrDefault("a").Equals(dict.GetValueOrDefault("b")))
                {
                    dict.Remove("a");
                    dict.Remove("b");
                }
            }
            return dict;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modify and return the given dictionary as follows: if exactly one of the keys "a" or "b" has a value in the dictionary (but not both), set the other to have that same value in the dictionary.
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public Dictionary<string, string> MapAB3(Dictionary<string, string> dict)
        {
            if (dict.ContainsKey("a") && !dict.ContainsKey("b"))
            {
                dict.Add("b", dict.GetValueOrDefault("a"));
            }
            else if (!dict.ContainsKey("a") && dict.ContainsKey("b"))
            {
                dict.Add("a", dict.GetValueOrDefault("b"));
            }
            return dict;
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;

namespace ISAM5430.FA19.HW08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> dict= new 
            var dict = new Dictionary<string, string>();
            dict.Add("First", "Faith");
            dict["Last"] = "Ibeh";
            dict["First"] = "Faithh";
            Console.WriteLine("My First name is " + dict["First"]);
            Console.WriteLine($"My Last name is  { dict["Last"]}");
            if (dict.ContainsKey("Last"))
            {
                Console.WriteLine("My Last name is " + dict["Last"]);
            }
            else
            {
                Console.WriteLine("The Key 'Last' is not found in the dictionary.");
            }
            string lastname;
            //if the key "last" exists in the dictionary, then set the last name to be the value associated to the key upon returning a true; otherwise, it retuens a false;
            if (dict.TryGetValue("Last", out lastname))
            {
                Console.WriteLine($"My last name is {lastname}");
            }
            dict.Remove("Last");
            var keys = dict.Keys;
            Console.WriteLine(string.Join(", ", keys));
            dict["Email"] = "Ibehfayte@gmail.com";
            dict["Address"] = "2600 Bay Area Blvd";
            dict["City"] = "Houston";

            foreach (KeyValuePair<string, string> kvp in dict)
            {
                //kvp means key value pair
                Console.WriteLine($"{kvp.Key,-10} {kvp.Value}"); //this one.
                string value = kvp.Value;
                value = dict[kvp.Key]; //FYI the first one is better 
                //dict.Remove("Address"); <--- Not allowed          
            }
            string octal = "12345670";
            foreach (var c in octal)
            {
                if (OctalToBinary.ContainsKey(c))
                {
                    Console.Write(OctalToBinary[c]);
                }

            }
            Console.WriteLine();
        }
        private static readonly Dictionary<char, string> OctalToBinary = new Dictionary<char, string>
        {
            {'0', "000" },
            {'1', "001" },
            {'2', "010" },
            {'3', "011" },
            {'4', "100" },
            {'5', "101" },
            {'6', "110" },
            {'7', "111" }
        };
    }
}

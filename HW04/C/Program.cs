using System;
using static System.Console;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int countvowel = 0;
            int countcons = 0;
            int sylcount = 0;
            WriteLine("enter some letters");
            while (true)
            {
                var keyInfo = Console.ReadKey();
                char letter = char.ToUpperInvariant(keyInfo.KeyChar);
                if (!char.IsLetter(letter))
                {
                    break;
                }
                else
                {
                    count++;
                    if (letter=='A'|| letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
                    {
                        countvowel++;
                    }
                    else
                    {
                        countcons++;
                    }

                    if ((letter=='A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y')
                        && (letter+1!='A' || letter + 1 != 'I' || letter + 1 != 'O' || letter + 1 != 'U' || letter + 1 != 'Y'))
                    {
                        sylcount++;
                    }

                    

                }
            }
            WriteLine($"the number of letters entered is {count}");
            WriteLine($"the number of vowels entered is {countvowel} and consonants is {countcons}");
            WriteLine($"the number of syllable entered is {sylcount}");
        }

    }
}

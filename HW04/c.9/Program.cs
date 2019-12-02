using System;
using static System.Console;

namespace C9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkmusical = false, secondhalf = false, increasecheck = false, alternatecheck = false, smooth = false, alternatingorder = false;
            char letter;
            char prev = ' ';
            int flag = 0;
            char previous = ' ';
            char current = ' ';
            
            
            WriteLine("enter some letters");
            while (true)
            {
                var keyInfo = Console.ReadKey();
                 letter = char.ToUpperInvariant(keyInfo.KeyChar);
                if (!char.IsLetter(letter))
                {
                    break;
                }
                else
                {
                    //a to check increasing
                   if (letter>prev && prev != letter)
                    {
                        prev = letter;
                        increasecheck = true;
                    }
                    else
                    {
                        flag = 1;
                        increasecheck = false;
                    }

                   // b to check musical
                    if (letter >= 'A' && letter <= 'G') {
                        checkmusical = true;
                    }
                    else
                {
                        checkmusical = false;
                }
                    // c to check second half
                if (letter >= 'N' && letter <= 'Z') { 
                    secondhalf = true;
                    }
                    else
                    {
                        secondhalf = false;
                    }

                //d check if words are alternate 
                if (((letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y')
                        && (letter + 1 != 'A' || letter + 1 != 'I' || letter + 1 != 'O' || letter + 1 != 'U' || letter + 1 != 'Y'))
                        || ((letter != 'A' || letter != 'E' || letter != 'I' || letter != 'O' || letter != 'U' || letter != 'Y')
                        && (letter + 1 == 'A' || letter + 1 == 'I' || letter + 1 == 'O' || letter + 1 == 'U' || letter + 1 == 'Y')))
                    {
                        alternatecheck = true;
                        flag = 0;
                    }
                    else
                    {
                        flag = 1;
                        alternatecheck = false;
                    }

                // e smooth transitions
                
                if (current - previous <1)
                    {
                        smooth = true;
                    }
                    else
                    {
                        smooth = false;
                    }
                    previous = current;
                    current = letter;


                    // f alternating orders
                    if ((current > previous && current +1<current) || (current < previous && current + 1 > current))
                    {
                        alternatingorder = true;
                    }
                    else
                    {
                        alternatingorder = false;
                    }
                    previous = current;
                    current = letter;
                }
            }

            WriteLine($"the check for increasing letter says {increasecheck} ");
            WriteLine($"the check for musical letters says {checkmusical}");
            WriteLine($"the check for second half letters says {secondhalf}");
            WriteLine($"the check for alternate letters says {alternatecheck}");
            WriteLine($"the check for smooth transitions  says {smooth}");
            WriteLine($"the check for alternating order  says {alternatingorder}");
        }
            
        }
    }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1A

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            string input = Console.ReadLine();
            int num1 = int.Parse(input);
            Console.WriteLine("Enter number 2");
            input = Console.ReadLine();
            int num2 = Convert.ToInt32(input);
            Console.WriteLine("Enter the operation:(+, -, /, *)");
            string op = Console.ReadLine();
            int answer;
            if (op == "+")
            {
                answer = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {answer}");
                Console.ReadLine();
            }
            else if (op == "-")
            {
                answer = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {answer}");
                Console.ReadLine();
            }
            else if (op == "/")
            {
                answer = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {answer}");
                Console.ReadLine();
            }
            else if (op == "*")
            {
                answer = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {answer}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You have not entered the right operation. Enter the right operation!");
                Console.ReadLine();
            }
        } 
    }
}
using System; //java's import
/*
  multiline comment
 */
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAM5430.Classs01A
{
    //mikeywu5, borismo1992
    class Program
    {
        // entry-point in the console app
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Welcome to c# Programming"); 
            //since we already declared System up, we can remove it
            // Console.WriteLine("Welcome to c# Programming");

            //declaring a vairable as a string
            string person = "Michael"; //initializing a vairable
            // string interpolation
            Console.WriteLine($"Welcome to c# programming, {person}.");

            Console.WriteLine("Welcome to c# programming, {0}.", person);


            Console.WriteLine(string.Format("Welcome to c# programming, {0}.", person));

            Console.WriteLine("Welcome to c# programming," + person + ".");

            /*
             * new
             * variables:
             * Data types:
             * 
             * simple types
             *   int
             *   bool(true/false)
             *   char('a', '0' != 0)
             *   double/float(IEE 754)
             *   decimal software-implementation of double/float
             *   byte (binary contents)
             *   
             * complex types
             *   string
             *   arrays(int[])
             *   classes
             *   struct
             *   
             * Arithmetic Operators
             *    +, -, *, /, %
             *    
             * Boolean Operators
             *    ==, !=, >, <, >=, <=, &&, ||, !
             */

            Console.WriteLine("*\n**\n***\n****\n*****");
        }
    }
}

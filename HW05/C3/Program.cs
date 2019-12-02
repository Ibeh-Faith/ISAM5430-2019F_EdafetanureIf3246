using System;

namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money1 = new Money(13, 57);
            Money money2 = new Money(540, 43);
            
            Money money3= money1.increment(money2);
            Money money4 = money1.decrement(money2);

            Console.WriteLine("Money1 data:");
            Console.WriteLine(money1 + "\n");
            Console.WriteLine("Money 2 data: ");
            Console.WriteLine(money2 + "\n");
            Console.WriteLine("Increment Money data:");
            Console.WriteLine(money3 + "\n");
            Console.WriteLine("Decrement Money data: ");
            Console.WriteLine(money4);



        }
    }
}

















//Console.Write("$"+money2.getDollars() + ".");
//Console.WriteLine(money2.getCents());

//Console.Write("$" + money1.getDollars() + ".");
//Console.WriteLine(money1.getCents());

//Console.WriteLine("Money 3 data (increment): ");
//Console.Write("$" + money3.getDollars() + ".");
//Console.WriteLine(money3.getCents());

//Console.WriteLine("Money 4 data (decrement): ");
//Console.Write("$"+ money4.getDollars() + ".");
//Console.WriteLine(money4.getCents());


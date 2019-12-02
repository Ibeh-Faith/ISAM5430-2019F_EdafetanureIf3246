using System;

namespace C5
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(10, 2, 2019);
            //date.DisplayDay();
            //Console.ReadLine();

            if((date.Month >=1 && date.Month<=12) &&(((date.Month==2 && (date.Day>=1 && date.Day <= 28)) || 
                ((date.Month==4 || date.Month==6 || date.Month ==9 || date.Month==11) && (date.Day>=1 && date.Day<=30)) ||
              (!(date.Month==2 || date.Month == 4 || date.Month == 6 || date.Month == 9 || date.Month == 11) && (date.Day>=1 && date.Day<=31)))))
            {
                Console.WriteLine("{0:D2}/{1:D2}/{2:D4}", date.Month, date.Day, date.Year);
            }
            else
            {
                Console.WriteLine("Problem with date format");
            }
        }
    }
}

using System;

namespace C4
{
    class Program
    {
        static void Main(string[] args)
        {
            Park park1 = new Park("Gallary Park", "Houston", "Local", "1. Drops 2. Swings 3. Marry goes round", 50, 100, 2000, 200000);
           
           
            Console.WriteLine(park1);
            
            Console.WriteLine("\n The Name Location Type is:");
            Console.WriteLine(park1.NameLocType());

            Console.WriteLine("\n The Name Location Facility is:");
            Console.WriteLine(park1.NameLocFacility());

            Console.WriteLine($"\n The Cost Per Visitor is:{park1.CostVisitor()}");
           

            Console.WriteLine($"\n The Revenue is:{park1.Revenue()}");
           


        }
    }
}

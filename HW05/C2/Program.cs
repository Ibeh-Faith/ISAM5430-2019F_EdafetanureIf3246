using System;

namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {
            var motorway1 = new Motorway("Motorway 1", "Road", 'S', "Gravel", 3, true, "Maintainance company");
            Console.WriteLine(motorway1 + "\n");

            Console.WriteLine("\n The Name of The MotorWay is:");
            Console.WriteLine(motorway1.NameOfMotorWay());

            Console.WriteLine("\n The Name of The MotorWay with toll is:");
            Console.WriteLine(motorway1.NameToll());

            Console.WriteLine("\n The Name of The MotorWay and Number of lanes is:");
            Console.WriteLine(motorway1.NameNoOfLanes());


        }
    }
}

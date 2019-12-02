using System;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1852320, "Faith", 3.7) ;
            
            // a constructor forces you to initiaize the required states
            student.SetName("Faith");
            student.SetGpa(3.7);
            Console.WriteLine("The name is " + student.GetName() + " " + "GPA is " + student.GetGpa());

        }
    }
}

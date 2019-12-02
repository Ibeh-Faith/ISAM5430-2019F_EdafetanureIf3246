using System;
using System.Collections.Generic;
using System.Text;

namespace C1
{
    class Student
    {
        int studentNumber;
        string firstname, lastname, classification, major, fullname;
        double GPA;
        public Student(int number, string name, double gpa)
        {
            number = studentNumber;
            name = firstname + lastname;


        }
            public string GetName()
        {
            return fullname;
        }
           

        public void SetName(string name)
        {
            fullname = name;
        }
        public double GetGpa()
        {
            return GPA;
        }


        public void SetGpa(double gpa)
        {
            GPA = gpa;
        }

        public string Name
        {
            get
            {
                return fullname;
            }
            set
            {
                if (value != null && value != "")
                {
                    fullname = value;

                }

            }
        }



    }
}

using System;
using static System.Console;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter your GPA");
            decimal num = decimal.Parse(ReadLine());
            decimal gpa = (int)(3 * num + 0.5m);
            WriteLine(gpa);
            string grade = null;

            switch (gpa)
            {
                case 12:
                case 11:
                    {
                        grade = "A";
                        break;
                    }
                case 10:
                case 9:
                case 8:
                    {
                        grade = "B";
                        break;
                    }
                case 7:
                case 6:
                case 5:
                    {
                        grade = "C";
                        break;
                    }
                case 4:
                case 3:
               
                    {
                        grade = "D";
                        break;
                    }
                default:
                    {
                        grade = "F";
                        break;
                    }
            }
            if ((gpa == 11) || (gpa == 8) || (gpa == 5))
            {
                WriteLine(grade + "-");
            }
            else if(gpa==10 || gpa==7 || gpa == 4)
            {
                WriteLine(grade + "+");

            }
            else if (gpa == 12)
            {
                WriteLine("Grade A");
            }
            else if (gpa == 9)
            {
                WriteLine("Grade B");
            }
            else if (gpa ==6 )
            {
                WriteLine("Grade C");
            }
            else if (gpa == 3)
            {
                WriteLine("Grade D");
            }
            else if(gpa==2||gpa==1||gpa==0)
            {
                WriteLine("Grade F");
            }



        }
    }
    }


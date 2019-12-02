using System;
using System.Collections.Generic;
using System.Text;

namespace C5
{
    class Date
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        public Date(int month, int day, int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }
        //public void DisplayDay()
        //{
           
        //}
    }
}

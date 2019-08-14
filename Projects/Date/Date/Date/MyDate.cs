using System;
using System.Collections.Generic;
using System.Text;

namespace Date
{
    class MyDate
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public string FullDate { get; set; }

        public MyDate(DateTime date)
        {
            this.day = date.Day;
            this.month = date.Month;
            this.year = date.Year;
            FullDate = date.ToString();
        }
/*
        public void Date()
        {
            Console.WriteLine(String.Format("{0}/{1}/{2}", this.month, this.day,this.year));
        }
        */
        






    }
}

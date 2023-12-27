using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec27QMSSort
{
    internal class Program
    {// properties
        static void Main(string[] args)
        {
            DateTime dob = new DateTime(1990, 7, 10, 7, 10, 24);//year month date hour minute sec
            Console.WriteLine("day is {0} ", dob.Day);//month year 
            Console.WriteLine(" day of year " + dob.DayOfYear);
            Console.WriteLine("day of week {0} ", dob.DayOfWeek);
            //add or substract 
            DateTime aDay = DateTime.Now;// today's date
                                         //to define a month
            TimeSpan aMonth = new TimeSpan(30, 0, 0, 0);
            DateTime aDayAfterAmonth = aDay.Add(aMonth);
            //timespane is used to declare our own month with 

        }
    }
}


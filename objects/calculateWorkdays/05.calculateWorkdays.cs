using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculateWorkdays
{
    class calculateWorkdays
    {
        static void Main(string[] args)
        {
            /*
            int mili = Environment.TickCount;
            int sec = mili / 1000;
            int min = sec / 60;
            int hour = min / 60;
            int day = hour / 24;
            Console.WriteLine("miliseconds - " + mili + "\nseconds - " + sec + "\nmin - " + min + "\nhours - "
                + hour + "\ndays - " + day);
            */
            int days = 0;
            int holidays = 0;
            DateTime dateTwo;
            do
            {
                Console.WriteLine("Enter date like the following: dd mm yyyy");
                dateTwo = DateTime.Parse(Console.ReadLine());
            }
            while (dateTwo < DateTime.Today);
            CalcWorkDays(dateTwo, days, holidays);
            Console.WriteLine();
        }
        static void CalcWorkDays(DateTime date, int days, int holidays)
        {
            DateTime today = DateTime.Today;
            days = 0;
            holidays = 0;
            DateTime[] arrHolidays = { new DateTime(2013, 12, 24), new DateTime(2013, 12, 25), new DateTime(2013, 12, 30),
                                  new DateTime(2013, 12, 31), new DateTime(2013, 01, 01)};
            while (today <= date)
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidays++;
                }
                else
                {
                    for (int i = 0; i < arrHolidays.Length; i++)
                    {
                        if (arrHolidays[i].DayOfYear == date.DayOfYear)
                        {
                            holidays++;
                        }
                    }
                } 
                days++;
                date = date.AddDays(1);
            }
        }
    }
}

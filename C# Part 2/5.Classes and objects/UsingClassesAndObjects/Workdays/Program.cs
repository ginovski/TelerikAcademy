//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
namespace Workdays
{
    using System;

    public class Program
    {
        public static void Main()
        {
            DateTime[] holidays =
            {
                new DateTime(2014, 05, 05),
                new DateTime(2014, 05, 06),
                new DateTime(2014, 05, 01),
                new DateTime(2014, 03, 03),
                new DateTime(2014, 01, 01),
                new DateTime(2014, 12, 31),
                new DateTime(2014, 12, 25),
                new DateTime(2014, 12, 24),
                new DateTime(2014, 12, 26),
                new DateTime(2014, 09, 06),
                new DateTime(2014, 09, 22),
                new DateTime(2014, 04, 18),
                new DateTime(2014, 04, 19),
                new DateTime(2014, 04, 20),
                new DateTime(2014, 04, 21),
            };

            DateTime startDate = DateTime.Today;
            DateTime specifiedDate = new DateTime(2014, 06, 30);

            int daysLeft = (specifiedDate - startDate).Days;
            int daysCounter = 0;
            int holidayCounter = 0;

            for (int day = 0; day < daysLeft; day++)
            {
                startDate = startDate.AddDays(1);
                if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    for (int i = 0; i < holidays.Length; i++)
                    {
                        if (startDate == holidays[i])
                        {
                            holidayCounter++; 
                        }
                    }

                    daysCounter++; 
                }
            }

            daysCounter -= holidayCounter; 

            Console.WriteLine("There are {0} days until {1}", daysCounter, specifiedDate);
        }
    }
}

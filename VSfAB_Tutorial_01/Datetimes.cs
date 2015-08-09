using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSfAB_Tutorial_01
{
    class Datetimes
    {
        DateTime myDateTyme = DateTime.Now;
        
        public void dateTimeToString()
        {
            //Prints out the date and time
            Console.WriteLine(myDateTyme.ToString());

            //Prints out the date only
            Console.WriteLine(myDateTyme.ToShortDateString());
            //time only
            Console.WriteLine(myDateTyme.ToShortTimeString());

            //Long formats:
            Console.WriteLine(myDateTyme.ToLongDateString());
            Console.WriteLine(myDateTyme.ToLongTimeString());

            //Adding days/hours to a date
            Console.WriteLine(myDateTyme.AddDays(3).ToLongDateString());
            Console.WriteLine(myDateTyme.AddHours(3).ToShortDateString());

            //Substracting days/hours from a date
            Console.WriteLine(myDateTyme.AddHours(-3).ToShortDateString());

            //Show only a part of the date
            Console.WriteLine(myDateTyme.Millisecond);
            Console.WriteLine(myDateTyme.Second);
            Console.WriteLine(myDateTyme.Minute);
            Console.WriteLine(myDateTyme.Hour);
            Console.WriteLine(myDateTyme.Day);
            //Monday, Tuesday, etc.
            Console.WriteLine(myDateTyme.DayOfWeek);
            //Correlative number.
            Console.WriteLine(myDateTyme.DayOfYear);
            Console.WriteLine(myDateTyme.TimeOfDay);
            Console.WriteLine(myDateTyme.Ticks);
            Console.WriteLine(myDateTyme.Month);


            //
            DateTime myBirthday = new DateTime(1985, 08, 28);
        }
    }
}

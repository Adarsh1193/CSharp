using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());               //date and time
            //Console.WriteLine(myValue.ToShortDateString());      //date only
            //Console.WriteLine(myValue.ToShortTimeString());      //time only
            //Console.WriteLine(myValue.ToLongDateString());       // day including date
            //Console.WriteLine(myValue.ToLongTimeString());       // time along with seconds

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());        //add days to the current date
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());       //add time to the current time
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());       //substracts dyas from the current date

            //Console.WriteLine(myValue.Month);                     //displays month

            //DateTime myBirthday = new DateTime(1993, 08, 11);     //displays birthday
            //Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("11/08/1993");     //determine the difference between 2 dates
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();
        }
    }
}

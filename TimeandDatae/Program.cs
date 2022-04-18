using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeandDatae
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            string format = "MMMM d yyyy hh:mm tt"; //formating the string 
            Console.WriteLine("Today's date and time is: "); //displaying the current time and date
            Console.WriteLine(time.ToString(format));
            Console.WriteLine("Enter a number to find out the time in the future"); //asking the user to enter a number for future date and time
            int hour = Convert.ToInt32(Console.ReadLine()); //converting string to int
            Console.WriteLine("The date and time will be: ");
            Console.WriteLine(DateTime.Now.AddHours(hour)); //calculates the new time after adding the hours
            Console.ReadLine();
        }
    }
}

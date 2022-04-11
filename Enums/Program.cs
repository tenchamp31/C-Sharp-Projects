using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                EnumCourse DayChoice = new EnumCourse(); //creating instance of DayChoice
                Console.WriteLine("What day is today? "); //asking for the day
                string currentday = Console.ReadLine();
                var day = (Days)Enum.Parse(typeof(Days), currentday); //Parse Enum
                Console.WriteLine("Today is {0} ", (Days)Enum.Parse(typeof(Days), currentday));
                Console.ReadLine();
            }

            catch (SystemException e)
            {
                Console.WriteLine("Please enter an actual day of the week."); //giiving message for the error
                Console.ReadLine();
                return;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.ReadLine();
                Console.ReadKey();
            }

        }

    }
}

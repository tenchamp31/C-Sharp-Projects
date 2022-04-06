using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step306
{
     class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //creating employee instance
            employee.FirstName = "Yogesh";
            employee.LastName = "Gandhi";
            employee.SayName();
            Console.ReadLine();

            IQuittable quit = new Employee(); //calling the Iquittable 
            quit.Quit();
        }
    }
}

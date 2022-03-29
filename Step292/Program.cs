using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step292
{

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() ; //creating instance of Employee
            employee.FirstName = "Sample"; //giving first name for firstname
            employee.LastName = "Student"; //giving last name
            employee.SayName();
            Console.ReadLine();
            Console.ReadKey();
        }




    }
     
}

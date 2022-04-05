using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step302
{
   class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee(); //creating instance of employee
            employee.FirstName = "Sample"; //giving firstname of Sample
            employee.LastName = "Student"; //giving lastname of Student
            employee.SayName();
            Console.ReadLine();
            Console.ReadKey();
            
        }
    }
}

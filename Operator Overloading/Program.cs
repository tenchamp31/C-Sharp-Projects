using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employee1 = new Employees(); //creating instance of employees
            Employees employee2 = new Employees();
            employee1.favcar = "Ford"; //fav car
            employee2.favcar = "BMW";
            employee1.Vacation = "Hawaii";
            employee2.Vacation = "Colorado";
            employee1.Id = "54354153"; //ID #
            employee2.Id = "58818822";
            Console.WriteLine("Does employee1 and employee2 have the same favorite car? " + (employee1.favcar == employee2.favcar));
            Console.WriteLine("Does employee1 and employee2 have the same vacation spot? " + (employee1.Vacation == employee2.Vacation));
            Console.WriteLine((employee1 == employee2));
            Console.ReadKey();
        }
    }
}

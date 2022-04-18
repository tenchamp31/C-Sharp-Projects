using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            const string FavCompany = "Apple"; //creating constructor
            var Year = 2022;  //creating variable with var
            Employee employee1 = new Employee(1, "Tim Cook");
            Employee employee2 = new Employee("Craig Ferguson");
            Console.WriteLine("The best people who work at " + FavCompany + " in "+ Year + " are " + employee1.name +  " and " + employee2.name);
            Console.ReadLine();



        }
    }
}

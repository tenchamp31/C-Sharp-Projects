using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() {  //creating list of Employees
            new Employee() { firstname = "Noel", lastname = "McGinn", ID = 0 },
            new  Employee() { firstname= "Casey", lastname = " Wu", ID = 1},
            new  Employee() { firstname = "John", lastname = " Smith", ID = 2 },
            new  Employee() { firstname = "Joe", lastname = " Saigon", ID = 3 },
            new  Employee() { firstname = "Rebecca ", lastname = "Crider", ID =4 },
            new  Employee() { firstname = "Candice ", lastname = "Sheets", ID =5 },
            new  Employee() { firstname = "Yogesh ", lastname = "Paul", ID =6 },
            new  Employee() { firstname = "Joe", lastname = "Hunter", ID=7 },
            new  Employee() { firstname = "Sarah", lastname = "Marshall", ID =8 },
            new  Employee() { firstname = "Tom", lastname = "Matthews", ID = 9 }
                };

            List<Employee> NewList = new List<Employee>(); //creating instance of new list
            foreach (var employee in employees)  //foreach loop
            {
                if (employee.firstname == "Joe")
                {
                    NewList.Add(employee);
                }
            }

            foreach(Employee employee in NewList)
            {
                Console.WriteLine(employee.firstname + employee.lastname);  //displaying foreach loop
                Console.ReadKey();
            }

            List<Employee> lambdajoe = employees.Where(x => x.firstname == "Joe").ToList(); //lambda expression for Employees with first name Joe
            foreach (Employee employee in lambdajoe)
            {
                Console.WriteLine(employee.firstname + employee.lastname);
                Console.ReadLine();
            }
            

            List<Employee> IDS = employees.Where(y => y.ID >5).ToList(); //Lambda Expression for Id > 5
            foreach (Employee employee in IDS)
            {
                Console.WriteLine(employee.firstname + employee.lastname);
            }
            Console.ReadLine();
            }
        }
    }


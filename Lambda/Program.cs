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
            List<LambdaCourse> Employees = new List<LambdaCourse>() {  //creating list of Employees
            new LambdaCourse { Employees = "Noel McGinn", ID = 0 },
            new LambdaCourse { Employees= "Casey Wu", ID = 1},
            new LambdaCourse { Employees = "John Smith", ID = 2 },
            new LambdaCourse { Employees = "Joe Saigon", ID = 3 },
            new LambdaCourse { Employees = "Rebecca Crider", ID =4 },
            new LambdaCourse { Employees = "Candice Sheets", ID =5 },
            new LambdaCourse { Employees = "Yogesh Paul", ID =6 },
            new LambdaCourse { Employees = "Joe Hunter", ID=7 },
            new LambdaCourse { Employees = "Sarah Marshall", ID =8 },
            new LambdaCourse { Employees = "Tom Matthews", ID = 9 }
                };   

            var Employee = Employees.FindAll(x => x.ID >5); //lambda expression for ID >5

            foreach (var emply in Employee) //loop
            {
                Console.WriteLine(emply.Employees);
            }

            Console.ReadKey();
            }
        }
    }


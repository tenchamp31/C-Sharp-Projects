using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step285
{
    class Program
    {
        public static void Subtract(int a, int b, out int result) //out parameter
        {
            result = a - b;
        }

        public static class School //declaring a static class
        {
            public static string SchoolName = "School of Technology";
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number"); //asking for number
            int num1 = Convert.ToInt32(Console.ReadLine());

            var operatorObject = new ExternalClass(); //creating instance of class
            operatorObject.Divide(num1);
             //giving out answer
            Console.ReadLine();

            Subtract(35, 5, out int result);
            Console.WriteLine(result);
            Console.ReadLine();


            var obj = new Overload(); //method overload
            var answer1 = obj.Add(20, 30);
            Console.WriteLine(answer1);
            Console.ReadLine();

            Console.WriteLine(School.SchoolName);
            Console.ReadLine();
        }
  
    }
     
        
}

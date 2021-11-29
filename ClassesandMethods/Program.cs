using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Integer:"); //Asking for user input
            string line = Console.ReadLine();
            int data = Int32.Parse(line); //converting string to int data type

            var operatorObject = new methods.ArthematicOperations();
            var answer = operatorObject.Multiply(data);
            var answer1 = operatorObject.Add(data);
            var answer2 = operatorObject.Subtract(data);


            Console.WriteLine(line + " multiplyed by 6 = " + answer);
            Console.WriteLine(line + " Added to 10 = " + answer1);
            Console.WriteLine(line + " Subtracted by 5 = " + answer2);

            Console.ReadLine();
        }
    }
}

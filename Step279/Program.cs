﻿using System;
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
        public float data1 { get; set; }
        public long data3 { get; set; }
        public int data2 { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Integer:"); //Asking for user input
            string line = Console.ReadLine();
            int data = Int32.Parse(line); //converting string to int data type



            Console.WriteLine("Please enter decimal");
            string line2 = Console.ReadLine();
            float data1 = float.Parse(line2); //getting float data type

            Console.WriteLine("Please enter favorite number");
            string line3 = Console.ReadLine();
            long data2 = Int32.Parse(line3); //long data type





            var operatorObject = new methods.ArthematicOperations(); //refrencing thread
            var answer = operatorObject.Add(data);
            var answer1 = operatorObject.Add(data1);
            var answer2 = operatorObject.Add(data2);



            Console.WriteLine(line + " Multiplyed by 12 = " + answer);
            Console.WriteLine(line2 + " divided by 3 = " + answer1.ToString("0"));
            Console.WriteLine(line3 + " added by 5 is " + answer2);
            Console.ReadLine();
        }
    }

}

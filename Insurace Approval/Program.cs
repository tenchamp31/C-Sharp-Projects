using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurace_Approval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval");
            Console.WriteLine("What is your age?");  //asking for age
            string age = Console.ReadLine();
            int num1 = Int32.Parse(age);
            int age1 = num1;
            Console.WriteLine("Your age is " + age1);

            Console.WriteLine("Have you ever had a DUI? True or False?"); //True or false for DUI
            string haveyou = Console.ReadLine();
            bool DUI = bool.Parse(haveyou);
            Console.WriteLine(DUI);

            Console.WriteLine("How many speeding tickets do you have?"); //Asking for # of speeding tickets
            string tickets = Console.ReadLine();
            int num2 = Int32.Parse(tickets);
            int tickets1 = num2;
            Console.WriteLine("The number of speeding tickets I have is " + tickets1);
            Console.ReadLine();

            Console.WriteLine("Does this person qualify for insurance?"); //Boolean for qualifying Insurance
            bool qualify = (age1 > 15 && DUI == false && tickets1 <= 3);
            Console.WriteLine(qualify);
            Console.ReadLine();
        }
    }
}

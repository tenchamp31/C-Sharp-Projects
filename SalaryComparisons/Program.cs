using System;

namespace SalaryComparsions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparsion Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");    //Asking for hourly rate
            string hourlyrate = Console.ReadLine();
            int num1 = Int32.Parse(hourlyrate);
            int hr1 = num1;
            Console.WriteLine("Your hourly rate is " + num1);   
            Console.ReadLine();


            Console.WriteLine("What is your Hours worked per week?");   //Asking for hours per week
            string weeklyrate = Console.ReadLine();
            int num2 = Int32.Parse(weeklyrate);
            int wr1 = num2;
            Console.WriteLine("Your Hours worked per week is " + num2);
            Console.ReadLine();


            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");  //Asking for hourly rate for person 2
            string hourlyrate2 = Console.ReadLine();
            int num3 = Int32.Parse(hourlyrate2);
            int hr2 = num3;
            Console.WriteLine("Your hourly rate is " + num3);
            Console.ReadLine();

            Console.WriteLine("What is your Hours worked per week?");   //hours per week for person 2
            string weeklyrate2 = Console.ReadLine();
            int num4 = Int32.Parse(weeklyrate2);
            int wr2 = num4;
            Console.WriteLine("Your Hours worked per week " + num4);
            Console.ReadLine();

            int AnnualSalary1 = num1 * num2 * 52;
            Console.WriteLine("Annual salary of Person 1 is " + AnnualSalary1);  //calculating Annaul Salary for p1
            

            int AnnualSalary2 = num3 * num4 * 52;
            Console.WriteLine("Annual Salary of Person 2 is " + AnnualSalary2);  //Calculating annaul salary for p2
            

            Console.WriteLine("Does Person 1 make more money then person 2?");  //True or false statement
            bool trueOrFalse = AnnualSalary1 > AnnualSalary2;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

        }
    }
}




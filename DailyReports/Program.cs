using System;

namespace VariablesandDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Reports");
            Console.ReadLine();


            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Your course is: " + yourCourse);
            Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("Page Number:" + pageNumber);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer with True or False.");
            string yourAnswer = Console.ReadLine();
            Console.WriteLine(yourAnswer);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string yourExperiences = Console.ReadLine();
            Console.WriteLine(yourExperiences);
            Console.ReadLine();

            Console.WriteLine("Is there any otherfeed you'd like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();
            Console.WriteLine(yourFeedback);
            Console.ReadLine();

            Console.WriteLine("How many Hours did you study today?");
            string yourHours = Console.ReadLine();
            Console.WriteLine("I studied for " + yourHours);
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day");


        }
    }
}


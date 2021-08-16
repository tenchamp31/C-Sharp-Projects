using System;

namespace VariablesandDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Reports"); //Code for beginning report
            Console.ReadLine();


            Console.WriteLine("What is your name?"); //Asking for name
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            Console.WriteLine("What course are you on?"); //Asking for course
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Your course is: " + yourCourse); 
            Console.ReadLine();

            Console.WriteLine("What page number are you on?"); //Asking for page number
            string pageNumber = Console.ReadLine();
            int num1 = Int32.Parse(pageNumber);
            int newpage = num1;
            Console.WriteLine("Your page number is " + newpage);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer with True or False."); //Asking for true or false
            string yourHelp = Console.ReadLine();
            bool Help = bool.Parse(yourHelp);
            Console.WriteLine(Help);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics."); //Any help needed
            string yourExperiences = Console.ReadLine();
            Console.WriteLine(yourExperiences);
            Console.ReadLine();

            Console.WriteLine("Is there any otherfeed you'd like to provide? Please be specific."); //Feedback code
            string yourFeedback = Console.ReadLine();
            Console.WriteLine(yourFeedback);
            Console.ReadLine();

            Console.WriteLine("How many Hours did you study today?"); //Asking for hours studied
            string yourHours = Console.ReadLine();
            int num2 = Int32.Parse(yourHours);
            int newhours = num2;
            Console.WriteLine("You Stuided for + " + num2 + " hours");
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day"); //Final statement


        }
    }
}


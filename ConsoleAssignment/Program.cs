using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssignment
{
    class Program
    {           
        static void Main(string[] args)
        {           //assignment 1
            string[] Cars = new string[] { " Audi ", " Ford ", " BMW ", " Volvo " };
        Console.WriteLine(" Are Cars the best or worst? "); //asking for user input
        string answer = Console.ReadLine();

        for (int i = 0; i<Cars.Length; i++)
        {
            Cars[i] += answer;

        }
        for (int i =0; i<Cars.Length; i++)
        {
            Console.WriteLine(Cars[i]);
        }

            Console.ReadLine();



            //////////    ////Assignment 2 infinite loop and fixing it
            int games = 0;
            while (true)
            {
                Console.WriteLine("games played = {0}", games, games++); //added games++ to fix the infinite loop

                if (games > 75)
                {
                    break;
                }
            }
            //assignment 3
            int[] targetpratice = { 94, 56, 87, 23, 99, 34 };
            for (int a = 0; a < targetpratice.Length; a++)
            {
                if (targetpratice[a] > 45)   //making the > comparsion
                {
                    Console.WriteLine("passing target score is: " + targetpratice[a]);
                }
            }
            Console.ReadLine();

            int[] TicketsSold = { 45, 12, 78, 98, 15, 24, 45, 82 };
            for (int t = 0; t < TicketsSold.Length; t++)
            {
                if (TicketsSold[t] <= 100)
                {
                    Console.WriteLine("The tickets sold under 100 are " + TicketsSold[t]);
                }

            }

            Console.ReadLine();


            //{Assignment 4
            List<string> Students = new List<string>() { "Bob", "Cindy", "Ramesh", "John", "Joe" };
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine(Students[i]); //printing out student names


            }
            Console.WriteLine("Please choose the name of the student to find their student index number");
            string num1 = Console.ReadLine();


            bool StudentsPresent = false; //creating bool statement fo find index number
            for (int i = 0; i < Students.Count; i++)
            {


                if (Students[i] == (num1))

                {
                    Console.WriteLine(num1 + " Student ID is " + i);
                    StudentsPresent = true;
                    break;
                }


            }

            if (StudentsPresent == false)
            {
                Console.WriteLine("No Student Found");

            }

            // Assignment 5
            List<string> Books = new List<string>() { "StarWars", "Harry Potter", "Lord of the Rings", "StarWars" };
                for (int b = 0; b < Books.Count; b++)
                {
                    Console.WriteLine(Books[b]);
                }

                Console.WriteLine("Enter your Favorite book from the list to find its rating index");
                string books = Console.ReadLine();
                bool Booksbest = false;


                for (int b = 0; b < Books.Count; b++)
                {
                    if (Books[b] == (books))
                    {
                        Console.WriteLine(books + " rating is " + b);
                        Booksbest = true;
                        break;

                    }

                    
                }

                if (Booksbest == false)
                {
                    Console.WriteLine("No book found");
                
                }

                Console.ReadLine();


            // Assignment 6
            List<string> Colors = new List<string>() { " Blue ", " Red ", " White ", " Black ", " Orange ", " Red " };

            IEnumerable<string> copy = Colors.GroupBy(x => x).SelectMany(v => v.Skip(1));

            foreach (string color in Colors)
            {
                Console.WriteLine(color);
                if (copy.Contains(color))
                {
                    Console.WriteLine(" Colors: " + color + " has already been shown");
                }
            }

            Console.ReadLine();


        }
    }    
}





using System;


namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the package weight?"); //Asking for weight
            string weight = Console.ReadLine();
            int num1 = Int32.Parse(weight);
            Console.WriteLine("Your weight is " + num1);

            if (num1 > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package express, Have a good day"); // If package is too heavy
            }


            else

            Console.WriteLine("What is the package width?"); //Asking for width
            string width = Console.ReadLine();
            int num2 = Int32.Parse(width);

            Console.WriteLine("What is your package height?"); //Asking for height
            string height = Console.ReadLine();
            int num3 = Int32.Parse(height);

            Console.WriteLine("WHat is your package length?"); //Asking for length
            string length = Console.ReadLine();
            int num4 = Int32.Parse(length);
            int combined = (num2 + num3 + num4);   //Getting combined total
            int quote = (num2 * num3 * num4 * num1 / 100);

            if (combined > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express"); //If package greater then statement
            }


            else
            {
                Console.WriteLine("Your quote is $" + string.Format("{0:##.00}", quote)); //Formatting into Currency and giving quote
            }

            Console.ReadLine();

        }
    }
}

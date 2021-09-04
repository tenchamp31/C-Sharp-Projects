using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        int[] numArray = new int[5]; //creating instance 
        numArray[0] = 5;
        numArray[1] = 10;
        numArray[2] = 15;
        numArray[3] = 20;
        numArray[4] = 25;

        Console.WriteLine("Please choose index between 0-4");



        string num1 = Console.ReadLine();
        int num2 = Int32.Parse(num1);

        if (num2 < 0)  //Making if statement
        {
            Console.WriteLine("Not applicable/Index too low");
        }

        else
        {
            if (num2 > 4)
                Console.WriteLine("Index too high");
            else
                Console.WriteLine(numArray[num2]);
        }

        string[] Books = new string[7];      //Making string of books 
        Books[0] = "Harry Potter and the Sorcerers Stone";
        Books[1] = "Harry Potter and the Chamber of Secrets Java";
        Books[2] = "Harry Potter and the Prisoner of Azkaban";
        Books[3] = "Harry Potter and the Goblet of Fire";
        Books[4] = "Harry Potter and the Order of the Phoenix";
        Books[5] = "Harry Potter and the Half-Blood Prince";
        Books[6] = "Harry Potter and the Deathy Hallows";
        Console.WriteLine("Choose your index between 0-6 to find your Harry potter book number");
        string num3 = Console.ReadLine();
        int num4 = Int32.Parse(num3);
        if (num4 < 0)
        {
            Console.WriteLine("Not applicable/Index too low");
            Console.ReadLine();
        }

        else
        {
            if (num4 > 6)
                Console.WriteLine("No book found/ Index Too High");
            else
                Console.WriteLine(Books[num4]);
            Console.ReadLine();
        }

        List<string> Cars = new List<string>(5); //making a list
        Cars.Add("Ford");
        Cars.Add("BMW");
        Cars.Add("Jeep");
        Cars.Add("Volvo");
        Cars.Add("Lexus");
        Cars.Add("Audi");

        Console.WriteLine("Please choose index between 0-5 to get your free car!");
        string num5 = Console.ReadLine();
        int num6 = Int32.Parse(num5);


        Console.WriteLine(Cars[num6]);
        Console.ReadLine();
    }
}




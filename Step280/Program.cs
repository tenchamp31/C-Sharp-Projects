using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace RandomThings
{



    class Program
    {



        static void Main(string[] args)
        {

            ExternalClass operatorObject = new ExternalClass(); //instance of class
            Console.WriteLine("What is your favorite number"); //Asking for fav number
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your second fav number or don't reply"); //asking for 2nd fav number
            int num2;
            if (int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine(operatorObject.Add(num1, num2)); //passing method
                Console.ReadLine();
            }



            else
            {
                Console.WriteLine(operatorObject.Add(num1));
                Console.ReadLine();

            }


        }

    }
}

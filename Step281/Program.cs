using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step281
{
     class Program
    {
        
        static void Main(string[] args)
        {

            ExternalClass operatorObject = new ExternalClass();



            Console.WriteLine("What is your x value");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your y value");
            int y = Convert.ToInt32(Console.ReadLine());

            int sum1 = operatorObject.Add(x, y);
            Console.WriteLine(" Your integers added together is " + operatorObject.Add(x, y) + " " + "second integer is " + y);
            Console.ReadLine();




            operatorObject.Add1(50,20);
            Console.ReadLine();

            

           

            
           

            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Integers = new List<int> { 6, 4, 7 }; //Making integer list
            try
            {
                Console.WriteLine("What is your fav number"); //Asking number to divide by
                int answer1 = int.Parse(Console.ReadLine());


                for (int i = 0; i < Integers.Count; i++)
                    Console.WriteLine(Integers[i] / answer1);  //Displaying remainders
                Console.ReadLine();

            }

            catch (DivideByZeroException s) //Divide by zero message
            {
                Console.WriteLine(s.Message);

            }

            catch (FormatException y)  //Format message
            {
                Console.WriteLine(y.Message);
            }

            Console.WriteLine("Progam has finished running Exceptions");
            Console.ReadLine();

        }
}   }

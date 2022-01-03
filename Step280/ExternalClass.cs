using System;
using System.Runtime.InteropServices;
namespace RandomThings
{
    class ExternalClass
    {

        public int Add(int num1, [Optional] int num2)
        {
            int sum = num1 + num2; //math operation
            Console.WriteLine(sum);
            return sum; //returning math operation
        }
    }

}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    public class ArthematicOperations
    {
        public int Multiply(int data)
        {
            data = data * 6; //adding the input
            return Add(data);
        }

        public int Add(int data)
        {
            data = data + 10; //subtracting the input after addition
            return Subtract(data);
        }

        public int Subtract(int data)
        {
            return data - 5; //multiplying input after addition and subtraction
        }
    }
}

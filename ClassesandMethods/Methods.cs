using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    public class ArthematicOperations
    {
        public int Add(int data)
        {
            data = data + 4; //adding the input
            return Subtract(data);
        }

        public int Subtract(int data)
        {
            data = data - 3; //subtracting the input after addition
            return Multiply(data);
        }

        public int Multiply(int data)
        {
            return data * 3; //multiplying input after addition and subtraction
        }
    }
}

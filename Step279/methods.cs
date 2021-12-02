using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    public class ArthematicOperations
    {
        public int Add(int data) //multiplying operation
        {
            data = data * 12;
            return data;

        }

        public decimal Add(Decimal data1)
        {
            data1 = data1 / 3; //dividing operation
            return Decimal.ToInt32(data1);
        }

        public float Add(float data2) //adding operation
        {
            data2 = data2 + 5;
            return Convert.ToInt32(data2);


        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step285
{
     class ExternalClass
    {
       public void Divide(int num1) //creating
        {
            int num2;
            num2 = num1 / 2;
            Console.WriteLine(num2);
        }

       
    }

    public  class Overload //creating method overload
    {
        public int Add(int c, int d)
        {
            return c + d;
        }

        public int Add(int c, int d, int e)
        {
            return (c + d) + e;
        }

        
                

        
    }
    }

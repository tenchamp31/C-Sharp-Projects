using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Do_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;           //While statement
            while (x < 20)
            {
                Console.WriteLine(x);
                x++;
            }


            int y = 0;
            do
            {
                Console.WriteLine(y);               //do while statement
                y++;
            }
            while (y < 15);

            Console.ReadLine();
        }
    }
}

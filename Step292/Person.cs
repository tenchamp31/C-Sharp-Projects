using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step292
{
    public class Person
    {
        public string FirstName { get; set; } //creating string for firstname
        public string LastName { get; set; } //creating string for lastname
        public void SayName() //creating sayname
        {
            Console.WriteLine("Name:" + FirstName +  LastName);
            Console.ReadLine();
        }
    }
}

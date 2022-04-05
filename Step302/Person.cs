using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step302
{
    public abstract class Person //creating person class
    {
        public string FirstName { get; set; } //getting first name
        public string LastName { get; set; } //getting lastname
        public abstract void SayName(); //
    }
}

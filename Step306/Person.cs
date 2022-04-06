using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step306
{
    public abstract class Person
    {
        public string FirstName { get; set; } //making string FirstName
        public string LastName { get; set; } //Making lastname string
        public abstract void SayName();
    }
}

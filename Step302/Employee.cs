﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step302
{
    public class Employee : Person
    {
        public override void SayName()
            {
            Console.WriteLine(FirstName + " " + LastName);
            }
    }
}

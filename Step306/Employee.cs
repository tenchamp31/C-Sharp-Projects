﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step306
{
    
        public class Employee : Person, IQuittable
        {
            public override void SayName()
            {
                Console.WriteLine(FirstName + " " + LastName); //writing Firstname and LastName
            }
            public void Quit()
            {
                Console.WriteLine("Polymorphism at its finest");
            }
        }
    
}


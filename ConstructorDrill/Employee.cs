using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDrill
{
    public class Employee
    {
        public int ID;
        public string name; //formatting string name
        public Employee() : this(0, "") { } //chain constructing
        public Employee(int ID, string name)
        {
            this.ID = ID;
            this.name = name;
        }

        public Employee(int ID): this(ID, "") { }
        public Employee(string name): this(0, name) { }
    }
}

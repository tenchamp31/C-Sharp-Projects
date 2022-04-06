using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    public class Employees
    {
        public string Id { get; set; } //Id string
        public string favcar { get; set; } //string for favcar

        public string Vacation { get; set; } //Vacation string

        
        

        public static bool operator ==(Employees employee1, Employees employee2)
        {
            return employee1.Id == employee2.Id;
        }
        public static bool operator !=(Employees employee1, Employees employee2)
        {
            return employee1.Id != employee2.Id;

        }
    }

}

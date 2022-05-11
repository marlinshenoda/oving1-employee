using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oving1_employee
{
   
    internal  class Employee
    {
      public string Name { get; }
       public uint Salary { get; } 
         public Employee(string name, uint salary)
        {
            //validation
            Name= name; 

            Salary= salary; 
        }
        public override string ToString() { 
            return $"Name: {Name} Salary: {Salary }";    
        }
    }
}

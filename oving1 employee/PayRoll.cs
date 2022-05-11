using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oving1_employee
{
    internal class PayRoll
    {
        private List<Employee> payroll;

        public PayRoll()   //structor
        {
            payroll= new List<Employee>();  
        }

        public void AddEmplyee(string name ,uint salary)
        {
            Employee employee=new Employee(name,salary);
            payroll.Add(employee);  
        }

        internal List<Employee> GetEmployees()
        {
         return payroll;    
        }
    }
}

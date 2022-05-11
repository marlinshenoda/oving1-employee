using System;
//using System.Collections.Generic;

namespace oving1_employee
{
    internal class Program
    { static 
            PayRoll payRoll = new PayRoll(); 
        static void Main(string[] args)
        {
            seedData();
            do { 
                ShowMainMeny(); 
            string input=Console.ReadLine();
            switch(input) {
                case "1":
                    AddEmployee();
                    break;

                    case "2":
                    PrintEmployees();

                    break;
                    case"3":
                    Environment.Exit(0);
                    break;
                    default:
                    break;
                }
            }
            while (true) ;   
        }
        private static void PrintEmployees()
        {
            List<Employee> employees = payRoll.GetEmployees();

            foreach (Employee employee in employees)
            {
               // Console.WriteLine($"Name:{employee.Name} Salary:{employee.Salary}");  
                Console.WriteLine(employee);    
            }
        }
        private static void ShowMainMeny()
        {
            Console.WriteLine("1: add Employee");
            Console.WriteLine("2: print Employee");
            Console.WriteLine("3: quit");
        }
        private static void AddEmployee()
        {
            Console.WriteLine("add an employee");
            string name = Util.AskForString("Name");
            uint salary = Util.AskForUint("Salary");
            payRoll.AddEmplyee(name, salary);
        }

        private static void seedData()
        {
            payRoll.AddEmplyee("Nisse", 10000);
            payRoll.AddEmplyee("kalle", 20000);
            payRoll.AddEmplyee("Anna", 40000);
            payRoll.AddEmplyee("Pelle", 50000);

        }
    }
}

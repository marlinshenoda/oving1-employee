using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oving1_employee
{
    internal class Util
    {
        public static string AskForString(string prompt)
        {
            string name;
            bool success = false;
            do
            {
                Console.WriteLine($"{prompt}: ");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine($"you must enter a valid {prompt}");
                }
                else
                {
                    success = true;
                }

            } while (success);
            return name;
        }

        internal static uint AskForUint(string prompt)
        {
            do
            {
                string input=AskForString(prompt);  
               // var Salary=int.Parse(input);
               if(uint.TryParse(input, out uint value))
                {
                    return value;  
                }
            }
            while (true);   
        }
    }
}

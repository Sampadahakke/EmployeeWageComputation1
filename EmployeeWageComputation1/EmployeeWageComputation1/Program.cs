using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmployeeWage employee = new EmployeeWage();
            employee.EmployeeAttendance();
            Console.ReadLine();
        }
    }
}

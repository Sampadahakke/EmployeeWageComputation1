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
            //EmployeeWage employee = new EmployeeWage();
            //employee.Condition();
            //employee.Display();
            //Creating object of company lis
            CompanyList companyList = new CompanyList();
            //Giving parameters for company
            companyList.Company("Facebook", 50, 22, 120);
            companyList.Display();
            Console.ReadLine();
        }
    }
}

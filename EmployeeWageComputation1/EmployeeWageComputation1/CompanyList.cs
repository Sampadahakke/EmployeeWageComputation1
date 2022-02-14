using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation1
{
    internal class CompanyList
    {
        //Creating object of dictionary 
        private Dictionary<string, EmployeeWage> companies = new Dictionary<string, EmployeeWage>();
        public void Company(string CompanyName, int ratePerHour, int maxWorkingDays, int maxHoursPerMonth)
        {
            companies.Add(CompanyName, new EmployeeWage(ratePerHour, maxWorkingDays, maxHoursPerMonth));
            companies[CompanyName].Condition();
        
        }

        //Displays all comanies and its details
        public void Display()
        {
        foreach (var company in companies)
            Console.WriteLine("\nCompany: " + company.Key + "\n\tWage details:\n\t" + company.Value.GetValue());
        }
        
      
    }
}


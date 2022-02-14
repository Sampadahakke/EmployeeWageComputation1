using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation1
{
    //Refactoring the code
    internal class EmployeeWage
    {
        const int IS_PRESENT = 1;
        const int IS_ABSENT = 0;
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 0;
        private readonly int  Emp_Rate_Per_Hour = 20;
        private readonly int NUM_OF_WORKING_DAYS = 20;
        private readonly int HOURS_PER_MONTH = 100;

        int totalDayWorked;
        int totalHourWorked;
        int monthlyWage;

        public EmployeeWage()
        {
            totalDayWorked = 0;
            totalHourWorked = 0;
            monthlyWage = 0;

        }

        public void Reset()
        {
            totalDayWorked = 0;
            totalHourWorked = 0;
            monthlyWage = 0;

        }

        public EmployeeWage(int ratePerHour, int maxWorkingDays, int maxHoursPerMonth)
        {
            Emp_Rate_Per_Hour = ratePerHour;
            NUM_OF_WORKING_DAYS = maxWorkingDays;
            HOURS_PER_MONTH = maxHoursPerMonth;
        }



        private int EmployeeAttendance()
        {

            Random random = new Random();
            int EmpCheck = random.Next(0, 2);

            if (EmpCheck == IS_PRESENT)
            {
                return IS_PRESENT;
            }
            else
            {
                return IS_ABSENT;
            }

        }

        // Calculation of Employee Wage Using Switch Case
        private int SwitchCase()
        {
            int EmpHrs = 0;
            int EmpWage = 0;
            Random random = new Random();
            int EmpCheck = random.Next(0, 2);

            switch (EmpCheck)
            {
                case IS_PART_TIME:
                    EmpHrs = 4;
                    break;

                case IS_FULL_TIME:
                    EmpHrs = 8;
                    break;

                default:
                    EmpHrs = 0;
                    break;
            }
            EmpWage = EmpHrs * Emp_Rate_Per_Hour;
            return EmpWage;
        }


        //Calculation of Monthly Wage

        public void MonthlyWage()
        {
            for (int i = 0; i < NUM_OF_WORKING_DAYS; i++)
                totalDayWorked += EmployeeAttendance();
            for (int j = 0; j < totalDayWorked; j++)
            {
                monthlyWage += SwitchCase();
            }

        }


        //Hour and Wage Condition
        public void Condition()
        {
            while (totalDayWorked != 20 && totalHourWorked < 100)
            {
                Reset();
                MonthlyWage();
            }
        }

        public void Display()
        {
            Console.WriteLine("Total Hours worked: " + totalHourWorked);
            Console.WriteLine("Total Days worked: " + totalDayWorked);
            Console.WriteLine("Monthly Wage: " + monthlyWage);
            Console.ReadLine();


        }

      
        
        public string GetValue()
        {
            return "Total Hours: " + totalHourWorked + "; Total Days: " + totalDayWorked + "; Total Wage: " + monthlyWage;
        }

    }
}

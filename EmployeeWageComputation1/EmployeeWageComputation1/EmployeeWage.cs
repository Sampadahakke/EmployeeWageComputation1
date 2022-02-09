using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation1
{
    internal class EmployeeWage
    {
        const int IS_PRESENT = 1;
        const int IS_ABSENT = 0;

        public void EmployeeAttendance()
        {

            Random random = new Random();
            int EmpCheck = random.Next(0, 2);

            if (EmpCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            Console.ReadLine();
    }   }
}

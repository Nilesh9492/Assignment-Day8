using System;

namespace EmployeeWage_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.CalculateEmployeeAttendance();
            employeeWage.CalculateDaillyEmpWage();
            employeeWage.PartTimeWage();
            employeeWage.EmpWageinswitch();
            employeeWage.EmpWagePerMonth();
            employeeWage.EmpWageinCondition();
            EmployeeWage.CalculationEmpWage();
        }
    }
}

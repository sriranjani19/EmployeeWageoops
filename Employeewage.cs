using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class program
    {
        public static voidMain(string[] args)
        {
            Console.WriteLine("Welecome to Employee Wage Computation Using OOPS");

            EmployeeAttendance empAttendance = new EmployeeAttendance();
            empAttendance.PresentorAbsent();

            //EmployeeWage empWage = new EmployeeWage();
            //empWage.calEmployee();

            //EmpSwitchcase empSwitchcase =new EmpSwitchcase();
            //empSwitchcase.CalEmployeeSwitch();

            //EmpWagePerMonth empWagePerMonth =new EmpWagePerMonth();
            //empWagePerMonyh.CalEmployeeWagePerMonth();

            EmpMonthlyWageCalc empMonthlyWageCalc = new EmpMonthlyWageCalc();
            empMonthlyWageCalc.EmpWageCalcWithHourOrDays();
        }
    }
}

        
           
      


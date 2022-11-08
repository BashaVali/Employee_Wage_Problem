using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Employee Wage Problem " + "\n\n");

                Console.WriteLine(" Select the option ");

                Console.WriteLine("1.Attendance" + "\n"+
                                  "2.CalculateDailyEmpWages" + "\n" +
                                  "3.PartTime"+"\n" +
                                  "4.SwitchCase"+"\n" +
                                  "5.MonthlyWage"+"\n" +
                                  "6.TotalMonthlyWages"+"\n");

                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        EmployeeWage employeeWage = new EmployeeWage();
                        employeeWage.Attendence();
                        break;
                    case 2:
                        EmployeeWage employeeWage2 = new EmployeeWage();
                        employeeWage2.EmpWage();
                        break;
                    case 3:
                        EmployeeWage employeeWage3 = new EmployeeWage();
                        employeeWage3.PartTime();
                        break;
                    case 4:
                        EmployeeWage employeeWage4 = new EmployeeWage();
                        employeeWage4.SwitchCase();
                        break;
                    case 5:
                        EmployeeWage employeeWage5 = new EmployeeWage();
                        employeeWage5.MonthlyWage();
                        break;
                    case 6:
                        EmployeeWage employeeWage6 = new EmployeeWage();
                        employeeWage6.TotalMonthlyWages();
                        break;
                }        
            }
        }
    }
}

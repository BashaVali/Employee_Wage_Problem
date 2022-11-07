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
                                  "3.PartTime"+"\n");

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
                }
            }
        }
    }
}

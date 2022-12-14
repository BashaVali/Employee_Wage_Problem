using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public const int MAX_Working_Days = 5;
        public const int MAX_Working_Hrs = 8;
        public const int Emp_rate_per_Hour = 20;
        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8, HALF_DAY_HR = 4, IS_PRESENT = 0, IS_FULL_TIME = 1, MONTH_WORK_DAY = 20;
        Random random = new Random();
        //UC1-Attendance
        public void Attendence()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
            //UC2-Calculate Daily Emp Wages
        }
        public void EmpWages()
        {
            int dailyEmpWage = 0, empHrs = 0;
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                empHrs = FULL_DAY_HR;
            else
                empHrs = 0;
            dailyEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine("Daily Emp Wage Full Day :" + dailyEmpWage);
            //UC3-PartTime
        }
        public void PartTime()
        {
            int dailyEmpWage = 0, empHrs = 0;
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                empHrs = HALF_DAY_HR;
            else
                empHrs = 0;
            dailyEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine("Daily Emp Wage Half Day :" + dailyEmpWage);
        }
        //UC4-SwitchCase
        public void SwitchCase()
        {
            int dailyEmpWage = 0;
            int empCheck = random.Next(0, 2);
            switch (empCheck)
            {

                case 0:
                    dailyEmpWage = WAGE_PER_HR * FULL_DAY_HR;
                    Console.WriteLine("Daily Emp Wage Full Day :" + dailyEmpWage);
                    break;
                case 1:
                    dailyEmpWage = WAGE_PER_HR * HALF_DAY_HR;
                    Console.WriteLine("Daily Emp Wage Half Day :" + dailyEmpWage);
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    break;
            }
        }
        //UC5-MonthlyWage
        public void MonthlyWage()
        {
            int FullWage = 0, HalfWage = 0;
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
            {
                FullWage = MONTH_WORK_DAY * WAGE_PER_HR * FULL_DAY_HR;
                HalfWage = MONTH_WORK_DAY * WAGE_PER_HR * HALF_DAY_HR;
                Console.WriteLine("Monthly Employee Full Day :" + FullWage);
                Console.WriteLine("Monthly Employee Half Day :" + HalfWage);

            }
            else
            {
                Console.WriteLine("Monthly Employee is Absent");
            }
        }
        //UC6-TotalMonthlyWages
        public void TotalMonthlyWages()
        {
            int day = 0, hours = 0, DailyEmpWage = 0, EmpWage = 0;
            while (day < 20 & hours < 100)
            {
                day++;
                hours += 8;

            }
            EmpWage = day * hours;
            DailyEmpWage = WAGE_PER_HR * EmpWage;
            Console.WriteLine("Employee Monthly Wage :" + DailyEmpWage);
        }
        //UC7-RefractoredEmpWage
        public void ComputeWage()
        {
            int empHours = 0;
            int empWage = 0;
            int workingHrs = 0;
            int totalWage = 0;
            int Working_Days = 2;
            Random random = new Random();
            while (Working_Days <= MAX_Working_Days && workingHrs <= MAX_Working_Hrs)
            {
                int empInput = random.Next(0, 3);
                switch (empInput)
                {
                    case Full_Time:
                        empHours = 8;
                        break;
                    case Part_Time:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                empWage = Emp_rate_per_Hour * empHours;
                workingHrs += empHours;
                totalWage += empWage;
                if (empInput != 0)
                {
                    Working_Days++;
                }

            }
            Console.WriteLine("workingHrs = {0} working days = {1} ", workingHrs, Working_Days);
            Console.WriteLine("Employee Wage for {0} days = {1} ", MAX_Working_Days, totalWage);
        }
        public void EmpWages(string company)
        {

            int empHours = 0;
            int empWage = 0;
            int workingHrs = 0;
            int totalWage = 0;
            int Working_Days = 2;
            Random random = new Random();
            int sum;

            while (Working_Days <= MAX_Working_Days && workingHrs <= MAX_Working_Hrs)
            {
                int empInput = random.Next(0, 3);
                switch (empInput)
                {
                    case Full_Time:
                        empHours = 8;
                        break;
                    case Part_Time:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                empWage = Emp_rate_per_Hour * empHours;
                workingHrs += empHours;
                totalWage += empWage;
                if (empInput != 0)
                {
                    Working_Days++;
                }

            }

            Console.WriteLine("Employee {0} is and monthly salary is : " + empWage, company);
        }
    }
}

         

       
        
    








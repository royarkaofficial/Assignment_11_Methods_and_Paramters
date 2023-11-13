using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11_Salary_Calculation_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Salary Calculation System");

            // Choose Employee Type
            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");

            int employeeType = int.Parse(Console.ReadLine());

            // Get input values based on the employee type
            Console.Write("Enter working hours: ");
            int workingHours = int.Parse(Console.ReadLine());
            Console.Write("Enter number of working days: ");
            int numOfWorkingDays = int.Parse(Console.ReadLine());
            int projectHandles = 0, extras = 0;

            if (employeeType == 1 || employeeType == 2)
            {
                // For HR and Admin
                Console.Write("Enter project handles: ");
                projectHandles = int.Parse(Console.ReadLine());
            }

            if (employeeType == 3)
            {
                // For Software Developer
                Console.Write("Enter project handles: ");
                projectHandles = int.Parse(Console.ReadLine());
                Console.Write("Enter extras: ");
                extras = int.Parse(Console.ReadLine());
            }

            // Call the method to calculate the salary
            double monthlySalary = CalculateSalary(workingHours, numOfWorkingDays, projectHandles, extras);
            Console.WriteLine($"\nMonthly Salary: {monthlySalary:C}");
        }
        static double CalculateSalary(int wHour, int nWDays, int projectHandles = 0, int extras = 0)
        {
            double salary = wHour * nWDays * 100 + projectHandles * 3000 + extras * 2000;
            return salary;
        }
    }
}

using System;

namespace LabFour
{
    class Program
    {
        static void Main(string[] args)
        {
            DobraEmployee.companyName = "Emanuel Dobra's Rollers";
            DobraEmployee employee = new DobraEmployee("4262562", 21, 45000);
            int totalSalary;
            employee.employeeId = "5087";

            Console.WriteLine("New employee ID: " + employee.employeeId + " has been successfully assigned.");
            
            totalSalary = employee.DetermineSalary();
            
            Console.WriteLine("Total Salary: " + totalSalary + ", Company: " + DobraEmployee.companyName);
            Console.ReadLine();
        }
    }
}

using System;

/* Emanuel Dobra
   Lab 04         */

namespace LabFour
{
    class DobraEmployee
    {
        public static string companyName;
        public string employeeId;
        public int baseSalary;
        public int commissionSalary;

        public DobraEmployee(string initialEmployeeId, int initialBaseSalary, int initialCommissionSalary)
        {
            employeeId = initialEmployeeId;
            baseSalary = initialBaseSalary;
            commissionSalary = initialCommissionSalary;
        }

        public int DetermineSalary()
        {
            return baseSalary + commissionSalary;
        }
    }

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
/**
Output:
Student One: Emanuel Dobra is in section 100
Student Two: Tar Gonzales is in section 200
Hello Bob
Grade 1: 53.54, Grade 2: 73.54, Grade 3: 67.5, Grade 4: 92.4
Hello Emanuel Dobra
*/

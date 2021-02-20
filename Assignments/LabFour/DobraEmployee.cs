using System;

namespace LabFour
{
    class DobraEmployee
    {
        public static string companyName;
        public string employeeId;
        public int baseSalary, commissionSalary;

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
}

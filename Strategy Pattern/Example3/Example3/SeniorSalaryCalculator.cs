using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    public class SeniorSalaryCalculator : ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<Employee> employees)
            => employees.Where(employee => employee.Level == EmployeeLevel.Senior)
                    .Select(employee => employee.CalculateSalary() * 1.1)
                    .Sum();
    }
}

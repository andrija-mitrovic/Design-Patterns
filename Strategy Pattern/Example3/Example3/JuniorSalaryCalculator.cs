using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    public class JuniorSalaryCalculator : ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<Employee> employees)
            => employees.Where(employee => employee.Level == EmployeeLevel.Junior)
                .Select(employee => employee.CalculateSalary())
                .Sum();
    }
}

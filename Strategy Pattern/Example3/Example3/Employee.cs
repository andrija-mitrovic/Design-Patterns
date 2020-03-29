using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EmployeeLevel Level { get; set; }
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }
        public double CalculateSalary() => WorkingHours * HourlyRate;
    }
}
